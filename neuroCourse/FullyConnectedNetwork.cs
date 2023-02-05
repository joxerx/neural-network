using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neuroCourse
{
    internal class FullyConnectedNetwork
    {
        //реализовать полносвязную сеть для указанного количества нейронов.
        //Она должна уметь получать вход, вычислять выход и отдавать выход.
        // 
        private int _size;
        private double[] _input;

        List<Neuron> _neurons = new List<Neuron>();
        public FullyConnectedNetwork(int size, Func<double, double>[] ActivationFunc)
        {
            _size = size;
            for (int i = 0; i < _size; i++)
                _neurons.Add(new Neuron(size, ActivationFunc[i]));
            _input = new double[size];
        }

        public void InitializeNetwork(double[] input)
        {
            _input = input;

            //SameWeightsAndBias_test();


            Compute();
        }
        private void Compute()
        {
            List<double> output = new List<double>();
            foreach (Neuron neuron in _neurons)
            {
                neuron.SetInput(_input);
                output.Add(neuron.Activate());
            }
            _input = output.ToArray();
        }
        public double[] GetOutput()
        {
            Compute();
            return _input;
        }
        private void SameWeightsAndBias_test()
        {
            double[] weights = new double[_size];
            Random random = new Random();

            for (int i = 0; i < _size; i++)
                weights.Append(random.NextDouble() + 1);

            foreach (Neuron neuron in _neurons)
            {
                neuron.SetWeights(weights);
                neuron.SetBias(0.1);
            }
        }
    }
}
