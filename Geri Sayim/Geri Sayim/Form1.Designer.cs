namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_basla = new System.Windows.Forms.Button();
            this.bt_sifirla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_6 = new System.Windows.Forms.RadioButton();
            this.rb_5 = new System.Windows.Forms.RadioButton();
            this.rb_4 = new System.Windows.Forms.RadioButton();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.bar = new System.Windows.Forms.ProgressBar();
            this.ud_dakika = new System.Windows.Forms.NumericUpDown();
            this.ud_saniye = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_dakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_saniye)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_basla
            // 
            this.bt_basla.Location = new System.Drawing.Point(272, 19);
            this.bt_basla.Name = "bt_basla";
            this.bt_basla.Size = new System.Drawing.Size(75, 109);
            this.bt_basla.TabIndex = 0;
            this.bt_basla.Text = "Başla";
            this.bt_basla.UseVisualStyleBackColor = true;
            this.bt_basla.Click += new System.EventHandler(this.bt_basla_Click);
            // 
            // bt_sifirla
            // 
            this.bt_sifirla.Location = new System.Drawing.Point(272, 150);
            this.bt_sifirla.Name = "bt_sifirla";
            this.bt_sifirla.Size = new System.Drawing.Size(75, 23);
            this.bt_sifirla.TabIndex = 1;
            this.bt_sifirla.Text = "Sıfırla";
            this.bt_sifirla.UseVisualStyleBackColor = true;
            this.bt_sifirla.Click += new System.EventHandler(this.bt_sifirla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_6);
            this.groupBox1.Controls.Add(this.rb_5);
            this.groupBox1.Controls.Add(this.rb_4);
            this.groupBox1.Controls.Add(this.rb_3);
            this.groupBox1.Controls.Add(this.rb_2);
            this.groupBox1.Controls.Add(this.rb_1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Süre";
            // 
            // rb_6
            // 
            this.rb_6.AutoSize = true;
            this.rb_6.Location = new System.Drawing.Point(6, 134);
            this.rb_6.Name = "rb_6";
            this.rb_6.Size = new System.Drawing.Size(46, 17);
            this.rb_6.TabIndex = 5;
            this.rb_6.Text = "Özel";
            this.rb_6.UseVisualStyleBackColor = true;
            this.rb_6.CheckedChanged += new System.EventHandler(this.rb_6_CheckedChanged);
            // 
            // rb_5
            // 
            this.rb_5.AutoSize = true;
            this.rb_5.Location = new System.Drawing.Point(6, 111);
            this.rb_5.Name = "rb_5";
            this.rb_5.Size = new System.Drawing.Size(74, 17);
            this.rb_5.TabIndex = 4;
            this.rb_5.Text = "15 Dakika";
            this.rb_5.UseVisualStyleBackColor = true;
            this.rb_5.CheckedChanged += new System.EventHandler(this.rb_5_CheckedChanged);
            // 
            // rb_4
            // 
            this.rb_4.AutoSize = true;
            this.rb_4.Location = new System.Drawing.Point(6, 88);
            this.rb_4.Name = "rb_4";
            this.rb_4.Size = new System.Drawing.Size(74, 17);
            this.rb_4.TabIndex = 3;
            this.rb_4.Text = "10 Dakika";
            this.rb_4.UseVisualStyleBackColor = true;
            this.rb_4.CheckedChanged += new System.EventHandler(this.rb_4_CheckedChanged);
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Location = new System.Drawing.Point(6, 65);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(68, 17);
            this.rb_3.TabIndex = 2;
            this.rb_3.Text = "5 Dakika";
            this.rb_3.UseVisualStyleBackColor = true;
            this.rb_3.CheckedChanged += new System.EventHandler(this.rb_3_CheckedChanged);
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(6, 42);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(68, 17);
            this.rb_2.TabIndex = 1;
            this.rb_2.Text = "3 Dakika";
            this.rb_2.UseVisualStyleBackColor = true;
            this.rb_2.CheckedChanged += new System.EventHandler(this.rb_2_CheckedChanged);
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Checked = true;
            this.rb_1.Location = new System.Drawing.Point(6, 19);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(68, 17);
            this.rb_1.TabIndex = 0;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "1 Dakika";
            this.rb_1.UseVisualStyleBackColor = true;
            this.rb_1.CheckedChanged += new System.EventHandler(this.rb_1_CheckedChanged);
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(124, 19);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(142, 109);
            this.bar.TabIndex = 3;
            // 
            // ud_dakika
            // 
            this.ud_dakika.Location = new System.Drawing.Point(124, 150);
            this.ud_dakika.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.ud_dakika.Name = "ud_dakika";
            this.ud_dakika.Size = new System.Drawing.Size(68, 20);
            this.ud_dakika.TabIndex = 4;
            this.ud_dakika.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ud_dakika.ValueChanged += new System.EventHandler(this.ud_dakika_ValueChanged);
            // 
            // ud_saniye
            // 
            this.ud_saniye.Location = new System.Drawing.Point(198, 150);
            this.ud_saniye.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.ud_saniye.Name = "ud_saniye";
            this.ud_saniye.Size = new System.Drawing.Size(68, 20);
            this.ud_saniye.TabIndex = 5;
            this.ud_saniye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ud_saniye.ValueChanged += new System.EventHandler(this.ud_saniye_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 188);
            this.Controls.Add(this.ud_saniye);
            this.Controls.Add(this.ud_dakika);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_sifirla);
            this.Controls.Add(this.bt_basla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Geri Sayaç by Recep Çakır";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_dakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_saniye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_basla;
        private System.Windows.Forms.Button bt_sifirla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_6;
        private System.Windows.Forms.RadioButton rb_5;
        private System.Windows.Forms.RadioButton rb_4;
        private System.Windows.Forms.RadioButton rb_3;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.ProgressBar bar;
        private System.Windows.Forms.NumericUpDown ud_dakika;
        private System.Windows.Forms.NumericUpDown ud_saniye;
        protected System.Windows.Forms.Timer timer1;
    }
}

