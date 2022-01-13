using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koch_8AA1_A
{
    class draw
    {
        /// <summary>
        /// draw circle in color c around p with radius r on control ctrl
        /// </summary>
        internal static void circle(Point p, Color c, int r, Control ctrl)
        {
            Pen pen = new Pen(c);
            Graphics g = ctrl.CreateGraphics();
            g.DrawEllipse(pen, p.X - r, p.Y - r, 2 * r, 2 * r);
        }

        /// <summary>
        /// draw line between p0 and p1 in color c on control ctrl
        /// </summary>
        internal static void line(Point p0, Point p1, Color c, Control ctrl)
        {
            Pen pen = new Pen(c);
            Graphics g = ctrl.CreateGraphics();
            g.DrawLine(pen, p0, p1);
        }
    }

    class ButtonExtra : Button 
    {
        public List<char> L = new List<char>();
    } 
}
