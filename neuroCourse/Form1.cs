namespace neuroCourse
{
    public partial class Form1 : Form
    {
        string filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Neuron neuron = new Neuron(10, ActivationFunctions.Treshold);
            var funcs = new Func<double, double>[] { ActivationFunctions.Gauss, ActivationFunctions.Gauss, ActivationFunctions.Gauss, ActivationFunctions.Gauss };
            FullyConnectedNetwork network = new FullyConnectedNetwork(4, funcs);

            double[] input = new double[] { 1.2, 3.3, 4.2, 1.2 };
            network.InitializeNetwork(input);



            int[] layers_sizes = new int[] { 3, 6, 2, 3 };
            LayerNetwork net = new LayerNetwork(input.Length, 4, layers_sizes, funcs);
            net.SetInput(input);
            double[] out_layered = net.GetOutput();


            double[] res = network.GetOutput();
        }

        private void trainBtn_Click(object sender, EventArgs e)
        {
            int[] layer_sizes = { 4, 10, 3 };
            Func<double, double>[] funcs = { ActivationFunctions.Sigmoid, ActivationFunctions.Sigmoid, ActivationFunctions.Sigmoid };
            LayerNetwork network = new LayerNetwork(4, 3, layer_sizes, funcs);
            network.Train("trainset.txt", 1000, 0.01);
            double[] input = new double[] { 6.3, 2.9, 5.6, 1.8}; //2
            double[] input1 = new double[] { 5.7, 4.4, 1.5, 0.4}; //0
            network.SetInput(input);

            string res = "";
            foreach (double elem in input)
            {
                res += Convert.ToString(elem) + "\t";
            }
            res += "ответ: ";
            double[] answer = network.GetOutput();
            double max = answer.Max();
            int indx = Array.IndexOf(answer, max);
            res += Convert.ToString(indx) + "\n\r";


            res += '\n';
            network.SetInput(input1);
            foreach (double elem in input1)
            {
                res += Convert.ToString(elem) + "\t";
            }
            res += "ответ: ";
            answer = network.GetOutput();
            max = answer.Max();
            indx = Array.IndexOf(answer, max);
            res += Convert.ToString(indx) + "\n\r";
            textBox1.Text += res;
        }

        private void choseTrainsetBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    filePathBox.Text = filePath;
                }
            }
        }
    }
}