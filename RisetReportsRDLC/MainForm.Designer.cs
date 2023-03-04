namespace RisetReportsRDLC
{
    partial class MainForm
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
            this.cboJenisForm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoadDefinition = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmRows = new System.Windows.Forms.NumericUpDown();
            this.CheckLoadFirst = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmRows)).BeginInit();
            this.SuspendLayout();
            // 
            // cboJenisForm
            // 
            this.cboJenisForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJenisForm.FormattingEnabled = true;
            this.cboJenisForm.Location = new System.Drawing.Point(25, 26);
            this.cboJenisForm.Name = "cboJenisForm";
            this.cboJenisForm.Size = new System.Drawing.Size(292, 21);
            this.cboJenisForm.TabIndex = 0;
            this.cboJenisForm.SelectedIndexChanged += new System.EventHandler(this.cboJenisForm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilih Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pilih Jenis Load Report Definition";
            // 
            // cboLoadDefinition
            // 
            this.cboLoadDefinition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoadDefinition.FormattingEnabled = true;
            this.cboLoadDefinition.Items.AddRange(new object[] {
            "EmbeddedDeffinition",
            "CachedDeffinition"});
            this.cboLoadDefinition.Location = new System.Drawing.Point(25, 80);
            this.cboLoadDefinition.Name = "cboLoadDefinition";
            this.cboLoadDefinition.Size = new System.Drawing.Size(292, 21);
            this.cboLoadDefinition.TabIndex = 3;
            this.cboLoadDefinition.SelectedIndexChanged += new System.EventHandler(this.cboLoadDefinition_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Open Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboDatabase
            // 
            this.cboDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Items.AddRange(new object[] {
            "Besar",
            "Kecil"});
            this.cboDatabase.Location = new System.Drawing.Point(25, 165);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(292, 21);
            this.cboDatabase.TabIndex = 6;
            this.cboDatabase.SelectedIndexChanged += new System.EventHandler(this.cboDatabase_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pilih Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(22, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Banyak Row";
            // 
            // nmRows
            // 
            this.nmRows.Enabled = false;
            this.nmRows.Location = new System.Drawing.Point(25, 207);
            this.nmRows.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nmRows.Name = "nmRows";
            this.nmRows.Size = new System.Drawing.Size(139, 20);
            this.nmRows.TabIndex = 8;
            this.nmRows.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // CheckLoadFirst
            // 
            this.CheckLoadFirst.AutoSize = true;
            this.CheckLoadFirst.Location = new System.Drawing.Point(25, 120);
            this.CheckLoadFirst.Name = "CheckLoadFirst";
            this.CheckLoadFirst.Size = new System.Drawing.Size(120, 17);
            this.CheckLoadFirst.TabIndex = 9;
            this.CheckLoadFirst.Text = "Load Report Diawal";
            this.CheckLoadFirst.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 319);
            this.Controls.Add(this.CheckLoadFirst);
            this.Controls.Add(this.nmRows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDatabase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboLoadDefinition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboJenisForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboJenisForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLoadDefinition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmRows;
        private System.Windows.Forms.CheckBox CheckLoadFirst;
    }
}