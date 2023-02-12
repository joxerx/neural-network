namespace kohonenNetwork
{
    public partial class Form1 : Form
    {
        string filePath = "datasetKeyBs.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            KohonenNetwork network = new KohonenNetwork(Convert.ToInt32(numParams.Value), Convert.ToInt32(numClusters.Value));
            network.SelfTrain(0.0001, 0.3, filePath);
            var output = network.getOutput();
            foreach (var item in output)
            {
                outputBox.Text += item.ToString() + '\r' + '\n';
            }
        }

        private void selfOrganise_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            KohonenNetwork network = new KohonenNetwork(Convert.ToInt32(numParams.Value), 1);
            network.SelfOrganizing(0.0001, 0.3, 2, filePath);
            var output = network.getOutput();
            foreach (var item in output)
            {
                outputBox.Text += item.ToString() + '\r' + '\n';
            }
        }
    }
}