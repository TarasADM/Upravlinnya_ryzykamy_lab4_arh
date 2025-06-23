namespace RM.Lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.costDistributionDataGrid = new System.Windows.Forms.DataGridView();
            this.damageDataGrid = new System.Windows.Forms.DataGridView();
            this.probabilityDataGrid = new System.Windows.Forms.DataGridView();
            this.planDataGrid = new System.Windows.Forms.DataGridView();
            this.pozn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setVal3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.managDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setVal4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.costDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setVal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.techDataGrid = new System.Windows.Forms.DataGridView();
            this.poznachka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setVal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.val = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CalcCoef = new System.Windows.Forms.Button();
            this.CalcProb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.costDistributionDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // costDistributionDataGrid
            // 
            this.costDistributionDataGrid.AllowUserToAddRows = false;
            this.costDistributionDataGrid.AllowUserToDeleteRows = false;
            this.costDistributionDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.costDistributionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costDistributionDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.costDistributionDataGrid.Location = new System.Drawing.Point(12, 823);
            this.costDistributionDataGrid.Name = "costDistributionDataGrid";
            this.costDistributionDataGrid.RowTemplate.Height = 25;
            this.costDistributionDataGrid.Size = new System.Drawing.Size(859, 141);
            this.costDistributionDataGrid.TabIndex = 13;
            // 
            // damageDataGrid
            // 
            this.damageDataGrid.AllowUserToAddRows = false;
            this.damageDataGrid.AllowUserToDeleteRows = false;
            this.damageDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.damageDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.damageDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.damageDataGrid.Location = new System.Drawing.Point(894, 911);
            this.damageDataGrid.Name = "damageDataGrid";
            this.damageDataGrid.RowTemplate.Height = 25;
            this.damageDataGrid.Size = new System.Drawing.Size(863, 168);
            this.damageDataGrid.TabIndex = 12;
            // 
            // probabilityDataGrid
            // 
            this.probabilityDataGrid.AllowUserToAddRows = false;
            this.probabilityDataGrid.AllowUserToDeleteRows = false;
            this.probabilityDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.probabilityDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.probabilityDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.probabilityDataGrid.Location = new System.Drawing.Point(894, 677);
            this.probabilityDataGrid.Name = "probabilityDataGrid";
            this.probabilityDataGrid.ReadOnly = true;
            this.probabilityDataGrid.RowTemplate.Height = 25;
            this.probabilityDataGrid.Size = new System.Drawing.Size(863, 168);
            this.probabilityDataGrid.TabIndex = 11;
            // 
            // planDataGrid
            // 
            this.planDataGrid.AllowUserToAddRows = false;
            this.planDataGrid.AllowUserToDeleteRows = false;
            this.planDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.planDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pozn,
            this.setVal3,
            this.dataGridViewTextBoxColumn6});
            this.planDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.planDataGrid.Location = new System.Drawing.Point(894, 12);
            this.planDataGrid.Name = "planDataGrid";
            this.planDataGrid.RowTemplate.Height = 25;
            this.planDataGrid.Size = new System.Drawing.Size(863, 321);
            this.planDataGrid.TabIndex = 10;
            this.planDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.planDataGrid_CellValueChanged);
            // 
            // pozn
            // 
            this.pozn.HeaderText = "";
            this.pozn.Name = "pozn";
            this.pozn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // setVal3
            // 
            this.setVal3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.setVal3.HeaderText = "Множина настання планових ризикових подій";
            this.setVal3.Name = "setVal3";
            this.setVal3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // managDataGrid
            // 
            this.managDataGrid.AllowUserToAddRows = false;
            this.managDataGrid.AllowUserToDeleteRows = false;
            this.managDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.managDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.setVal4,
            this.dataGridViewTextBoxColumn4});
            this.managDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.managDataGrid.Location = new System.Drawing.Point(12, 339);
            this.managDataGrid.Name = "managDataGrid";
            this.managDataGrid.RowTemplate.Height = 25;
            this.managDataGrid.Size = new System.Drawing.Size(859, 443);
            this.managDataGrid.TabIndex = 9;
            this.managDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.managDataGrid_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // setVal4
            // 
            this.setVal4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.setVal4.HeaderText = "Множина настання ризикових подій реалізації процесу управління програмним проекто" +
    "м";
            this.setVal4.Name = "setVal4";
            this.setVal4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // costDataGrid
            // 
            this.costDataGrid.AllowUserToAddRows = false;
            this.costDataGrid.AllowUserToDeleteRows = false;
            this.costDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.costDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.setVal2,
            this.dataGridViewTextBoxColumn2});
            this.costDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.costDataGrid.Location = new System.Drawing.Point(894, 339);
            this.costDataGrid.Name = "costDataGrid";
            this.costDataGrid.RowTemplate.Height = 25;
            this.costDataGrid.Size = new System.Drawing.Size(863, 269);
            this.costDataGrid.TabIndex = 8;
            this.costDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.costDataGrid_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // setVal2
            // 
            this.setVal2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.setVal2.HeaderText = "Множина настання вартісних ризикових подій";
            this.setVal2.Name = "setVal2";
            this.setVal2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // techDataGrid
            // 
            this.techDataGrid.AllowUserToAddRows = false;
            this.techDataGrid.AllowUserToDeleteRows = false;
            this.techDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.techDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.techDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.poznachka,
            this.setVal1,
            this.val});
            this.techDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.techDataGrid.Location = new System.Drawing.Point(12, 12);
            this.techDataGrid.Name = "techDataGrid";
            this.techDataGrid.RowTemplate.Height = 25;
            this.techDataGrid.Size = new System.Drawing.Size(859, 321);
            this.techDataGrid.TabIndex = 7;
            this.techDataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.techDataGrid_CellValueChanged);
            // 
            // poznachka
            // 
            this.poznachka.HeaderText = "";
            this.poznachka.Name = "poznachka";
            // 
            // setVal1
            // 
            this.setVal1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.setVal1.DefaultCellStyle = dataGridViewCellStyle2;
            this.setVal1.HeaderText = "Множина настання технічних ризикових подій";
            this.setVal1.Name = "setVal1";
            this.setVal1.ReadOnly = true;
            // 
            // val
            // 
            this.val.HeaderText = "";
            this.val.Name = "val";
            this.val.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.val.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CalcCoef
            // 
            this.CalcCoef.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalcCoef.Location = new System.Drawing.Point(437, 989);
            this.CalcCoef.Name = "CalcCoef";
            this.CalcCoef.Size = new System.Drawing.Size(434, 90);
            this.CalcCoef.TabIndex = 14;
            this.CalcCoef.Text = "Визначити частку можливих збитків від прояву ризику";
            this.CalcCoef.UseVisualStyleBackColor = true;
            this.CalcCoef.Click += new System.EventHandler(this.CalcCoef_Click);
            // 
            // CalcProb
            // 
            this.CalcProb.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalcProb.Location = new System.Drawing.Point(12, 989);
            this.CalcProb.Name = "CalcProb";
            this.CalcProb.Size = new System.Drawing.Size(419, 90);
            this.CalcProb.TabIndex = 15;
            this.CalcProb.Text = "Визначити ймовірність настання ризикових подій";
            this.CalcProb.UseVisualStyleBackColor = true;
            this.CalcProb.Click += new System.EventHandler(this.CalcProb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(894, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Коефіцієнти вагомості кожного з експертів\r\nдля ймовірності настання ризикових под" +
    "ій";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(894, 866);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "Коефіцієнти вагомості кожного з експертів\r\nдля можливих збитків від ризику\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 799);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Розподіл вартості реалізації проекту за множинами ризиків";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 1091);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcProb);
            this.Controls.Add(this.CalcCoef);
            this.Controls.Add(this.costDistributionDataGrid);
            this.Controls.Add(this.damageDataGrid);
            this.Controls.Add(this.probabilityDataGrid);
            this.Controls.Add(this.planDataGrid);
            this.Controls.Add(this.managDataGrid);
            this.Controls.Add(this.costDataGrid);
            this.Controls.Add(this.techDataGrid);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 4";
            ((System.ComponentModel.ISupportInitialize)(this.costDistributionDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView costDistributionDataGrid;
        private DataGridView damageDataGrid;
        private DataGridView probabilityDataGrid;
        private DataGridView planDataGrid;
        private DataGridView managDataGrid;
        private DataGridView costDataGrid;
        private DataGridView techDataGrid;
        private Button CalcCoef;
        private Button CalcProb;
        private DataGridViewTextBoxColumn poznachka;
        private DataGridViewTextBoxColumn setVal1;
        private DataGridViewCheckBoxColumn val;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn setVal4;
        private DataGridViewCheckBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn setVal2;
        private DataGridViewCheckBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn pozn;
        private DataGridViewTextBoxColumn setVal3;
        private DataGridViewCheckBoxColumn dataGridViewTextBoxColumn6;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}