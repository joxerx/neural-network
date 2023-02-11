namespace neuroCourse
{
    public partial class Form1 : Form
    {
        string filePath = string.Empty;
        LayerNetwork? network;

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
            int[] layer_sizes = { 4, 10, Convert.ToInt32(numCategories.Value) };
            Func<double, double>[] funcs = { ActivationFunctions.Sigmoid, ActivationFunctions.Sigmoid, ActivationFunctions.Sigmoid };
            network = new LayerNetwork(Convert.ToInt32(numParameters.Value), 3, layer_sizes, funcs);
            network.Train("trainset.txt", Convert.ToInt32(numEpochs.Value), Convert.ToDouble(learningSpeed.Value));
        }

        private void choseTrainsetBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\user\\Desktop\\neuroCourse\\neuroCourse\\bin\\Debug\\net7.0-windows";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string[] input_string = textBox1.Text.Split(';');
            double[] input = new double [input_string.Length];
            for (int i = 0; i < input.Length; i++) 
                input[i] = Convert.ToDouble(input_string[i]);

            network?.SetInput(input);
            double[] result = network.GetOutput();
            double max = result.Max();
            int indx = Array.IndexOf(result, max);

            textBox1.Text += " категория: " + Convert.ToString(indx);

        }
    }
}