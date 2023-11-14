namespace DinerGUIApplication
{
    partial class splash_screen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash_screen));
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lblLoading = new Label();
            lblNum = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(680, 362);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.SteelBlue;
            progressBar1.Location = new Point(0, 350);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(680, 12);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.BackColor = SystemColors.ActiveCaptionText;
            lblLoading.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoading.ForeColor = SystemColors.ButtonFace;
            lblLoading.Location = new Point(0, 327);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(43, 20);
            lblLoading.TabIndex = 2;
            lblLoading.Text = "label1";
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.BackColor = SystemColors.ActiveCaptionText;
            lblNum.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNum.ForeColor = SystemColors.ButtonFace;
            lblNum.Location = new Point(635, 327);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(43, 20);
            lblNum.TabIndex = 3;
            lblNum.Text = "label1";
            // 
            // splash_screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 362);
            Controls.Add(lblNum);
            Controls.Add(lblLoading);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "splash_screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "splash_screen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label lblLoading;
        private Label lblNum;
    }
}