using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Led
{
    internal class Led_Test : Control
    {
        Color colore_led = Color.Red;
        int dime = 10;

        public Led_Test()
        {

        }

        public Led_Test(Color colore, int dimensione)
        {
            dime = dimensione;
            colore_led = colore;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Width = dime + 1; Height = dime + 1;
            Graphics g = pe.Graphics;
            System.Drawing.Brush brush = new SolidBrush(colore_led);
            Pen penna = new Pen(Color.Black, 1);
            g.FillEllipse(brush, 0, 0, dime, dime);
            g.DrawArc(penna, 0, 0, dime, dime, 0, 360);
            //MessageBox.Show("disegno");


        }

        public Color Colore
        {
            get
            {
                return colore_led;
            }
            set
            {
                colore_led = value;
                this.Invalidate();
            }
        }
        public int Dimensione
        {
            get
            {
                return dime;
            }
            set
            {
                dime = value;
                this.Invalidate();
            }
        }
    }
}