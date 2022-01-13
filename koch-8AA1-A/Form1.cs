using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koch_8AA1_A
{
    /// <summary>
    /// from (s,f) to (A,O) and vice versa
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n = 0;
        Point p0, p1, p2;
        int A = 0, O = 0, S = 0;

        /// <summary>
        /// usable for sudoku
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            ButtonExtra b = new ButtonExtra();
            for (char c = '1'; c <= '9'; c++)
            {
                b.L.Add(c);
            }

        }

        double f = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            p0 = new Point(50, 200);
            p1 = new Point(200, 100);
            A = p1.X - p0.X;
            O = p1.Y - p0.Y;
            S = (int)Math.Sqrt(A * A + O * O);
            f = Math.Atan2(O, A);
            draw.circle(p0, Color.Blue, 5, this);
            draw.circle(p1, Color.Blue, 5, this);
            timer1.Start();
        }

        /// <summary>
        /// going in ten steps from isosceles triangle
        /// to equilateral triangle
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n < 10)
            {
                n++;
                //f -= Math.PI / 30;                  //anti clockwise 
                f += Math.PI / 30;                  //clockwise  
                int nA = (int)(S * Math.Cos(f));
                int nO = (int)(S * Math.Sin(f));
                p2 = new Point(p0.X + nA, p0.Y + nO);
                draw.circle(p2, Color.Red, 5, this);
            }
            else
            {
                draw.line(p0, p1, Color.Green, this);
                draw.line(p1, p2, Color.Green, this);
                draw.line(p2, p0, Color.Green, this);
                timer1.Stop();
            }
        }
    }
}
