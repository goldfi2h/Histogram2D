namespace NewPicEditApp
{
    partial class Histogram2DForm
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
            this.DGHist2D = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lStary = new System.Windows.Forms.Label();
            this.lKrawedziowanie = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGHist2D)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGHist2D
            // 
            this.DGHist2D.AllowUserToAddRows = false;
            this.DGHist2D.AllowUserToDeleteRows = false;
            this.DGHist2D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGHist2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGHist2D.Location = new System.Drawing.Point(20, 20);
            this.DGHist2D.Name = "DGHist2D";
            this.DGHist2D.ReadOnly = true;
            this.DGHist2D.RowHeadersWidth = 60;
            this.DGHist2D.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGHist2D.Size = new System.Drawing.Size(771, 425);
            this.DGHist2D.TabIndex = 0;
            this.DGHist2D.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGHist2D_CellFormatting);
            this.DGHist2D.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGHist2D_CellMouseClick);
            this.DGHist2D.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DGHist2D_ColumnAdded);
            this.DGHist2D.SelectionChanged += new System.EventHandler(this.DGHist2D_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResult);
            this.panel1.Controls.Add(this.lKrawedziowanie);
            this.panel1.Controls.Add(this.lStary);
            this.panel1.Controls.Add(this.DGHist2D);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 20, 5, 5);
            this.panel1.Size = new System.Drawing.Size(796, 450);
            this.panel1.TabIndex = 1;
            // 
            // lStary
            // 
            this.lStary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lStary.AutoSize = true;
            this.lStary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lStary.Location = new System.Drawing.Point(259, 4);
            this.lStary.Name = "lStary";
            this.lStary.Size = new System.Drawing.Size(252, 13);
            this.lStary.TabIndex = 1;
            this.lStary.Text = "W a r t o ś c i   z   p o c z ą t k o w e g o   o b r a z u";
            // 
            // lKrawedziowanie
            // 
            this.lKrawedziowanie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lKrawedziowanie.AutoSize = true;
            this.lKrawedziowanie.Font = new System.Drawing.Font("Wide Latin", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)), true);
            this.lKrawedziowanie.Location = new System.Drawing.Point(-3, 47);
            this.lKrawedziowanie.Name = "lKrawedziowanie";
            this.lKrawedziowanie.Size = new System.Drawing.Size(17, 364);
            this.lKrawedziowanie.TabIndex = 2;
            this.lKrawedziowanie.Text = "W\r\na\r\nr\r\nt\r\no\r\ns\r\nc\r\ni\r\n\r\np\r\no\r\n\r\nk\r\nr\r\na\r\nw\r\ne\r\nd\r\nz\r\ni\r\no\r\nw\r\na\r\nn\r\ni\r\nu";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(20, 20);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(65, 24);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Histogram2DForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Histogram2DForm";
            this.Text = "Histogram2DForm";
            this.Load += new System.EventHandler(this.Histogram2DForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGHist2D)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGHist2D;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lKrawedziowanie;
        private System.Windows.Forms.Label lStary;
        private System.Windows.Forms.Button btnResult;
    }
}