
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // Open_btn
            // 
            this.Open_btn.Location = new System.Drawing.Point(12, 646);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(75, 23);
            this.Open_btn.TabIndex = 4;
            this.Open_btn.Text = "Open";
            this.Open_btn.UseVisualStyleBackColor = true;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // gray_btn
            // 
            this.gray_btn.Location = new System.Drawing.Point(934, 651);
            this.gray_btn.Name = "gray_btn";
            this.gray_btn.Size = new System.Drawing.Size(75, 23);
            this.gray_btn.TabIndex = 5;
            this.gray_btn.Text = "Gray";
            this.gray_btn.UseVisualStyleBackColor = true;
            this.gray_btn.Click += new System.EventHandler(this.gray_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 661);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filters:";
            // 
            // sepia_btn
            // 
            this.sepia_btn.Location = new System.Drawing.Point(1015, 651);
            this.sepia_btn.Name = "sepia_btn";
            this.sepia_btn.Size = new System.Drawing.Size(75, 23);
            this.sepia_btn.TabIndex = 10;
            this.sepia_btn.Text = "Sepia";
            this.sepia_btn.UseVisualStyleBackColor = true;
            this.sepia_btn.Click += new System.EventHandler(this.sepia_btn_Click);
            // 
            // embos_btn
            // 
            this.embos_btn.Location = new System.Drawing.Point(1096, 651);
            this.embos_btn.Name = "embos_btn";
            this.embos_btn.Size = new System.Drawing.Size(75, 23);
            this.embos_btn.TabIndex = 12;
            this.embos_btn.Text = "Embos";
            this.embos_btn.UseVisualStyleBackColor = true;
            this.embos_btn.Click += new System.EventHandler(this.embos_btn_Click);
            // 
            // edges_btn
            // 
            this.edges_btn.Location = new System.Drawing.Point(1177, 651);
            this.edges_btn.Name = "edges_btn";
            this.edges_btn.Size = new System.Drawing.Size(75, 23);
            this.edges_btn.TabIndex = 13;
            this.edges_btn.Text = "Edges";
            this.edges_btn.UseVisualStyleBackColor = true;
            this.edges_btn.Click += new System.EventHandler(this.edges_btn_Click);
            // 
            // selectROI
            // 
            this.selectROI.Location = new System.Drawing.Point(93, 646);
            this.selectROI.Name = "selectROI";
            this.selectROI.Size = new System.Drawing.Size(75, 23);
            this.selectROI.TabIndex = 14;
            this.selectROI.Text = "Select ROI";
            this.selectROI.UseVisualStyleBackColor = true;
            this.selectROI.Click += new System.EventHandler(this.selectROI_Click);
            // 
            // getROI
            // 
            this.getROI.Location = new System.Drawing.Point(174, 646);
            this.getROI.Name = "getROI";
            this.getROI.Size = new System.Drawing.Size(75, 23);
            this.getROI.TabIndex = 15;
            this.getROI.Text = "Get ROI";
            this.getROI.UseVisualStyleBackColor = true;
            this.getROI.Click += new System.EventHandler(this.getROI_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(615, 628);
            this.imageBox1.TabIndex = 16;
            this.imageBox1.TabStop = false;
            this.imageBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox1_Paint);
            this.imageBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseDown);
            this.imageBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseMove);
            this.imageBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseUp);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(637, 12);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(615, 628);
            this.imageBox2.TabIndex = 17;
            this.imageBox2.TabStop = false;
            this.imageBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox2_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(691, 680);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(75, 45);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(772, 680);
            this.trackBar2.Maximum = 40;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(75, 45);
            this.trackBar2.TabIndex = 20;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(853, 680);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(75, 45);
            this.trackBar3.TabIndex = 21;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Brightness:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(769, 656);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Contrast:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(850, 656);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "HSV:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 736);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

