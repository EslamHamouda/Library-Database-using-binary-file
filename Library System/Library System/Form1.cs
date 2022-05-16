namespace Library_System
{
    public partial class Form1 : Form
    {

        public string filename = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filename = "D:\\Files\\" + textBox1.Text + ".txt";
            if(!File.Exists(filename))
            {
                File.Create(filename).Close();
                MessageBox.Show("File is Created","Note",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                label2.Visible = true;

        }

       

        private void Delete_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}