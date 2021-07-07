
namespace ImageProcessing
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
            this.Open_btn = new System.Windows.Forms.Button();
            this.gray_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sepia_btn = new System.Windows.Forms.Button();
            this.embos_btn = new System.Windows.Forms.Button();
            this.edges_btn = new System.Windows.Forms.Button();
            this.selectROI = new System.Windows.Forms.Button();
            this.getROI = new System.Windows.Forms.Button();
            this.imageBox1 = new System.Windows.Forms.PictureBox();
            this.imageBox2 = new System.Windows.Forms.PictureBox();
            this.BrightnessBar = new System.Windows.Forms.TrackBar();
            this.ContrastBar = new System.Windows.Forms.TrackBar();
            this.HSVBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num9 = new System.Windows.Forms.TextBox();
            this.Num8 = new System.Windows.Forms.TextBox();
            this.Num7 = new System.Windows.Forms.TextBox();
            this.Num6 = new System.Windows.Forms.TextBox();
            this.Num5 = new System.Windows.Forms.TextBox();
            this.Num4 = new System.Windows.Forms.TextBox();
            this.Num3 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.UseFilterBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSVBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Open_btn
            // 
            this.Open_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Open_btn.Location = new System.Drawing.Point(17, 670);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(75, 23);
            this.Open_btn.TabIndex = 4;
            this.Open_btn.Text = "Open";
            this.Open_btn.UseVisualStyleBackColor = true;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // gray_btn
            // 
            this.gray_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gray_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gray_btn.Location = new System.Drawing.Point(934, 670);
            this.gray_btn.Name = "gray_btn";
            this.gray_btn.Size = new System.Drawing.Size(75, 23);
            this.gray_btn.TabIndex = 5;
            this.gray_btn.Text = "Gray";
            this.gray_btn.UseVisualStyleBackColor = true;
            this.gray_btn.Click += new System.EventHandler(this.Gray_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filters:";
            // 
            // sepia_btn
            // 
            this.sepia_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sepia_btn.Location = new System.Drawing.Point(1015, 670);
            this.sepia_btn.Name = "sepia_btn";
            this.sepia_btn.Size = new System.Drawing.Size(75, 23);
            this.sepia_btn.TabIndex = 10;
            this.sepia_btn.Text = "Sepia";
            this.sepia_btn.UseVisualStyleBackColor = true;
            this.sepia_btn.Click += new System.EventHandler(this.Sepia_btn_Click);
            // 
            // embos_btn
            // 
            this.embos_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.embos_btn.Location = new System.Drawing.Point(1096, 670);
            this.embos_btn.Name = "embos_btn";
            this.embos_btn.Size = new System.Drawing.Size(75, 23);
            this.embos_btn.TabIndex = 12;
            this.embos_btn.Text = "Embos";
            this.embos_btn.UseVisualStyleBackColor = true;
            this.embos_btn.Click += new System.EventHandler(this.Embos_btn_Click);
            // 
            // edges_btn
            // 
            this.edges_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edges_btn.Location = new System.Drawing.Point(1177, 670);
            this.edges_btn.Name = "edges_btn";
            this.edges_btn.Size = new System.Drawing.Size(75, 23);
            this.edges_btn.TabIndex = 13;
            this.edges_btn.Text = "Edges";
            this.edges_btn.UseVisualStyleBackColor = true;
            this.edges_btn.Click += new System.EventHandler(this.Edges_btn_Click);
            // 
            // selectROI
            // 
            this.selectROI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectROI.Location = new System.Drawing.Point(98, 670);
            this.selectROI.Name = "selectROI";
            this.selectROI.Size = new System.Drawing.Size(75, 23);
            this.selectROI.TabIndex = 14;
            this.selectROI.Text = "Select ROI";
            this.selectROI.UseVisualStyleBackColor = true;
            this.selectROI.Click += new System.EventHandler(this.SelectROI_Click);
            // 
            // getROI
            // 
            this.getROI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getROI.Location = new System.Drawing.Point(179, 670);
            this.getROI.Name = "getROI";
            this.getROI.Size = new System.Drawing.Size(75, 23);
            this.getROI.TabIndex = 15;
            this.getROI.Text = "Get ROI";
            this.getROI.UseVisualStyleBackColor = true;
            this.getROI.Click += new System.EventHandler(this.GetROI_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(615, 628);
            this.imageBox1.TabIndex = 16;
            this.imageBox1.TabStop = false;
            this.imageBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.ImageBox1_Paint);
            this.imageBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageBox1_MouseDown);
            this.imageBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageBox1_MouseMove);
            this.imageBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageBox1_MouseUp);
            // 
            // imageBox2
            // 
            this.imageBox2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imageBox2.Location = new System.Drawing.Point(637, 12);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(615, 628);
            this.imageBox2.TabIndex = 17;
            this.imageBox2.TabStop = false;
            this.imageBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.ImageBox2_Paint);
            // 
            // BrightnessBar
            // 
            this.BrightnessBar.Location = new System.Drawing.Point(521, 679);
            this.BrightnessBar.Maximum = 100;
            this.BrightnessBar.Minimum = -100;
            this.BrightnessBar.Name = "BrightnessBar";
            this.BrightnessBar.Size = new System.Drawing.Size(75, 45);
            this.BrightnessBar.TabIndex = 19;
            this.BrightnessBar.Scroll += new System.EventHandler(this.BrightnessBar_Scroll);
            // 
            // ContrastBar
            // 
            this.ContrastBar.Location = new System.Drawing.Point(602, 679);
            this.ContrastBar.Maximum = 40;
            this.ContrastBar.Minimum = 1;
            this.ContrastBar.Name = "ContrastBar";
            this.ContrastBar.Size = new System.Drawing.Size(75, 45);
            this.ContrastBar.TabIndex = 20;
            this.ContrastBar.Value = 10;
            this.ContrastBar.Scroll += new System.EventHandler(this.ContrastBar_Scroll);
            // 
            // HSVBar
            // 
            this.HSVBar.Location = new System.Drawing.Point(683, 679);
            this.HSVBar.Maximum = 255;
            this.HSVBar.Minimum = -255;
            this.HSVBar.Name = "HSVBar";
            this.HSVBar.Size = new System.Drawing.Size(75, 45);
            this.HSVBar.TabIndex = 21;
            this.HSVBar.Scroll += new System.EventHandler(this.HSVBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Brightness:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 655);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Contrast:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 655);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "HSV:";
            // 
            // Save
            // 
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Location = new System.Drawing.Point(260, 670);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 25;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(8, 2);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(19, 20);
            this.Num1.TabIndex = 27;
            // 
            // Num9
            // 
            this.Num9.Location = new System.Drawing.Point(58, 52);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(19, 20);
            this.Num9.TabIndex = 28;
            // 
            // Num8
            // 
            this.Num8.Location = new System.Drawing.Point(33, 52);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(19, 20);
            this.Num8.TabIndex = 29;
            // 
            // Num7
            // 
            this.Num7.Location = new System.Drawing.Point(8, 52);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(19, 20);
            this.Num7.TabIndex = 30;
            // 
            // Num6
            // 
            this.Num6.Location = new System.Drawing.Point(58, 26);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(19, 20);
            this.Num6.TabIndex = 31;
            // 
            // Num5
            // 
            this.Num5.Location = new System.Drawing.Point(33, 26);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(19, 20);
            this.Num5.TabIndex = 32;
            // 
            // Num4
            // 
            this.Num4.Location = new System.Drawing.Point(8, 26);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(19, 20);
            this.Num4.TabIndex = 33;
            // 
            // Num3
            // 
            this.Num3.Location = new System.Drawing.Point(58, 2);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(19, 20);
            this.Num3.TabIndex = 34;
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(33, 2);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(19, 20);
            this.Num2.TabIndex = 35;
            // 
            // UseFilterBtn
            // 
            this.UseFilterBtn.Location = new System.Drawing.Point(83, 23);
            this.UseFilterBtn.Name = "UseFilterBtn";
            this.UseFilterBtn.Size = new System.Drawing.Size(75, 23);
            this.UseFilterBtn.TabIndex = 36;
            this.UseFilterBtn.Text = "Use filter";
            this.UseFilterBtn.UseVisualStyleBackColor = true;
            this.UseFilterBtn.Click += new System.EventHandler(this.UseFilterBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UseFilterBtn);
            this.panel1.Controls.Add(this.Num2);
            this.panel1.Controls.Add(this.Num3);
            this.panel1.Controls.Add(this.Num4);
            this.panel1.Controls.Add(this.Num1);
            this.panel1.Controls.Add(this.Num5);
            this.panel1.Controls.Add(this.Num6);
            this.panel1.Controls.Add(this.Num7);
            this.panel1.Controls.Add(this.Num8);
            this.panel1.Controls.Add(this.Num9);
            this.panel1.Location = new System.Drawing.Point(764, 646);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 78);
            this.panel1.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 736);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HSVBar);
            this.Controls.Add(this.ContrastBar);
            this.Controls.Add(this.BrightnessBar);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.getROI);
            this.Controls.Add(this.selectROI);
            this.Controls.Add(this.edges_btn);
            this.Controls.Add(this.embos_btn);
            this.Controls.Add(this.sepia_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gray_btn);
            this.Controls.Add(this.Open_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSVBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Open_btn;
        private System.Windows.Forms.Button gray_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sepia_btn;
        private System.Windows.Forms.Button embos_btn;
        private System.Windows.Forms.Button edges_btn;
        private System.Windows.Forms.Button selectROI;
        private System.Windows.Forms.Button getROI;
        private System.Windows.Forms.PictureBox imageBox1;
        private System.Windows.Forms.PictureBox imageBox2;
        private System.Windows.Forms.TrackBar BrightnessBar;
        private System.Windows.Forms.TrackBar ContrastBar;
        private System.Windows.Forms.TrackBar HSVBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num9;
        private System.Windows.Forms.TextBox Num8;
        private System.Windows.Forms.TextBox Num7;
        private System.Windows.Forms.TextBox Num6;
        private System.Windows.Forms.TextBox Num5;
        private System.Windows.Forms.TextBox Num4;
        private System.Windows.Forms.TextBox Num3;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.Button UseFilterBtn;
        private System.Windows.Forms.Panel panel1;
    }
}