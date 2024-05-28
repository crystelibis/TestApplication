namespace TestApp {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox1.Text);
            Calculator.Calculate(count, textBox3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox1.Text);
            if (Directory.GetFiles("C:\\Users\\cryst\\TestApp\\TestApp\\Files").Length == 0)
            {
                for (int i = 0; i < count; i++)
                {
                    File.WriteAllText($"C:\\Users\\cryst\\TestApp\\TestApp\\Files\\{i}.txt", i.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = Calculator.GetCurrentText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = Calculator.GetText();
        }
    }
}