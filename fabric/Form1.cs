using Factory_Method;

namespace fabric
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int countclick = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new Client();
            string relativePath = "test.txt";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            var fileLoggerFactory = new FileLoggerFactory(fullPath);
            client.Main(fileLoggerFactory, label1.Text);

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            countclick += 1;
            label1.Text = "";
            label1.Text = "Click: " + countclick.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = new Client();
            var fileLoggerFactory = new ConsoleLoggerFactory();
            client.Main(fileLoggerFactory, label1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var client = new Client();
            var componentLoggerFactory = new ComponentLoggerFactory(listBox1);
            client.Main(componentLoggerFactory, label1.Text);
        }
    }
}