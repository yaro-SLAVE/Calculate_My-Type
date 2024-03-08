namespace Calculate_My_Type
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultBox = new System.Windows.Forms.PictureBox();
            this.sBar = new System.Windows.Forms.VScrollBar();
            this.vBar = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rField = new System.Windows.Forms.NumericUpDown();
            this.gField = new System.Windows.Forms.NumericUpDown();
            this.bField = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hField = new System.Windows.Forms.NumericUpDown();
            this.resultHSV = new System.Windows.Forms.Label();
            this.resultRGB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hField)).BeginInit();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(101, 44);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(258, 102);
            this.resultBox.TabIndex = 0;
            this.resultBox.TabStop = false;
            // 
            // sBar
            // 
            this.sBar.Location = new System.Drawing.Point(408, 44);
            this.sBar.Name = "sBar";
            this.sBar.Size = new System.Drawing.Size(45, 247);
            this.sBar.TabIndex = 1;
            this.sBar.ValueChanged += new System.EventHandler(this.sBar_ValueChanged);
            // 
            // vBar
            // 
            this.vBar.Location = new System.Drawing.Point(487, 44);
            this.vBar.Name = "vBar";
            this.vBar.Size = new System.Drawing.Size(45, 247);
            this.vBar.TabIndex = 1;
            this.vBar.ValueChanged += new System.EventHandler(this.vBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "V";
            // 
            // rField
            // 
            this.rField.Location = new System.Drawing.Point(101, 171);
            this.rField.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rField.Name = "rField";
            this.rField.Size = new System.Drawing.Size(120, 26);
            this.rField.TabIndex = 5;
            this.rField.ValueChanged += new System.EventHandler(this.rField_ValueChanged);
            // 
            // gField
            // 
            this.gField.Location = new System.Drawing.Point(101, 213);
            this.gField.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gField.Name = "gField";
            this.gField.Size = new System.Drawing.Size(120, 26);
            this.gField.TabIndex = 6;
            this.gField.ValueChanged += new System.EventHandler(this.gField_ValueChanged);
            // 
            // bField
            // 
            this.bField.Location = new System.Drawing.Point(101, 256);
            this.bField.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bField.Name = "bField";
            this.bField.Size = new System.Drawing.Size(120, 26);
            this.bField.TabIndex = 7;
            this.bField.ValueChanged += new System.EventHandler(this.bField_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "H";
            // 
            // hField
            // 
            this.hField.Location = new System.Drawing.Point(101, 298);
            this.hField.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.hField.Name = "hField";
            this.hField.Size = new System.Drawing.Size(120, 26);
            this.hField.TabIndex = 11;
            this.hField.ValueChanged += new System.EventHandler(this.hField_ValueChanged);
            // 
            // resultHSV
            // 
            this.resultHSV.AutoSize = true;
            this.resultHSV.Location = new System.Drawing.Point(112, 383);
            this.resultHSV.Name = "resultHSV";
            this.resultHSV.Size = new System.Drawing.Size(0, 20);
            this.resultHSV.TabIndex = 14;
            // 
            // resultRGB
            // 
            this.resultRGB.AutoSize = true;
            this.resultRGB.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultRGB.Location = new System.Drawing.Point(112, 371);
            this.resultRGB.Name = "resultRGB";
            this.resultRGB.Size = new System.Drawing.Size(80, 36);
            this.resultRGB.TabIndex = 16;
            this.resultRGB.Text = "RGB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "RGB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultRGB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.resultHSV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bField);
            this.Controls.Add(this.gField);
            this.Controls.Add(this.rField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vBar);
            this.Controls.Add(this.sBar);
            this.Controls.Add(this.resultBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resultBox;
        private System.Windows.Forms.VScrollBar sBar;
        private System.Windows.Forms.VScrollBar vBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown rField;
        private System.Windows.Forms.NumericUpDown gField;
        private System.Windows.Forms.NumericUpDown bField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown hField;
        private System.Windows.Forms.Label resultHSV;
        private System.Windows.Forms.Label resultRGB;
        private System.Windows.Forms.Label label10;
    }
}

