namespace PDFCompressor
{
    partial class UploadForm
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
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(542, 178);
            button1.Name = "button1";
            button1.Size = new Size(132, 46);
            button1.TabIndex = 0;
            button1.Text = "Upload File";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientActiveCaption;
            textBox1.Location = new Point(110, 178);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 46);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(302, 267);
            button2.Name = "button2";
            button2.Size = new Size(170, 41);
            button2.TabIndex = 2;
            button2.Text = "Compress File";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Chartreuse;
            progressBar1.ForeColor = Color.Chartreuse;
            progressBar1.Location = new Point(160, 239);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(467, 10);
            progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 65);
            label1.Name = "label1";
            label1.Size = new Size(376, 58);
            label1.TabIndex = 4;
            label1.Text = "File Compresssor";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(211, 137);
            label2.Name = "label2";
            label2.Size = new Size(392, 20);
            label2.TabIndex = 5;
            label2.Text = "Compressing your file without compromising quality.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(398, 424);
            label3.Name = "label3";
            label3.Size = new Size(390, 17);
            label3.TabIndex = 6;
            label3.Text = "Product by zone7systems. Unauthorized sharing is prohibited.";
            // 
            // UploadForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "UploadForm";
            Text = "File Compressor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
