using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int k=0;
        private void b11_Click(object sender, EventArgs e)
        {
            if (b11.BackColor == System.Drawing.Color.FromName("Control"))
            {
                k++;
                b11.BackColor = System.Drawing.Color.DarkBlue;
                if (k == 2)
                {
                    b11.BackColor = System.Drawing.Color.FromName("control");
                    k = 0;
                }
            }
        }
        private void b12_Click(object sender, EventArgs e)
        {
            if (b12.BackColor == System.Drawing.Color.FromName("Control"))
            {
                k++;
                b12.BackColor = System.Drawing.Color.DarkBlue;
                if (k == 2)//timer
                {
                    b12.BackColor = System.Drawing.Color.FromName("control");
                    k = 0;
                }
            }
        }

    }
}
