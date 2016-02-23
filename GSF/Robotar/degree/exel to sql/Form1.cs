using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exel_to_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbconn conn = new dbconn();
            string inFromTextbox = null;
            string[] input;
            string[] splitInput;
            string skipun = null;

            inFromTextbox = richTextBox1.Text;
            input = inFromTextbox.Split('\n');

            for (int i = 0; i < input.Length; i++)
            {
                splitInput = input[i].Split(' ');

                try
                {
                    skipun = ("INSERT INTO cource(nr, name, school_id, semester, units) VALUES ('" + splitInput[0] + "','" + splitInput[1] + "','" + splitInput[3] + "','2016H','" + splitInput[2] + "');");
                    conn.insert(skipun);
                }
                catch (Exception)
                {
                    
                    MessageBox.Show(skipun);
                }
            }
            richTextBox1.Text = null;
        }
    }
}
