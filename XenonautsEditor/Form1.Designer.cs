namespace XenonautsEditor
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TuBox = new System.Windows.Forms.NumericUpDown();
            this.HpBox = new System.Windows.Forms.NumericUpDown();
            this.StrBox = new System.Windows.Forms.NumericUpDown();
            this.AccBox = new System.Windows.Forms.NumericUpDown();
            this.RefBox = new System.Windows.Forms.NumericUpDown();
            this.BraBox = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SoldierList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.TuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HpBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Strenght";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Accuracy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Reflex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bravery";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(251, 44);
            this.NameBox.MaxLength = 20;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.TuBox_ValueChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(235, 340);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 15;
            this.Save.TabStop = false;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(319, 340);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 16;
            this.Load.TabStop = false;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // TuBox
            // 
            this.TuBox.Enabled = false;
            this.TuBox.Location = new System.Drawing.Point(251, 71);
            this.TuBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.TuBox.Name = "TuBox";
            this.TuBox.Size = new System.Drawing.Size(59, 20);
            this.TuBox.TabIndex = 2;
            this.TuBox.ValueChanged += new System.EventHandler(this.TuBox_ValueChanged);
            this.TuBox.Enter += new System.EventHandler(this.TuBox_Enter);
            // 
            // HpBox
            // 
            this.HpBox.Enabled = false;
            this.HpBox.Location = new System.Drawing.Point(251, 99);
            this.HpBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.HpBox.Name = "HpBox";
            this.HpBox.Size = new System.Drawing.Size(59, 20);
            this.HpBox.TabIndex = 3;
            this.HpBox.ValueChanged += new System.EventHandler(this.TuBox_ValueChanged);
            this.HpBox.Enter += new System.EventHandler(this.TuBox_Enter);
            // 
            // StrBox
            // 
            this.StrBox.Enabled = false;
            this.StrBox.Location = new System.Drawing.Point(251, 125);
            this.StrBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.StrBox.Name = "StrBox";
            this.StrBox.Size = new System.Drawing.Size(59, 20);
            this.StrBox.TabIndex = 4;
            this.StrBox.ValueChanged += new System.EventHandler(this.TuBox_ValueChanged);
            this.StrBox.Enter += new System.EventHandler(this.TuBox_Enter);
            // 
            // AccBox
            // 
            this.AccBox.Enabled = false;
            this.AccBox.Location = new System.Drawing.Point(251, 151);
            this.AccBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AccBox.Name = "AccBox";
            this.AccBox.Size = new System.Drawing.Size(59, 20);
            this.AccBox.TabIndex = 5;
            this.AccBox.ValueChanged += new System.EventHandler(this.TuBox_ValueChanged);
            this.AccBox.Enter += new System.EventHandler(this.TuBox_Enter);
            // 
            // RefBox
            // 
            this.RefBox.Enabled = false;
            this.RefBox.Location = new System.Drawing.Point(251, 177);
            this.RefBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RefBox.Name = "RefBox";
            this.RefBox.Size = new System.Drawing.Size(59, 20);
            this.RefBox.TabIndex = 6;
            this.RefBox.ValueChanged += new System.EventHandler(this.TuBox_ValueChanged);
            this.RefBox.Enter += new System.EventHandler(this.TuBox_Enter);
            // 
            // BraBox
            // 
            this.BraBox.Enabled = false;
            this.BraBox.Location = new System.Drawing.Point(251, 203);
            this.BraBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BraBox.Name = "BraBox";
            this.BraBox.Size = new System.Drawing.Size(59, 20);
            this.BraBox.TabIndex = 7;
            this.BraBox.ValueChanged += new System.EventHandler(this.TuBox_ValueChanged);
            this.BraBox.Enter += new System.EventHandler(this.TuBox_Enter);
            // 
            // SoldierList
            // 
            this.SoldierList.DisplayMember = "name";
            this.SoldierList.FormattingEnabled = true;
            this.SoldierList.Location = new System.Drawing.Point(12, 8);
            this.SoldierList.Name = "SoldierList";
            this.SoldierList.Size = new System.Drawing.Size(202, 355);
            this.SoldierList.TabIndex = 0;
            this.SoldierList.TabStop = false;
            this.SoldierList.SelectedIndexChanged += new System.EventHandler(this.SoldierList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 376);
            this.Controls.Add(this.SoldierList);
            this.Controls.Add(this.BraBox);
            this.Controls.Add(this.RefBox);
            this.Controls.Add(this.AccBox);
            this.Controls.Add(this.StrBox);
            this.Controls.Add(this.HpBox);
            this.Controls.Add(this.TuBox);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Xenonauts Community Edition Stats Editor";
            ((System.ComponentModel.ISupportInitialize)(this.TuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HpBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown TuBox;
        private System.Windows.Forms.NumericUpDown HpBox;
        private System.Windows.Forms.NumericUpDown StrBox;
        private System.Windows.Forms.NumericUpDown AccBox;
        private System.Windows.Forms.NumericUpDown RefBox;
        private System.Windows.Forms.NumericUpDown BraBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox SoldierList;
    }
}