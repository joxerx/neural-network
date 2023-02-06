using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neuroCourse
{
    internal class NeuronLayer
    {
        private List<Neuron> _neurons = new List<Neuron>();
        private double[] _input;
        private double[] _output;
        public NeuronLayer(int size, int input_size, Func<double, double> ActivationFunc)
        {
            _output = new double[size];
            _input = new double[input_size];
            for(int i = 0; i< size; i++)
                _neurons.Add(new Neuron(input_size, ActivationFunc));
        }
        public void SetInput(double[] input)
        {
            _input = input;
        }
        private void Compute()
        {
            List<double> output = new List<double>();
            foreach (Neuron neuron in _neurons)
            {
                neuron.SetInput(_input);
                output.Add(neuron.Activate());
            }
            _output = output.ToArray();
        }
        public double[] GetOutput()
        {
            Compute();
            return _output;
        }
    }
}
