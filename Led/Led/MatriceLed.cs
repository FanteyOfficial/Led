using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Per aggiungere lo "scheletro" di una nuova proprietà:
//  Tasto destro mouse
//      - Selezionare "Frammento"
//        - Selezionare "Inserisci frammento"
//          - Selezionare "Visual C#"
//              - Selezionare Prop

namespace Led
{
    internal class MatriceLed : Control
    {
        int matrixWidth = 5;
        int matrixHeight = 5;
        int ledDim = 30;
        Led_Test[,] matrix_led;

        protected override void OnPaint(PaintEventArgs pe)
        {
            Width = matrixWidth * ledDim;
            Height = matrixHeight * ledDim;
            matrix_led = new Led_Test[matrixWidth, matrixHeight];
            for (int i = 0; i < matrix_led.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_led.GetLength(1); j++)
                {
                    matrix_led[i, j] = new Led_Test();
                    matrix_led[i, j].Colore = Color.White;
                    matrix_led[i, j].Dimensione = ledDim; // modifica dimensine led
                    matrix_led[i, j].Size = new Size(matrix_led[i, j].Dimensione, matrix_led[i, j].Dimensione);
                    matrix_led[i, j].Location = new Point(matrix_led[i, j].Dimensione * j, matrix_led[i, j].Dimensione * i);
                    this.Controls.Add(matrix_led[i, j]);
                }
            }
        }

        public int MatrixWidth { 
            get
            {
                return matrixWidth;
            } 
            set
            {
                matrixWidth = value;
                Invalidate();
            } 
        }

        public int MatrixHeight
        {
            get
            {
                return matrixHeight;
            }
            set
            {
                matrixHeight = value;
                Invalidate();
            }
        }
    }
}
