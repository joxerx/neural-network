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
        private Dictionary<int, string> _output = new Dictionary<int, string>();
        public KohonenNetwork(int inputSize, int numClusters)
        {
            _input = new double[inputSize];
            for (int i = 0; i < numClusters; i++)
                _neurons.Add(new KohonenNeuron(inputSize));
        }

        public void SelfTrain(double delta, double learningSpeed, string filePath)
        {
            double[][] dataset = convertTxtToDataset(filePath);

            while (learningSpeed > 0)
            {
                for (int line = 0; line < dataset.Length; line++)
                {
                    _input = dataset[line];
                    int indexMin = FindClosestCluster();
                    for (int j = 0; j < _neurons[indexMin]._weight.Length; j++)
                        _neurons[indexMin]._weight[j] += learningSpeed * (_input[j] - _neurons[indexMin]._weight[j]);
                }
                learningSpeed -= delta;
            }
            for (int line = 0; line < dataset.Length; line++)
            {
                _input = dataset[line];
                int idCluster = FindClosestCluster();
                if (_output.ContainsKey(idCluster))
                    _output[idCluster] += ", " + (line + 1);
                else
                    _output[idCluster] = "Включает в себя образцы с номерами: " + (line + 1);
            }
        }
        public void SelfOrganizing(double delta, double learningSpeed, double criticalDist, string filePath)
        {
            double[][] dataset = convertTxtToDataset(filePath);
            _input = dataset[0];
            //_neurons.Add(new KohonenNeuron(_input.Length));
            _neurons[0].SetWeight(_input);



            while (learningSpeed > 0)
            {
                List<int> idsUsedNeurons = new List<int>();
                for (int line = 0; line < dataset.Length; line++)
                {
                    _input = dataset[line];
                    int idCluster = FindClosestCluster();
                    if (_neurons[idCluster].Distance() <= criticalDist)
                    {
                        for (int j = 0; j < _neurons[idCluster]._weight.Length; j++)
                        {
                            _neurons[idCluster]._weight[j] += learningSpeed * (_input[j] - _neurons[idCluster]._weight[j]);
                            idsUsedNeurons.Add(idCluster);
                        }
                    }           
                    else
                    {
                        _neurons.Add(new KohonenNeuron(_input.Length));
                        _neurons[^1].SetWeight(_input);
                        idsUsedNeurons.Add(_neurons.Count - 1);
                    }
                }

                for (int i = 0; i< _neurons.Count; i++)
                {
                    if (!idsUsedNeurons.Contains(i))
                    {
                        _neurons.RemoveAt(i);
                        i--;
                    }
                       
                }
                learningSpeed -= delta;
            }
            for (int line = 0; line < dataset.Length; line++)
            {
                _input = dataset[line];
                int idCluster = FindClosestCluster();
                if (_output.ContainsKey(idCluster))
                    _output[idCluster] += ", " + (line + 1);
                else
                    _output[idCluster] = "Включает в себя образцы с номерами: " + (line + 1);
            }
        }
        private int FindClosestCluster()
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
        public Dictionary<int, string> getOutput()
        {
            return _output;
        }
        private void NormalizeDataset(double[][] dataset)
        {
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
        }
        private double[][] convertTxtToDataset(string filePath)
        {
            double[][] dataset = new double[System.IO.File.ReadAllLines(filePath).Length][];
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
                    dataset[line_count] = input_double;
                    line_count++;
                }
            }
            NormalizeDataset(dataset);
            return dataset;
        } 
    }
}
