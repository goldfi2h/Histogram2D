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
    public partial class Histogram2DForm : Form
    {
        Bitmap original;
        Bitmap edges;
        int[,] matrix = new int[256,256];
        List<int> rowIndexes = new List<int>();
        List<int> columnIndexes = new List<int>();

        public Histogram2DForm(Bitmap original, Bitmap edges)
        {
            rowIndexes.Clear();
            columnIndexes.Clear();
            InitializeComponent();
            setRowNumber(DGHist2D);
            this.original = original;
            this.edges = edges;


            for(int i = 0; i < original.Height; i++)
            {
                for(int j=0; j < original.Width; j++)
                {
                    Color originalColor = original.GetPixel(i,j);
                    Color edgesColor = edges.GetPixel(i,j);
                    matrix[edgesColor.R, originalColor.R] += 1;
                }
            }
            DataTable dt = new DataTable();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                dt.Columns.Add(j.ToString());
            }
            

            DataRow dr;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                dr = dt.NewRow();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        dr[j] = null;

                    }
                    else dr[j] = matrix[i, j];
                }
                dt.Rows.Add(dr);
            }
            DGHist2D.DataSource = dt;
            

            rowIndexes.Clear();
            columnIndexes.Clear();
        }

        private void DGHist2D_SelectionChanged(object sender, EventArgs e)
        {
            //ResultForm rform = new ResultForm();
            //rform.Show();
            try
            {
                rowIndexes.Add(DGHist2D.CurrentCell.RowIndex);


                columnIndexes.Add(DGHist2D.CurrentCell.ColumnIndex);
                columnIndexes.Sort();
                columnIndexes = columnIndexes.Distinct().ToList();
            }
            catch (NullReferenceException) 
            {

            }
        }

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = row.Index + 1;
            }

            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

        }

        private void DGHist2D_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int r = (int)e.RowIndex;
            (sender as DataGridView).Rows[r].HeaderCell.Value = (r++).ToString();

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            //int[] a = new int[DGHist2D.SelectedColumns.Count];
            //int k = 0;
            //DGHist2D.SelectedColumns.CopyTo(a, k++);
            rowIndexes.Sort();
            rowIndexes = rowIndexes.Distinct().ToList();


            ResultForm form = new ResultForm(rowIndexes, columnIndexes, original,edges,matrix);
            form.Show();

            rowIndexes.Clear();
            columnIndexes.Clear();

            

            //foreach(var column in DGHist2D.SelectedColumns)
            //{
            //    a[k++] = column;
            //}
        }

        private void Histogram2DForm_Load(object sender, EventArgs e)
        {
            rowIndexes.Clear();
            columnIndexes.Clear();
        }

        private void DGHist2D_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndexes.Clear();
            columnIndexes.Clear();
        }


        private void DGHist2D_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}
