using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace neuroCourse
{
    internal class LayerNetwork
    {
        private List<NeuronLayer> _layers = new List<NeuronLayer>();
        private double[] _input;
        private double[] _output;
        public LayerNetwork(int input_size, int network_size, int[] layer_size, Func<double, double>[] ActivationFuncs)
        {
            _output = new double[layer_size[^1]];
            _input = new double[input_size];
            _layers.Add(new NeuronLayer(layer_size[0], input_size, ActivationFuncs[0]));
            for (int i = 1; i < network_size; i++)
                _layers.Add(new NeuronLayer(layer_size[i], layer_size[i - 1], ActivationFuncs[i]));
        }
        
        public void SetInput(double[] input)
        {
            _input = input;
            //SetSame();  // Результат на выходе должен быть везде одинаковым
        }
        private void Compute()
        {
            double[] proceed_layer = _input;

            for (int i = 0; i < _layers.Count; i++)
            {
                _layers[i].SetInput(proceed_layer);
                proceed_layer = _layers[i].GetOutput();
            }
            _output = proceed_layer;
        }
        public double[] GetOutput()
        {
            Compute();
            return _output;
        }

        private void SetSame()
        {
            foreach (NeuronLayer layer in _layers)
            {
                layer.SameWeightsAndBias_test();
            }
        }
        public void Train(string file_path, int epochs, double step)
        {
            StreamWriter sw = new StreamWriter("out.txt");
            double[] loss = new double[epochs];
            double l_error = 0;
            for (int i = 0; i < epochs; i++)
            {
                using (StreamReader sr = new StreamReader(file_path))
                {
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] train_data = line.Split(';');
                        string[] string_input = train_data.SkipLast(1).ToArray();
                        _input = string_input.Select(s => double.Parse(s)).ToArray<double>();

                        int index_result = Convert.ToInt32(train_data[^1]);
                        double[] real_output = GetOutput();
                        for (int z=0;z<real_output.Length; z++)
                            sw.Write(real_output[z]);

                        sw.WriteLine('X');
                        double[] wanted_output = GetWantedOutputs(index_result, _output.Length);

                        l_error = SparseCrossEntropy(index_result, real_output);
                        double[] previous_gradient = new double[_layers[^1]._neurons.Count];
                        for (int j = 0; j < _layers[^1]._neurons.Count; j++)
                        {
                            double error = real_output[j] - wanted_output[j];
                            previous_gradient[j] = GradientForSigmoid(error, real_output[j]);
                            Neuron neuron = _layers[^1]._neurons[j];
                            for (int k = 0; k < neuron._weight.Length ; k++)
                                neuron._weight[k] -= step * previous_gradient[j] * neuron._input[k];
                            neuron._bias -= step * previous_gradient.Sum();
                        }
                        for (int l = 2; l <= _layers.Count; l++) 
                        {
                            double[] local_gradient = new double[_layers[^l]._neurons.Count];
                            for (int m = 0; m < _layers[^l]._neurons.Count; m++)
                            {
                                double temp_sum = 0.0;
                                Neuron neuron = _layers[^l]._neurons[m];
                                for (int n = 0; n < previous_gradient.Length; n++)
                                    temp_sum += previous_gradient[n] * _layers[^(l - 1)]._neurons[n]._weight[m];
                                local_gradient[m] = GradientForSigmoid(temp_sum, neuron.Activate());
                                for (int k = 0; k < neuron._weight.Length; k++)
                                    neuron._weight[k] -= step * local_gradient[m] * neuron._input[k];
                                neuron._bias -= step * previous_gradient.Sum();
                            }
                            previous_gradient = local_gradient;
                        }   
                    }
                    loss[i] = l_error;
                }     
            }
        sw.Close();

        }
        private double[] GetWantedOutputs(int index, int size)
        {
            double[] output = new double[size];
            output[index] = 1;
            return output;
        }
        private double SparseCrossEntropy(int wanted_result, double[] real_result)
        {
            return -Math.Log(real_result[wanted_result]);
        }
        private double GradientForSigmoid(double error, double neuron_res)
        {
            return error * neuron_res * (1 - neuron_res);
        }
    }
}
