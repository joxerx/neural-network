using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public void InitializeNetwork(double[] input)
        {
            _input = input;
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
    }
}
