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
            outputBox.Clear();
            KohonenNetwork network = new KohonenNetwork(Convert.ToInt32(numParams.Value), Convert.ToInt32(numClusters.Value));
            network.SelfTrain(0.001, 0.3, "dataset1.txt");
            var output = network.getOutput();
            foreach (var item in output)
            {
                outputBox.Text += item.ToString() + '\r' + '\n';
            }
        }
    }
}