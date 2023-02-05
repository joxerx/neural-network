namespace neuroCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Neuron neuron = new Neuron(10, ActivationFunctions.Treshold);

        }
    }
}