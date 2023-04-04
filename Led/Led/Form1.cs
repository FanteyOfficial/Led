using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Led
{
    public partial class Form1 : Form
    {
        Led_Test[,] matrix_led =
        {
            { new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test() },
            { new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test() },
            { new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test() },
            { new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test()},
            { new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test() },
            { new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test() },
            { new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test(), new Led_Test() },
        };

        int[,] zero_number =
        {
            { 0, 1, 1, 1, 0 },
            { 1, 0, 0, 0, 1 },
            { 1, 0, 0, 1, 1 },
            { 1, 0, 1, 0, 1 },
            { 1, 1, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 0, 1, 1, 1, 0 },
        };
        int[,] one_number =
        {
            { 0, 1, 1, 0, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 1, 1, 1, 0 },
        };
        int[,] two_number =
        {
            { 0, 1, 1, 1, 0 },
            { 1, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 1 },
            { 0, 0, 0, 1, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 1, 0, 0, 0 },
            { 1, 1, 1, 1, 1 },
        };
        int[,] three_number =
        {
            { 0, 1, 1, 1, 0 },
            { 1, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 1 },
            { 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 0, 1, 1, 1, 0 },
        };
        int[,] four_number =
        {
            { 0, 0, 0, 1, 0 },
            { 0, 0, 1, 1, 0 },
            { 0, 1, 0, 1, 0 },
            { 1, 0, 0, 1, 0 },
            { 1, 1, 1, 1, 1 },
            { 0, 0, 0, 1, 0 },
            { 0, 0, 0, 1, 0 },
        };
        int[,] five_number =
        {
            { 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 0 },
            { 1, 1, 1, 1, 0 },
            { 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 0, 1, 1, 1, 0 },
        };
        int[,] six_number =
        {
            { 0, 1, 1, 1, 0 },
            { 1, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0 },
            { 1, 1, 1, 1, 0 },
            { 1, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 0, 1, 1, 1, 0 },
        };
        int[,] seven_number =
        {
            { 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 1 },
            { 0, 0, 0, 1, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 1, 0, 0 },
        };
        int[,] eight_number =
        {
            { 0, 1, 1, 1, 0 },
            { 1, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 0, 1, 1, 1, 0 },
            { 1, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 0, 1, 1, 1, 0 },
        };
        int[,] nine_number =
        {
            { 0, 1, 1, 1, 0 },
            { 1, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 0, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 0, 1, 1, 1, 0 },
        };

        Button[] matrixButton = new Button[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NumbersBox.FlowDirection = FlowDirection.LeftToRight;
            NumbersBox.WrapContents = false;
            //NumbersBox.AutoSize = true;

            for (int i = 0; i < matrix_led.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_led.GetLength(1); j++)
                {
                    matrix_led[i, j].Colore = Color.White;
                    matrix_led[i, j].Dimensione = 30; // modifica dimensine led
                    matrix_led[i, j].Size = new Size(matrix_led[i, j].Dimensione, matrix_led[i, j].Dimensione);
                    matrix_led[i, j].Location = new Point(matrix_led[i, j].Dimensione * j, matrix_led[i, j].Dimensione * i);
                    MatrixLed.Controls.Add(matrix_led[i, j]);
                }
            }

            for (int i = 0; i < matrixButton.Length; i++)
            {
                matrixButton[i] = new Button();
                matrixButton[i].Tag = i.ToString();
                matrixButton[i].Click += Num_Clicked;
                matrixButton[i].Text = i.ToString();
                matrixButton[i].Font = new Font(matrixButton[i].Font.FontFamily, 14);
                matrixButton[i].Size = new Size(50, 50);
                matrixButton[i].Location = new Point(50 * i);
                NumbersBox.Controls.Add(matrixButton[i]);
            }
        }

        private void resetMatrixLed()
        {
            matriceLed1.MatrixWidth = 5;
            matriceLed1.MatrixHeight = 9;
            

            for (int i = 0; i < matrix_led.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_led.GetLength(1); j++)
                {
                    matrix_led[i, j].Colore = Color.White;
                }
            }
        }

        private void Num_Clicked(object sender, EventArgs e)
        {
            resetMatrixLed();
            switch (Convert.ToInt32(((Button)sender).Tag))
            {
                case 0:
                    dispZero();
                    break;
                case 1:
                    dispOne();
                    break;
                case 2:
                    dispTwo();
                    break;
                case 3:
                    dispThree();
                    break;
                case 4:
                    dispFour();
                    break;
                case 5:
                    dispFive();
                    break;
                case 6:
                    dispSix();
                    break;
                case 7:
                    dispSeven();
                    break;
                case 8:
                    dispEight();
                    break;
                case 9:
                    dispNine();
                    break;
            }
        }

        private void dispZero()
        {
            for (int i = 0; i < matrix_led.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_led.GetLength(1); j++)
                {
                    if (zero_number[i, j] == 1)
                    {
                        matrix_led[i, j].Colore = Color.Red;
                    }
                }
            }
        }
        private void dispOne()
        {
            for (int i = 0; i < matrix_led.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_led.GetLength(1); j++)
                {
                    if (one_number[i, j] == 1)
                    {
                        matrix_led[i, j].Colore = Color.Red;
                    }
                }
            }
        }
        private void dispTwo()
        {
            for (int i = 0; i < matrix_led.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_led.GetLength(1); j++)
                {
                    if (two_number[i, j] == 1)
                    {
                        matrix_led[i, j].Colore = Color.Red;
                    }
                }
            }
        }
        private void dispThree()
        {
            for (int i = 0; i < matrix_led.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_led.GetLength(1); j++)
                {
                    if (three_number[i, j] == 1)
                    {
                        matrix_led[i, j].Colore = Color.Red;
                    }
                }
            }
        }
        private void dispFour()
        {
            for (int i = 0; i < matrix_led.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_led.GetLength(1); j++)
                {
                    if (four_number[i, j] == 1)
                    {
                        matrix_led[i, j].Colore = Color.Red;
                    }
                }
            }
        }
        private void dispFive()
        {
            for (int i = 0; i < matrix_led.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_led.GetLength(1); j++)
                {
                    if (five_number[i, j] == 1)
                    {
                        matrix_led[i, j].Colore = Color.Red;
                    }
                }
            }
        }
        private void dispSix()
        {
            for (int i = 0; i < matrix_led.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_led.GetLength(1); j++)
                {
                    if (six_number[i, j] == 1)
                    {
                        matrix_led[i, j].Colore = Color.Red;
                    }
                }
            }
        }
        private void dispSeven()
        {
            for (int i = 0; i < matrix_led.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_led.GetLength(1); j++)
                {
                    if (seven_number[i, j] == 1)
                    {
                        matrix_led[i, j].Colore = Color.Red;
                    }
                }
            }
        }
        private void dispEight()
        {
            for (int i = 0; i < matrix_led.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_led.GetLength(1); j++)
                {
                    if (eight_number[i, j] == 1)
                    {
                        matrix_led[i, j].Colore = Color.Red;
                    }
                }
            }
        }
        private void dispNine()
        {
            for (int i = 0; i < matrix_led.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_led.GetLength(1); j++)
                {
                    if (nine_number[i, j] == 1)
                    {
                        matrix_led[i, j].Colore = Color.Red;
                    }
                }
            }
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            resetMatrixLed();
        }
    }
}
