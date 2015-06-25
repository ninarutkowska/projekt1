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
        int k = 0;
        int i = 0;
        int j = 0;
        int[,] p = new int[3,4];
        int para = 0;
        int got = 0;
        System.Drawing.Color[,] kol = new System.Drawing.Color[3, 4];
        Random rand = new Random();
        System.Drawing.Color[,] kontrol = new System.Drawing.Color[3, 4];

        private void b11_Click(object sender, EventArgs e)
        {
            if (t > 0 &&got==0)
            {
                
                if (b11.BackColor == System.Drawing.Color.FromName("Control"))
                {
                    k++;
                    b11.BackColor = kol[0, 0];
                    if (k == 2)
                    {
                        for (i = 0; i < 3; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {

                                if (p[i, j] == 1  && kol[i, j] == kol[0, 0])
                                {
                                    para++;
                                    kontrol[0, 0] = Color.Black;
                                    kontrol[i, j] = Color.Black;
                                }
                            }
                        }
                        got = 1;
                        
                    }
                    b11.BackColor = kol[0, 0];
                    p[0, 0] = 1 ;
                }
            }
        }
        private void b12_Click(object sender, EventArgs e)
        {
            if (t > 0 &&got==0)
            {
                
                if (b12.BackColor == System.Drawing.Color.FromName("Control"))
                {
                    b12.BackColor = kol[0, 1];
                    k++;
                    if (k == 2)
                    {
                        for (i = 0; i < 3; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {
                                if (p[i, j] == 1  && kol[i, j] == kol[0, 1])
                                {
                                    para++;
                                    kontrol[0, 1] = Color.Black;
                                    kontrol[i, j] = Color.Black;
                                    
                                }
                                
                            }
                        }
                        got = 1;
                    }

                    p[0, 1] = 1 ;
                }
            }
        }
        private void b13_Click(object sender, EventArgs e)
        {
            if (t > 0 &&got==0)
            {
                
                if (b13.BackColor == System.Drawing.Color.FromName("Control"))
                {
                    b13.BackColor = kol[0, 2];
                    k++;
                    if (k == 2)
                    {
                        for (i = 0; i < 3; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {
                                if (p[i, j] == 1  && kol[i, j] == kol[0, 2])
                                {
                                    para++;
                                    kontrol[0, 2] = Color.Black;
                                    kontrol[i, j] = Color.Black;
                                    
                                }
                            }
                        }
                        got = 1;
                    }
                    p[0, 2] = 1;
                }
            }
        }
        private void b14_Click(object sender, EventArgs e)
        {
            if (t > 0 &&got==0)
            {
                
                if (b14.BackColor == System.Drawing.Color.FromName("Control"))
                {
                    b14.BackColor = kol[0, 3];
                    k++;
                    if (k == 2)
                    {
                        for (i = 0; i < 3; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {
                                if (p[i, j] == 1  && kol[i, j] == kol[0, 3])
                                {
                                    para++;
                                    kontrol[0, 3] = Color.Black;
                                    kontrol[i, j] = Color.Black;
                                    
                                }
                            }
                        }
                        got = 1;
                    }
                    b14.BackColor = kol[0, 3];
                    p[0, 3] = 1;
                }
            }
        }
        private void b21_Click(object sender, EventArgs e)
        {
            if (t > 0 &&got==0)
            {
                
                if (b21.BackColor == System.Drawing.Color.FromName("Control"))
                {
                    k++;
                    b21.BackColor = kol[1, 0];
                    if (k == 2)
                    {
                        for (i = 0; i < 3; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {
                                if (p[i, j] == 1 &&  kol[i, j] == kol[1, 0])
                                {
                                    para++;
                                    kontrol[1, 0] = Color.Black;
                                    kontrol[i, j] = Color.Black;
                                    
                                }
                            }
                        }
                        got = 1;
                    }
                    
                    p[1,0] = 1;
                }
            }
        }
        private void b22_Click(object sender, EventArgs e)
        {
            if (t > 0 &&got==0)
            {
                
                if (b22.BackColor == System.Drawing.Color.FromName("Control"))
                {
                    k++;
                    b22.BackColor = kol[1, 1];
                    if (k == 2)
                    {
                        for (i = 0; i < 3; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {
                                if (p[i, j] == 1 && kol[i, j] == kol[1, 1])
                                {
                                    para++;;
                                    kontrol[1, 1] = Color.Black;
                                    kontrol[i, j] = Color.Black;
                                    
                                }
                            }
                        }
                        got = 1;
                    }
                    
                    p[1,1] = 1;
                }
            }
        }
        private void b23_Click(object sender, EventArgs e)
        {
            if (t > 0 &&got==0)
            {
                
                if (b23.BackColor == System.Drawing.Color.FromName("Control"))
                {
                    b23.BackColor = kol[1, 2];
                    k++;
                    if (k == 2)
                    {
                        for (i = 0; i < 3; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {
                                if (p[i, j] == 1  && kol[i, j] == kol[1, 2])
                                {
                                    para++;
                                    kontrol[1, 2] = Color.Black;
                                    kontrol[i, j] = Color.Black;
                                    
                                }
                            }
                        }
                        got = 1;
                    }
                    p[1, 2] = 1;
                }
            }
        }
        private void b24_Click(object sender, EventArgs e)
        {
            if (t > 0 &&got==0)
            {
                
                if (b24.BackColor == System.Drawing.Color.FromName("Control"))
                {
                    b24.BackColor = kol[1, 3];
                    k++;
                    if (k == 2)
                    {
                        for (i = 0; i < 3; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {
                                if (p[i, j] == 1  && kol[i, j] == kol[1, 3])
                                {
                                    para++;
                                    kontrol[1, 3] = Color.Black;
                                    kontrol[i, j] = Color.Black;
                                    
                                }
                            }
                        }
                        got = 1;
                    }
                    p[1, 3] = 1;
                }
            }
        }
        private void b31_Click(object sender, EventArgs e)
        {
            if (t > 0 &&got==0)
            {
                
                if (b31.BackColor == System.Drawing.Color.FromName("Control"))
                {
                    b31.BackColor = kol[2, 0];
                    k++;
                    if (k == 2)
                    {
                        for (i = 0; i < 3; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {
                                if (p[i, j] == 1  && kol[i, j] == kol[2, 0])
                                {
                                    para++;
                                    kontrol[2, 0] = Color.Black;
                                    kontrol[i, j] = Color.Black;
                                    
                                }
                            }
                        }
                        got = 1;
                    }

                    p[2,0] = 1;
                }
            }
        }
        private void b32_Click(object sender, EventArgs e)
        {
            if (t > 0 &&got==0)
            {
                
                if (b32.BackColor == System.Drawing.Color.FromName("Control"))
                {
                    k++;
                    b32.BackColor = kol[2, 1];
                    if (k == 2)
                    {
                       for (i = 0; i < 3; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {
                                if (p[i, j] == 1 && kol[i, j] == kol[2, 1])
                                {
                                    para++;
                                    kontrol[2, 1] = Color.Black;
                                    kontrol[i, j] = Color.Black;
                                    
                                }
                            }
                        }
                       got = 1;
                    }
                    p[2,1] = 1;
                }
            }
        }
        private void b33_Click(object sender, EventArgs e)
        {
            if (t > 0 &&got==0)
                
            {
                if (b33.BackColor == System.Drawing.Color.FromName("Control"))
                {
                    k++;
                    b33.BackColor = kol[2, 2];
                    if (k == 2)
                    {
                        for (i = 0; i < 3; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {
                                if (p[i, j] == 1  && kol[i, j] == kol[2, 2])
                                {
                                    para++;
                                    kontrol[2, 2] = Color.Black;
                                    kontrol[i, j] = Color.Black;
                                    
                                }
                            }
                        }
                        got = 1;
                    }
                    
                    p[2,2] = 1;
                }
            }
        }
        private void b34_Click(object sender, EventArgs e)
        {
            if (t > 0 &&got==0)
                
            {
                if (b34.BackColor == System.Drawing.Color.FromName("Control"))
                {
                    k++;
                    b34.BackColor = kol[2, 3];
                    if (k == 2)
                    {
                        for (i = 0; i < 3; i++)
                        {
                            for (j = 0; j < 4; j++)
                            {
                                if (p[i, j] == 1  && kol[i, j] == kol[2, 3])
                                {
                                    para++;;
                                    kontrol[2, 3] = Color.Black;
                                    kontrol[i, j] = Color.Black;

                                }
                            }
                        }
                        got = 1;
                    }
                    p[2, 3] = 1;
                }
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    kontrol[i, j] = Color.FromName("control");
                }
            }
            b11.BackColor = kontrol[0, 0];
            b12.BackColor = kontrol[0, 1];
            b13.BackColor = kontrol[0, 2];
            b14.BackColor = kontrol[0, 3];
            b21.BackColor = kontrol[1, 0];
            b22.BackColor = kontrol[1, 1];
            b23.BackColor = kontrol[1, 2];
            b24.BackColor = kontrol[1, 3];
            b31.BackColor = kontrol[2, 0];
            b32.BackColor = kontrol[2, 1];
            b33.BackColor = kontrol[2, 2];
            b34.BackColor = kontrol[2, 3];
            int[] k = new int[6];
            int s = 0;
            for(i=0;i<6;i++) k[i] = 0;
            for (i = 0; i < 3;i++)
            {
                for(j=0;j<4;j++)
                {
                    p[i, j] = 0;
                    s = rand.Next(0, 6);
                    while(k[s] >=2) s=rand.Next(0,6);
                    k[s] = k[s] + 1;
                    if (s == 0) kol[i, j] = Color.Red;
                    if (s == 1) kol[i, j] = Color.Yellow;
                    if (s == 2) kol[i, j] = Color.Indigo;
                    if (s == 3) kol[i, j] = Color.Lime;
                    if (s == 4) kol[i, j] = Color.Cyan;
                    if (s == 5) kol[i, j] = Color.SkyBlue;
                };
            };
            label2.Text = "";
            para = 0;
            t = 0;
            timer1.Start();
            label1.Text = "0";
        }

        int t = 0;
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (k == 2&&got==1)
            {
                t = t + 1;
                label1.Text = t.ToString();
                t = t + 1;
                label1.Text = t.ToString();
                b11.BackColor = kontrol[0, 0];
                b12.BackColor = kontrol[0, 1];
                b13.BackColor = kontrol[0, 2];
                b14.BackColor = kontrol[0, 3];
                b21.BackColor = kontrol[1, 0];
                b22.BackColor = kontrol[1, 1];
                b23.BackColor = kontrol[1, 2];
                b24.BackColor = kontrol[1, 3];
                b31.BackColor = kontrol[2, 0];
                b32.BackColor = kontrol[2, 1];
                b33.BackColor = kontrol[2, 2];
                b34.BackColor = kontrol[2, 3];
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        p[i, j] = 0;
                    };
                };

                k = 0;
                t = t + 1;
                label1.Text = t.ToString();
                got = 0;
            }
            if(k<2)
            {
                t = t + 1;
                label1.Text = t.ToString();
            };
            if (para == 6)
            {
                timer1.Stop();
                label2.Text = "WYGRANA! Czas: " + t + "s";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
