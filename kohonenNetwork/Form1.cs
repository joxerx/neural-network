namespace kohonenNetwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KohonenNetwork network = new KohonenNetwork(7, 4);
            network.Train(1000, 0.001, "dataset1.txt");
            using (StreamReader sr = new StreamReader("dataset1.txt"))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] input_string = line.Split(';');
                    double[] _input = new double[input_string.Length];
                    for (int j = 0; j < _input.Length; j++)
                        _input[j] = Convert.ToDouble(input_string[j]);
                    network.SetInput(_input);
                    //network.NormalizeInput();


                    MessageBox.Show(Convert.ToString(network.FindClosestCluster()));

                }
            }
        }
    }
}