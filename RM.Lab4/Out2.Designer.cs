namespace RM.Lab4
{
    partial class Out2
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
            this.lossesResDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lossesResDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lossesResDataGrid
            // 
            this.lossesResDataGrid.AllowUserToAddRows = false;
            this.lossesResDataGrid.AllowUserToDeleteRows = false;
            this.lossesResDataGrid.AllowUserToResizeColumns = false;
            this.lossesResDataGrid.AllowUserToResizeRows = false;
            this.lossesResDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lossesResDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lossesResDataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.lossesResDataGrid.Location = new System.Drawing.Point(12, 12);
            this.lossesResDataGrid.Name = "lossesResDataGrid";
            this.lossesResDataGrid.ReadOnly = true;
            this.lossesResDataGrid.RowTemplate.Height = 25;
            this.lossesResDataGrid.Size = new System.Drawing.Size(1886, 1137);
            this.lossesResDataGrid.TabIndex = 1;
            // 
            // Out2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1907, 1161);
            this.Controls.Add(this.lossesResDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Out2";
            this.Text = "Визначення частки можливих збитків від прояву ризику";
            this.Load += new System.EventHandler(this.Out2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lossesResDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView lossesResDataGrid;
    }
}