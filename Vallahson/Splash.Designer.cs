namespace Vallahson
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            MyProgressBar = new ProgressBar();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Percent = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(233, 21);
            label1.Name = "label1";
            label1.Size = new Size(328, 39);
            label1.TabIndex = 0;
            label1.Text = "Clothing Shop System";
            // 
            // MyProgressBar
            // 
            MyProgressBar.ForeColor = Color.MediumVioletRed;
            MyProgressBar.Location = new Point(163, 363);
            MyProgressBar.Name = "MyProgressBar";
            MyProgressBar.Size = new Size(481, 29);
            MyProgressBar.TabIndex = 1;
            MyProgressBar.Click += progressBar1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LavenderBlush;
            label2.Location = new Point(163, 332);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 2;
            label2.Text = "Loading...";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(277, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Percent
            // 
            Percent.AutoSize = true;
            Percent.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Percent.ForeColor = Color.LavenderBlush;
            Percent.Location = new Point(368, 234);
            Percent.Name = "Percent";
            Percent.Size = new Size(46, 26);
            Percent.TabIndex = 4;
            Percent.Text = "%%";
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(800, 450);
            Controls.Add(Percent);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(MyProgressBar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar MyProgressBar;
        private Label label2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label Percent;
    }
}