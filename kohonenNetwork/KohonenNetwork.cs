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
        public void Train(int epochs, double learningSpeed, string filePath)
        {
            double[][] trainSet = new double[System.IO.File.ReadAllLines(filePath).Length][];
            using (StreamReader sr = new StreamReader(filePath))
            {
                string? line;
                int line_count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] input_string = line.Split(';');
                    double[] input_double = new double[input_string.Length];
                    for (int j = 0; j < _input.Length; j++)
                        input_double[j] = Convert.ToDouble(input_string[j]);
                    trainSet[line_count] = input_double;
                    line_count++;
                }
            }
            NormalizeDataset(trainSet);


            for (int i = 0; i < epochs; i++)
            {
                int indexMin = FindClosestCluster();

                for (int j = 0; j < _neurons[indexMin]._weight.Length; j++)
                    _neurons[indexMin]._weight[j] += learningSpeed * (_input[j] - _neurons[indexMin]._weight[j]);
            }
        }

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


        public void NormalizeDataset(double[][] dataset)
        {
            //double[][] result = new double[dataset.Length][];
            double min;
            double max;
            for (int col = 0; col < dataset[0].Length; col++)
            {

                max = dataset[0][col];
                min = dataset[0][col];
                for (int line = 1; line < dataset.Length; line++) 
                {
                    if (dataset[line][col] < min) min = dataset[line][col];
                    if (dataset[line][col] > max) max = dataset[line][col];
                }
                for (int line = 0; line < dataset.Length; line++) 
                {
                    dataset[line][col] = (-1) + (dataset[line][col] - min) / (max - min) * 2;
                }
            }

            //return result;
        }

    }
}
