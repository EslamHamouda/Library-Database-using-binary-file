using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        public string filename = "";
        public int length = 0;
        public int bytesPerBook = 42;
        public int startBook = 0;
        public int startBook2 = 0;
        public bool flag=false;
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
                   
                    br.ReadString();

                    br.ReadString();

                    br.ReadInt16().ToString();

                    br.ReadInt16().ToString();

                    br.ReadInt16().ToString();

                    startBook2 += startBook;  
                    
                }

                startBook += bytesPerBook; 
            }
           
            
            br.Close();

            filename = "D:\\Files\\" + textBox1.Text + ".txt";

            BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Open, FileAccess.Write));

            bw.BaseStream.Seek(startBook2, SeekOrigin.Begin);

            bw.Write("");
            bw.Write("");

            bw.Write("");

            bw.Write("");

            bw.Write("");
            bw.Write("");
            bw.Write("");

            MessageBox.Show("Done", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bw.Close();
            startBook = startBook2 = 0;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
