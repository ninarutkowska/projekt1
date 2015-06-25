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

    public partial class Form1 : Form
    {
        int t = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pary_Click(object sender, EventArgs e)
        {
            Form2 okno = new Form2();
            okno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Form3 okno = new Form3();
                okno.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = 1;
            timer2.Start();
            this.Cursor = new Cursor(Cursor.Current.Handle);
            int y = Cursor.Position.Y;
            int x = Cursor.Position.X;
            int y0;
            int x0;
            while (t <= 500)
            {
                if (Cursor.Position.X != x || Cursor.Position.Y != y)
                {
                    x0 = Cursor.Position.X - x;
                    y0 = Cursor.Position.Y - y;
                    if (Cursor.Position.X > 0 && Cursor.Position.X <800 && Cursor.Position.Y > 0 && Cursor.Position.Y < 600)
                    {
                        Cursor.Position = new Point(Cursor.Position.X - 2 * x0, Cursor.Position.Y - 2 * y0);
                    }
                    if (Cursor.Position.X <= 0 || Cursor.Position.Y <= 0)
                    {
                        if (x0 >= 0)
                        {
                            if (y0 >= 0) Cursor.Position = new Point(Cursor.Position.X + x0, Cursor.Position.Y + y0);
                            else Cursor.Position = new Point(Cursor.Position.X + x0, Cursor.Position.Y - 2 * y0);
                        }
                        else
                        {
                           if(y0<0) Cursor.Position = new Point(Cursor.Position.X - 2 * x0, Cursor.Position.Y - 2 * y0);
                           else Cursor.Position = new Point(Cursor.Position.X - 2*x0, Cursor.Position.Y + y0);
                        }
                    }
                    if (Cursor.Position.X >= 800 || Cursor.Position.Y >= 600)
                    {
                        if (x0 >= 0)
                        {
                            if (y0 >= 0) Cursor.Position = new Point(Cursor.Position.X - 2 * x0, Cursor.Position.Y - 2 * y0);
                            else Cursor.Position = new Point(Cursor.Position.X - 2 * x0, Cursor.Position.Y + y0);
                        }
                        else
                        {
                            if(y0<0) Cursor.Position = new Point(Cursor.Position.X + x0, Cursor.Position.Y + y0);
                            else Cursor.Position = new Point(Cursor.Position.X + x0, Cursor.Position.Y - 2*y0);
                        }
                    }
                    x = Cursor.Position.X;
                    y = Cursor.Position.Y;
                    t++;
                }
            };
           if (t == 501) Application.Exit();
        }
    }
}
