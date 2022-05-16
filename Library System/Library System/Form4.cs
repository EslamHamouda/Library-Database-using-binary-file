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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string filename = "";
        public int bytesPerBook = 42;
        public int startBook = 0;
        public int length = 0;
        public bool flag = false;
        private void button2_Click(object sender, EventArgs e)
        {
            filename = "D:\\Files\\" + textBox1.Text + ".txt";
            BinaryReader br = new BinaryReader(File.Open(filename, FileMode.Open, FileAccess.Read));

            length = (int)br.BaseStream.Length / bytesPerBook;

            for (int i=0; i< length; i++)
            {

                br.BaseStream.Seek(startBook, SeekOrigin.Begin);
                if(br.ReadInt16().ToString() == textBox2.Text.ToString())
                {
                    
                    br.ReadInt16().ToString();       

                    label5.Visible = true;
                    textBox4.Visible = true;
                    textBox4.Text = br.ReadString();

                    label4.Visible = true;
                    textBox3.Visible = true;
                    textBox3.Text = br.ReadString();

                    label6.Visible = true;
                    textBox5.Visible = true;
                    textBox5.Text = br.ReadInt16().ToString();

                    label7.Visible = true;
                    textBox6.Visible = true;
                    textBox6.Text = br.ReadInt16().ToString();
                    textBox6.Text = br.ReadInt16().ToString();
                   

                    flag = true;
                }
               
                    startBook += bytesPerBook;
            }
            if(flag==false)
            {
                label9.Visible=true;
            }
            br.Close();
            startBook = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
