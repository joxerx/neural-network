using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kohonenNetwork
{
    internal class KohonenNeuron
    {
        private double[] _input;
        public double[] _weight;

        public KohonenNeuron(int size)
        {
            _input = new double[size];
            _weight = new double[size];
            RandomizeWights();
        }
        private void RandomizeWights()
        {
            Random random = new Random();

            for (int i = 0; i < _weight.Length; i++)
            {
                while(true)
                {
                    _weight[i] = random.NextDouble() * (Math.Pow(-1, random.Next(1, 3)));
                    if (Math.Abs(_weight[i]) <= (1 / Math.Sqrt(_input.Length)))
                        break;
                }
            }
                
        }
        public void SetInput(double[] input)
        {
            _input = input;
        }
        public void SetWeight(double[] weight)
        {
            _weight = weight;
        }
        public double Distance()
        {
            double res = 0;
            for (int i = 0; i < _weight.Length; i++)
            {
                res += Math.Pow(_input[i] - _weight[i], 2);
            }
            return Math.Sqrt(res);
        } 
    }
}
