using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole2
{
    public partial class Form1 : Form
    {
        int[] poleA;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			Random random = new Random();
			listBox1.Items.Clear();
			try
			{
				int n = int.Parse(textBox1.Text);
				poleA = new int[n];
				double avr;
				double max = -1000;
				for (int i = 0; i < n; i++)
				{
					poleA[i] = random.Next(-1000, 1000);
					listBox1.Items.Add(poleA[i]);
				}
				avr = poleA.Average();
				labelavr.Text = "Prumer je: " + avr.ToString();
				foreach (double c in poleA)
				{
					if (c <= avr && c > max) { 
						max = c; 
					}
				}
				label.Text = "Max z prvku < || == je: " + max.ToString();
			}
			catch
			{
				MessageBox.Show("CHYBA!");
			}
		}
    }
}
