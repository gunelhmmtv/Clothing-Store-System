namespace Vallahson
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            UserNametb = new TextBox();
            label1 = new Label();
            Passwordtb = new Label();
            passtb = new TextBox();
            LoginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleVioletRed;
            panel1.Location = new Point(552, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 451);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(209, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // UserNametb
            // 
            UserNametb.Location = new Point(60, 184);
            UserNametb.Name = "UserNametb";
            UserNametb.Size = new Size(241, 27);
            UserNametb.TabIndex = 2;
            UserNametb.TextChanged += UsarNametb_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PaleVioletRed;
            label1.Location = new Point(60, 153);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 3;
            label1.Text = "UserName";
            // 
            // Passwordtb
            // 
            Passwordtb.AutoSize = true;
            Passwordtb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Passwordtb.ForeColor = Color.PaleVioletRed;
            Passwordtb.Location = new Point(60, 231);
            Passwordtb.Name = "Passwordtb";
            Passwordtb.Size = new Size(101, 28);
            Passwordtb.TabIndex = 5;
            Passwordtb.Text = "Password";
            // 
            // passtb
            // 
            passtb.Location = new Point(60, 262);
            passtb.Name = "passtb";
            passtb.Size = new Size(241, 27);
            passtb.TabIndex = 4;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.PaleVioletRed;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.LavenderBlush;
            LoginBtn.Location = new Point(205, 332);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(160, 46);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginBtn);
            Controls.Add(Passwordtb);
            Controls.Add(passtb);
            Controls.Add(label1);
            Controls.Add(UserNametb);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox UserNametb;
        private Label label1;
        private Label Passwordtb;
        private TextBox passtb;
        private Button LoginBtn;
    }
}
