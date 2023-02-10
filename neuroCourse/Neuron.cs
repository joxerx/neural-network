using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neuroCourse
{
    internal class Neuron
    {
        public double[] _input;
        public double[] _weight;
        public double _bias;
        private Func<double, double> activationFunc;

        public Neuron(int size, Func<double, double> ActivationFunc)
        {
            _input = new double[size];
            _weight = new double[size];
            activationFunc = ActivationFunc;
            RandomizeWights();
            RandomizeBias();
        }


        public void SetInput(double[] input)
        {
            _input = input;
        }
        private void RandomizeWights()
        {
            Random random = new Random();

            for (int i = 0; i < _weight.Length; i++)
                _weight[i] = random.NextDouble();
        }
        private void RandomizeBias()
        {
            Random random = new Random();
            _bias = random.NextDouble();
        }
        public double Summator()
        {
            double sum = 0;

            for(int i = 0; i < _input.Length; i++)
                sum += _input[i] * _weight[i];

            return sum + _bias;
        }
        public double Activate()
        {
            return activationFunc(Summator());
        }

        public void SetWeights(double[] weight)
        {
            _weight = weight;
        }
        public void SetBias(double bias)
        {
            _bias = bias;
        }
    }
}
