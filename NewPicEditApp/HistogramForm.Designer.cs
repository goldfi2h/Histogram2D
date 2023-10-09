namespace NewPicEditApp
{
    partial class HistogramForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cValue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GridViewValues = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewValues)).BeginInit();
            this.SuspendLayout();
            // 
            // cValue
            // 
            chartArea1.Name = "ChartArea1";
            this.cValue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cValue.Legends.Add(legend1);
            this.cValue.Location = new System.Drawing.Point(12, 12);
            this.cValue.Name = "cValue";
            this.cValue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DimGray;
            series1.Legend = "Legend1";
            series1.Name = "Value";
            this.cValue.Series.Add(series1);
            this.cValue.Size = new System.Drawing.Size(240, 258);
            this.cValue.TabIndex = 23;
            this.cValue.Text = "Value";
            // 
            // GridViewValues
            // 
            this.GridViewValues.AllowUserToAddRows = false;
            this.GridViewValues.AllowUserToDeleteRows = false;
            this.GridViewValues.AllowUserToResizeColumns = false;
            this.GridViewValues.AllowUserToResizeRows = false;
            this.GridViewValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridViewValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.GridViewValues.Location = new System.Drawing.Point(12, 288);
            this.GridViewValues.Name = "GridViewValues";
            this.GridViewValues.ReadOnly = true;
            this.GridViewValues.Size = new System.Drawing.Size(240, 150);
            this.GridViewValues.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "no.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 47;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Values";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 64;
            // 
            // HistogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(272, 593);
            this.Controls.Add(this.cValue);
            this.Controls.Add(this.GridViewValues);
            this.Name = "HistogramForm";
            this.Text = "HistogramForm";
            this.Load += new System.EventHandler(this.HistogramForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart cValue;
        private System.Windows.Forms.DataGridView GridViewValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}