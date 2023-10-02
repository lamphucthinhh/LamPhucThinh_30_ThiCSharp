namespace LamPhucThinh_30_ThiCSharp
{
    partial class định_dạng
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
            this.txtlaptrinh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkblod = new System.Windows.Forms.CheckBox();
            this.chkitalic = new System.Windows.Forms.CheckBox();
            this.chkgachchan = new System.Windows.Forms.CheckBox();
            this.radred = new System.Windows.Forms.RadioButton();
            this.radblack = new System.Windows.Forms.RadioButton();
            this.radgreen = new System.Windows.Forms.RadioButton();
            this.radblue = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbllaptrinh = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên";
            // 
            // txtlaptrinh
            // 
            this.txtlaptrinh.Location = new System.Drawing.Point(107, 60);
            this.txtlaptrinh.Name = "txtlaptrinh";
            this.txtlaptrinh.Size = new System.Drawing.Size(228, 20);
            this.txtlaptrinh.TabIndex = 1;
            this.txtlaptrinh.Text = "Dethi2023";
            this.txtlaptrinh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.radblue);
            this.groupBox1.Controls.Add(this.radgreen);
            this.groupBox1.Controls.Add(this.radblack);
            this.groupBox1.Controls.Add(this.radred);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(26, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.chkgachchan);
            this.groupBox2.Controls.Add(this.chkitalic);
            this.groupBox2.Controls.Add(this.chkblod);
            this.groupBox2.Location = new System.Drawing.Point(275, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 168);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // chkblod
            // 
            this.chkblod.AutoSize = true;
            this.chkblod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkblod.ForeColor = System.Drawing.Color.Blue;
            this.chkblod.Location = new System.Drawing.Point(26, 25);
            this.chkblod.Name = "chkblod";
            this.chkblod.Size = new System.Drawing.Size(80, 17);
            this.chkblod.TabIndex = 0;
            this.chkblod.Text = "Đậm Blod";
            this.chkblod.UseVisualStyleBackColor = true;
            this.chkblod.CheckedChanged += new System.EventHandler(this.chkblod_CheckedChanged);
            // 
            // chkitalic
            // 
            this.chkitalic.AutoSize = true;
            this.chkitalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkitalic.ForeColor = System.Drawing.Color.Blue;
            this.chkitalic.Location = new System.Drawing.Point(26, 66);
            this.chkitalic.Name = "chkitalic";
            this.chkitalic.Size = new System.Drawing.Size(105, 17);
            this.chkitalic.TabIndex = 0;
            this.chkitalic.Text = "Nghiêng Italic";
            this.chkitalic.UseVisualStyleBackColor = true;
            this.chkitalic.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkgachchan
            // 
            this.chkgachchan.AutoSize = true;
            this.chkgachchan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkgachchan.ForeColor = System.Drawing.Color.Blue;
            this.chkgachchan.Location = new System.Drawing.Point(26, 106);
            this.chkgachchan.Name = "chkgachchan";
            this.chkgachchan.Size = new System.Drawing.Size(88, 17);
            this.chkgachchan.TabIndex = 0;
            this.chkgachchan.Text = "Gạch chân";
            this.chkgachchan.UseVisualStyleBackColor = true;
            this.chkgachchan.CheckedChanged += new System.EventHandler(this.chkgachchan_CheckedChanged);
            // 
            // radred
            // 
            this.radred.AutoSize = true;
            this.radred.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radred.ForeColor = System.Drawing.Color.Red;
            this.radred.Location = new System.Drawing.Point(12, 36);
            this.radred.Name = "radred";
            this.radred.Size = new System.Drawing.Size(48, 17);
            this.radred.TabIndex = 4;
            this.radred.TabStop = true;
            this.radred.Text = "Red";
            this.radred.UseVisualStyleBackColor = true;
            this.radred.CheckedChanged += new System.EventHandler(this.radred_CheckedChanged);
            // 
            // radblack
            // 
            this.radblack.AutoSize = true;
            this.radblack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radblack.Location = new System.Drawing.Point(12, 133);
            this.radblack.Name = "radblack";
            this.radblack.Size = new System.Drawing.Size(57, 17);
            this.radblack.TabIndex = 4;
            this.radblack.TabStop = true;
            this.radblack.Text = "Black";
            this.radblack.UseVisualStyleBackColor = true;
            this.radblack.CheckedChanged += new System.EventHandler(this.radblack_CheckedChanged);
            // 
            // radgreen
            // 
            this.radgreen.AutoSize = true;
            this.radgreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgreen.ForeColor = System.Drawing.Color.Lime;
            this.radgreen.Location = new System.Drawing.Point(12, 69);
            this.radgreen.Name = "radgreen";
            this.radgreen.Size = new System.Drawing.Size(59, 17);
            this.radgreen.TabIndex = 4;
            this.radgreen.TabStop = true;
            this.radgreen.Text = "Green";
            this.radgreen.UseVisualStyleBackColor = true;
            this.radgreen.CheckedChanged += new System.EventHandler(this.radgreen_CheckedChanged);
            // 
            // radblue
            // 
            this.radblue.AutoSize = true;
            this.radblue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radblue.ForeColor = System.Drawing.Color.Blue;
            this.radblue.Location = new System.Drawing.Point(11, 103);
            this.radblue.Name = "radblue";
            this.radblue.Size = new System.Drawing.Size(50, 17);
            this.radblue.TabIndex = 4;
            this.radblue.TabStop = true;
            this.radblue.Text = "Blue";
            this.radblue.UseVisualStyleBackColor = true;
            this.radblue.CheckedChanged += new System.EventHandler(this.radblue_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lập trình bởi:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(513, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbllaptrinh
            // 
            this.lbllaptrinh.Location = new System.Drawing.Point(147, 304);
            this.lbllaptrinh.Name = "lbllaptrinh";
            this.lbllaptrinh.Size = new System.Drawing.Size(228, 20);
            this.lbllaptrinh.TabIndex = 1;
            // 
            // định_dạng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbllaptrinh);
            this.Controls.Add(this.txtlaptrinh);
            this.Controls.Add(this.label1);
            this.Name = "định_dạng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "định_dạng";
            this.Load += new System.EventHandler(this.định_dạng_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlaptrinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radblue;
        private System.Windows.Forms.RadioButton radgreen;
        private System.Windows.Forms.RadioButton radblack;
        private System.Windows.Forms.RadioButton radred;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkgachchan;
        private System.Windows.Forms.CheckBox chkitalic;
        private System.Windows.Forms.CheckBox chkblod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lbllaptrinh;
    }
}