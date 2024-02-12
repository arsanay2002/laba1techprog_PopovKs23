using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace laba1_PopovKs23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kot = 231;
            MessageBox.Show("Привет от котика");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open("C:\\Users\\Сеня\\Desktop\\учеба\\4 сем\\технологии программирования\\laba1_PopovKs23\\laba1_PopovKs23\\phonenumbers.txt", FileMode.Append))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(maskedTextBox1.Text);
                }
                
            }

        }

        public class Chtoto
        {
            long a = 561;
            const short b = 5;
            double[] c = new double[5];
            enum Days : byte
            {
                None = 0b_0000_0000,  // 0
                Monday = 0b_0000_0001,  // 1
                Tuesday = 0b_0000_0010,  // 2
                Wednesday = 0b_0000_0100,  // 4
                Thursday = 0b_0000_1000,  // 8
                Friday = 0b_0001_0000,  // 16
                Saturday = 0b_0010_0000,  // 32
                Sunday = 0b_0100_0000,  // 64
            }
        }
    }
}
