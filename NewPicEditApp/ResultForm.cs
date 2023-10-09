using System;
using System.Collections;
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
    public partial class ResultForm : Form
    {
        //int selectLenght;
        //int[] a;
        Bitmap newPicbox;
        Color White = Color.White;
        Color Black = Color.Black;
        public ResultForm(List<int> rowList, List<int> colList, Bitmap Picbox,Bitmap edges, int[,] Hist2DValues)
        {
            InitializeComponent();
 
            newPicbox = new Bitmap(Picbox.Width, Picbox.Height);
            StringBuilder sb = new StringBuilder();
 
            foreach (int i in rowList)
            {
                sb.AppendLine(i.ToString());
            }

            int rowIMin = rowList.Min();
            int rowIMax = rowList.Max();

            int colIMin = colList.Min();
            int colIMax = colList.Max();

            for(int i = 0; i < newPicbox.Width; i++)
            {
                for(int j = 0; j < newPicbox.Height; j++)
                {
                    int pix = (int)(Picbox.GetPixel(i, j).R);
                    int edge = (int)(edges.GetPixel(i, j).R);
                    if ((edge>=rowIMin&&edge<=rowIMax)&&(pix>=colIMin&&pix<=colIMax))
                    {
                        if(Hist2DValues[edge,pix]!=0) newPicbox.SetPixel(i, j, Black);
                        else newPicbox.SetPixel(i, j, White);

                    }
                    else newPicbox.SetPixel(i, j, White);
                }
            }
            PICBOX.Image = newPicbox;
            //tbResult.Text = sb.ToString();

        }
    }
}
