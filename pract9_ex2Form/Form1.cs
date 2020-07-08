using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract9_ex2Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                findLine();

            }
        }

        private void findLine()
        {
            FileStream fileStream = new FileStream("..\\..\\..\\text.txt", FileMode.OpenOrCreate);
            StreamReader sR = new StreamReader(fileStream);
            char letter = Convert.ToChar(textBox1.Text);
            String str1 = String.Empty;
            
            while ((str1 = sR.ReadLine()) != null)
            {
                char[] ch = str1.ToCharArray();
                if (ch[0] == letter) textBox2.AppendText(str1 + Environment.NewLine);
            }
            if (textBox2.Text == "") textBox2.Text = "Ни одно предложение не начинается с данной буквы";
        }
        }
    }

