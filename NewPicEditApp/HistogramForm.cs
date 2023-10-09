using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPicEditApp
{
    public partial class HistogramForm : Form
    {
        int[] GHist = new int[256];
        bool is_greyscale;
        Bitmap bitmap;
        public HistogramForm(Bitmap bitmap)
        {

            InitializeComponent();

            this.bitmap = bitmap;
            for (int x = 0; x < this.bitmap.Width; ++x)
            {
                for (int y = 0; y < this.bitmap.Height; ++y)
                {
                    Color pixelColor = this.bitmap.GetPixel(x, y);
                    GHist[pixelColor.R] += 1;
                }
            }
        }

        private void HistogramForm_Load(object sender, EventArgs e)
        {
            //if (is_greyscale)//jest czarno-bialy
            //{
            cValue.Series[0].Points.DataBindY(GHist);  

            for(int i=0; i<GHist.Length; ++i)
            {
                GridViewValues.Rows.Add(i, GHist[i]);
            }
            //    cValue.Series[0].Points.DataBindY(RhistogramArray);

            //    for (int i = 0; i < AhistogramArray.Length; i++)
            //    {
            //        GridViewValues.Rows.Add(i, RhistogramArray[i]);
            //    }

            }
            //else //jest kolorowy
            //{
            //    //chRED.Visible = true;
            //    //chGREEN.Visible = true;
            //    //chBLUE.Visible = true;
            //    for (int i = 0; i < AhistogramArray.Length; i++)
            //    {
            //        //GridViewRED.Rows.Add(i, RhistogramArray[i]);
            //        //GridViewGREEN.Rows.Add(i, GhistogramArray[i]);
            //        //GridViewBLUE.Rows.Add(i, BhistogramArray[i]);
            //    }


                //chRED.Series[0].Points.DataBindY(RhistogramArray);
                //chGREEN.Series[0].Points.DataBindY(GhistogramArray);
                //chBLUE.Series[0].Points.DataBindY(BhistogramArray);
                //chA.Series[0].Points.DataBindY(AhistogramArray);
            }


        }
