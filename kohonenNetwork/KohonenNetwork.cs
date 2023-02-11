using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kohonenNetwork
{
    internal class KohonenNetwork
    {
        private List<KohonenNeuron> _neurons = new List<KohonenNeuron>();
        private double[] _input;
        public KohonenNetwork(int inputSize, int numClusters)
        {
            _input = new double[inputSize];
            for (int i = 0; i < numClusters; i++)
                _neurons.Add(new KohonenNeuron(inputSize));
        }
        public void SetInput(double[] input)
        {
            _input = input;
        }
        /*public void Train(int epochs, double learningSpeed, string filePath)
        {
            for (int i = 0; i < epochs; i++)
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] input_string = line.Split(';');
                        for (int j = 0; j < _input.Length; j++)  
                            _input[j] = Convert.ToDouble(input_string[j]);

                        //NormalizeInput();

                        
                        

                        int indexMin = FindClosestCluster();

                        for (int j = 0; j < _neurons[indexMin]._weight.Length; j++) 
                            _neurons[indexMin]._weight[j] += learningSpeed * (_input[j] - _neurons[indexMin]._weight[j]);

                    }
                }
            }
        }*/

        public int FindClosestCluster()
        {
            _neurons[0].SetInput(_input);
            double min_dist = _neurons[0].Distance();
            int index = 0;
            for (int i = 1; i < _neurons.Count; i++)
            {
                _neurons[i].SetInput(_input);
                if (_neurons[i].Distance() < min_dist)
                {
                    index = i;
                    min_dist = _neurons[i].Distance();
                }
            }
            return index;
        }


        public double[] NormalizeInput()
        {
            double min = _input.Min();
            double max = _input.Max();
            for (int i = 0; i < _input.Length; i++)
                _input[i] = (-1) + (_input[i] - min) / (max - min) * 2;

            return _input;    
        }

        public void Train(int epochs, double learningSpeed, double[][] trainSet)
        {
            for (int i = 0; i < epochs; i++)
            {
                double[] dists = new double[trainSet.Length];

                for (int k = 0; k < trainSet.Length; k++)
                {
                    double maxDist = 0d;
                    int maxIdx = 0;

                    double[] distVec = new double[1];

                    for (int n = 0; n < _neurons.Length; n++)
                    {

                        double len = 0d;
                        distVec = GetDistanceVec(trainSet[k], _neurons[n].Weights, out len);


                        if (Math.Abs(len) > Math.Abs(maxDist))
                        {
                            maxDist = len;
                            maxIdx = n;
                        }
                    }

                    for (int w = 0; w < _neurons[0].Weights.Length; w++)
                    {
                        _neurons[maxIdx].Weights[w] += distVec[w] * learningSpeed;
                    }

                    double lengthX = 0;

                    for (int w = 0; w < _neurons[0].Weights.Length; w++)
                    {
                        lengthX += Math.Pow(_neurons[maxIdx].Weights[w], 2);
                    }

                    lengthX = Math.Sqrt(lengthX);

                    double[] normVecX = _neurons[maxIdx].Weights.Select(w => w / lengthX).ToArray();

                    _neurons[maxIdx].Weights[0] = normVecX[0];
                    _neurons[maxIdx].Weights[1] = normVecX[1];
                }
            }
        }

        private double[] GetDistanceVec(double[] x, double[] y, out double len)
        {
            double[] dist = new double[x.Length];

            double lengthX = 0;

            for (int i = 0; i < x.Length; i++)
            {
                lengthX += Math.Pow(x[i], 2);
            }

            lengthX = Math.Sqrt(lengthX);

            double[] normVecX = x.Select(i => i / lengthX).ToArray();

            double lengthY = 0;

            for (int i = 0; i < x.Length; i++)
            {
                dist[i] = y[i] - x[i];
                lengthY += Math.Pow(dist[i], 2);
            }

            lengthY = Math.Sqrt(lengthY);

            dist = dist.Select(i => i / lengthY).ToArray();

            len = lengthY;

            return dist;
        }
    }
}
