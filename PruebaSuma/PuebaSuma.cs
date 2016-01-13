using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSuma
{
    public partial class PuebaSuma : Form
    {
        public PuebaSuma()
        {
            InitializeComponent();
        }
        public int num1;
        public int num2;
        public double res;
        private void Sumabutton_Click(object sender, EventArgs e)
        {
            num1 = (int)Convert.ToInt32(PrimertextBox.Text);
            num2 = (int)Convert.ToInt32(SegundotextBox.Text);
            res = (num1 + num2);
            ResultadotextBox.Text = res.ToString();
            
        }
    }
}
