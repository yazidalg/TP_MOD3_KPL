namespace TPMOD3_
{
    public partial class Form1 : Form
    {
        public int click1, click2, click3, hasil;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Setiap kali di klik maka hasilnya akan 0
            click3 = 0;
            // Kemudian di tambahkan convert, dan klik selanjutnya akan di tambahkan dengan click1
            // dan di simpan ke variable click3
            click3 = Convert.ToInt32(textBox1.Text);
            click1 = click1 + click3;
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            click3 = 0;
            click2 = Convert.ToInt32(textBox1.Text);
            hasil = click1 + click2;
            textBox1.Text = Convert.ToString(hasil);
            click1 = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            textBox1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            textBox1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            textBox1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            textBox1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            textBox1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            textBox1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            textBox1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            textBox1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            textBox1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            textBox1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
