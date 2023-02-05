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

        private int _size;
        private double[] _data;

        List<Neuron> _neurons = new List<Neuron>();
        public FullyConnectedNetwork(int size, Func<double, double>[] ActivationFunc)
        {
            _size = size;
            for (int i = 0; i < _size; i++)
                _neurons.Add(new Neuron(size, ActivationFunc[i]));
            _data = new double[size];
        }

        public void InitializeNetwork(double[] input)
        {
            _data = input;

            //SameWeightsAndBias_test(); // Проверка работы с одними и теми же весами и смещениями. Результат должен быть одинаков для всех выходов

            Compute();
        }

        private void Compute()
        {
            List<double> output = new List<double>();

            foreach (Neuron neuron in _neurons)
            {
                neuron.SetInput(_data);
                output.Add(neuron.Activate());
            }

            _data = output.ToArray();
        }

        public double[] GetOutput()
        {
            Compute();
            return _data;
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
