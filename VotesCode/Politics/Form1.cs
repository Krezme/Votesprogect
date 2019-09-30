using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Politics
{
    public partial class Form1 : Form
    {
        int a;
        int b;
        int c;
        int d;
        int boxSummaryA;
        int boxSummaryB;
        int boxSummaryC;
        int boxSummaryD;
        int biastResults;
        int[] resultSort = new int[4];
        int canAPlacement;
        int canBPlacement;
        int canCPlacement;
        int canDPlacement;

        string canNameA = "can1";
        string canNameB = "can2";
        string canNameC = "can3";
        string canNameD = "can4";

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            a = Convert.ToInt32(Math.Round(canNum1.Value, 0));
            b = Convert.ToInt32(Math.Round(canNum2.Value, 0));
            c = Convert.ToInt32(Math.Round(canNum3.Value, 0));
            d = Convert.ToInt32(Math.Round(canNum4.Value, 0));

            boxSummaryA = boxSummaryA + a;
            boxSummaryB = boxSummaryB + b;
            boxSummaryC = boxSummaryC + c;
            boxSummaryD = boxSummaryD + d;

            canNum1.TabIndex = 0;
            canNum2.TabIndex = 0;
            canNum3.TabIndex = 0;
            canNum4.TabIndex = 0;
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            if (boxSummaryA < boxSummaryD) {

                biastResults = boxSummaryA;
                boxSummaryA = boxSummaryD;
                boxSummaryD = biastResults;

            }

            resultSort[0] = boxSummaryA;
            resultSort[1] = boxSummaryB;
            resultSort[2] = boxSummaryC;
            resultSort[3] = boxSummaryD;

            Array.Sort(resultSort);
            Array.Reverse(resultSort);

            canAPlacement = Array.IndexOf(resultSort, boxSummaryA);
            canBPlacement = Array.IndexOf(resultSort, boxSummaryB);
            canCPlacement = Array.IndexOf(resultSort, boxSummaryC);
            canDPlacement = Array.IndexOf(resultSort, boxSummaryD);

            for (int i = 0; i < resultSort.Length; i++)
            {

                if (i == canAPlacement)
                {

                    if (i == 0)
                    {
                        resultTXT1.Text = (canNameA + " - " + resultSort[i]);
                    }
                    else if (i == 1)
                    {
                        resultTXT2.Text = (canNameA + " - " + resultSort[i]);
                    }
                    else if (i == 2)
                    {
                        resultTXT3.Text = (canNameA + " - " + resultSort[i]);
                    }
                    else if (i == 3)
                    {
                        resultTXT4.Text = (canNameA + " - " + resultSort[i]);
                    }

                }
                else if (i == canBPlacement)
                {

                    if (i == 0)
                    {
                        resultTXT1.Text = (canNameB + " - " + resultSort[i]);
                    }
                    else if (i == 1)
                    {
                        resultTXT2.Text = (canNameB + " - " + resultSort[i]);
                    }
                    else if (i == 2)
                    {
                        resultTXT3.Text = (canNameB + " - " + resultSort[i]);
                    }
                    else if (i == 3)
                    {
                        resultTXT4.Text = (canNameB + " - " + resultSort[i]);
                    }

                }
                else if (i == canCPlacement)
                {

                    if (i == 0)
                    {
                        resultTXT1.Text = (canNameC + " - " + resultSort[i]);
                    }
                    else if (i == 1)
                    {
                        resultTXT2.Text = (canNameC + " - " + resultSort[i]);
                    }
                    else if (i == 2)
                    {
                        resultTXT3.Text = (canNameC + " - " + resultSort[i]);
                    }
                    else if (i == 3)
                    {
                        resultTXT4.Text = (canNameC + " - " + resultSort[i]);
                    }

                }
                else if (i == canDPlacement)
                {

                    if (i == 0)
                    {
                        resultTXT1.Text = (canNameD + " - " + resultSort[i]);
                    }
                    else if (i == 1)
                    {
                        resultTXT2.Text = (canNameD + " - " + resultSort[i]);
                    }
                    else if (i == 2)
                    {
                        resultTXT3.Text = (canNameD + " - " + resultSort[i]);
                    }
                    else if (i == 3)
                    {
                        resultTXT4.Text = (canNameD + " - " + resultSort[i]);
                    }


                }

            }
        }
    }
}
