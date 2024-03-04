namespace TPMOD3_
{
    public partial class Form1 : Form
    {
        public int click1, click2, hasil;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            click1 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            click2 = Convert.ToInt32(textBox1.Text);
            hasil = click1 + click2;
            textBox1.Text = Convert.ToString(hasil);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            Console.WriteLine(textBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            Console.WriteLine(textBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
            Console.WriteLine(textBox1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
            Console.WriteLine(textBox1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
            Console.WriteLine(textBox1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
            Console.WriteLine(textBox1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
            Console.WriteLine(textBox1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
            Console.WriteLine(textBox1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
            Console.WriteLine(textBox1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
            Console.WriteLine(textBox1);
        }
    }
}
