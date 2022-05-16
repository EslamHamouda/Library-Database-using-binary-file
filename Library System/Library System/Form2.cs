using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string filename = "";
        public int length = 0;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            filename = "D:\\Files\\" + textBox1.Text + ".txt";
            BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Open, FileAccess.Write));
            length = (int)bw.BaseStream.Length;
            if (length != 0)
            {
                bw.BaseStream.Seek(length, SeekOrigin.Begin);
            }
            bw.Write(int.Parse(textBox2.Text));
            
            textBox3.Text = textBox3.Text.PadRight(14);
            bw.Write(textBox3.Text.Substring(0, 14));

            textBox4.Text = textBox4.Text.PadRight(14);
            bw.Write(textBox4.Text.Substring(0, 14));

            bw.Write(int.Parse(textBox5.Text));

            bw.Write(int.Parse(textBox6.Text));

            textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";

            MessageBox.Show("Done", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
