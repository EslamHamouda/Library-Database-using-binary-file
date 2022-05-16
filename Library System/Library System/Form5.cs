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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public string filename = "";
        public int bytesPerBook = 42;
        public int startBook = 0;
        public int startBook2 = 0;
        public int length = 0;
        public bool flag = false;

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filename = "D:\\Files\\" + textBox1.Text + ".txt";
          
            BinaryReader br = new BinaryReader(File.Open(filename, FileMode.Open, FileAccess.Read));
           
            length = (int)br.BaseStream.Length / bytesPerBook;

            for (int i = 0; i < length; i++)
            {

                br.BaseStream.Seek(startBook, SeekOrigin.Begin);
                if (br.ReadInt16().ToString() == textBox2.Text.ToString())
                {
                    br.ReadInt16().ToString();

                    textBox4.Text = br.ReadString();

                    textBox3.Text = br.ReadString();

                    textBox5.Text = br.ReadInt16().ToString();

                    textBox6.Text = br.ReadInt16().ToString();

                    textBox6.Text = br.ReadInt16().ToString();

                    startBook2 += startBook;

                    flag = true;
                }

                startBook += bytesPerBook;
            }
            if (flag == false)
            {
                label9.Visible = true;
            }
            br.Close();

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            filename = "D:\\Files\\" + textBox1.Text + ".txt";
    
            BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Open, FileAccess.Write));

                bw.BaseStream.Seek(startBook2, SeekOrigin.Begin);

                bw.Write(int.Parse(textBox2.Text));

                textBox4.Text = textBox4.Text.PadRight(14);
                bw.Write(textBox4.Text.Substring(0, 14));

                textBox3.Text = textBox3.Text.PadRight(14);
                bw.Write(textBox3.Text.Substring(0, 14));

                bw.Write(int.Parse(textBox5.Text));

                bw.Write(int.Parse(textBox6.Text));

            bw.Close();
            startBook = 0;
        }
    }
    }
