using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    public partial class PicForm : Form
    {
        OpenFileDialog dialog = new OpenFileDialog();
        internal bool is_grayscale;
        internal Bitmap picboxCopyMap;
        internal Bitmap picboxCopyMapEdges;
        internal Bitmap picboxCopyMapOut;
        Image<Gray, byte> ImgOriginal,ImgEdges,ImgResult;
        public PicForm() 
        { 
            InitializeComponent();
            ButtonController();
        }
        private void PicForm_Load(object sender, EventArgs e) { }
        private void bOpen_Click(object sender, EventArgs e)
        {
                try
                {//próba otwarcia pliku z obrazem
                    dialog.Filter = "bmp files(*.bmp)|*.bmp| jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.**";
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.picboxCopyMap = new Bitmap(dialog.FileName);
                        this.picbox.Image = picboxCopyMap;
                        this.picbox2.Image = picboxCopyMap;
                        ImgOriginal = picboxCopyMap.ToImage<Gray, Byte>();
                        ImgEdges = picboxCopyMap.ToImage<Gray, Byte>();
                        ImgResult= picboxCopyMap.ToImage<Gray, Byte>();
                        ButtonController();
                }
                }

                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        private void ButtonController()
        {
            if (picbox.Image == null || picbox2.Image == null)
            {
                button2.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                btnSobel.Enabled = false;
                btnLaplasjan.Enabled = false;
                btnCanny.Enabled = false;

                picbox.Visible = false;
                picbox2.Visible = false;
            }
            else
            {
                button2.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                btnSobel.Enabled = true;
                btnLaplasjan.Enabled = true;
                btnCanny.Enabled = true;

                picbox.Visible = true;
                picbox2.Visible = true;
            }
        }
        private void btnLaplasjan_Click(object sender, EventArgs e)
        {
            int ksize = 3;
            CvInvoke.Laplacian(ImgEdges, ImgResult, DepthType.Default,ksize,1,0,BorderType.Default);
            picbox2.Image = ImgResult.ToBitmap();
        }

        private void btnCanny_Click(object sender, EventArgs e)
        {
            int treshhold1 = 100;
            int treshhold2 = 100;
            Image<Gray, byte> canny= picboxCopyMap.ToImage<Gray, Byte>();
            CvInvoke.Canny(canny, ImgResult, treshhold1, treshhold2, 3, false);

            picbox2.Image = ImgResult.ToBitmap();

        }

        private void button6_Click(object sender, EventArgs e)
        {


            
            HistogramForm histogram = new HistogramForm(picboxCopyMap);
            histogram.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap original = (Bitmap)picbox.Image;
            Bitmap edges = (Bitmap)picbox2.Image;
            Histogram2DForm Hist2D = new Histogram2DForm(original,edges);
            Hist2D.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HistogramForm histogram = new HistogramForm((Bitmap)picbox2.Image);
            histogram.Show();
        }

        private void btnSobel_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> sobelx, sobely,sobelResult;
            sobelx= picboxCopyMap.ToImage<Gray, Byte>();
            sobely = picboxCopyMap.ToImage<Gray, Byte>();
            sobelResult = picboxCopyMap.ToImage<Gray, Byte>();
            CvInvoke.Sobel(ImgEdges, sobelx, DepthType.Default, 1, 0, 3, 1, 0, BorderType.Default);

            CvInvoke.Sobel(ImgEdges, sobely, DepthType.Default, 1, 1, 5, 1, 0, BorderType.Default);
//            CvInvoke.HConcat(sobelx, sobely,sobelResult);

            picbox2.Image = sobely.ToBitmap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "bmp files(*.bmp)|*.bmp| jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.**";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                picboxCopyMap.Save(sf.FileName);
            }

        }
    }
}

