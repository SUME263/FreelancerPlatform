namespace Freelancer_Sume_Sikazwe_ADI
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
            UsernameTxt = new TextBox();
            PasswordTxt = new TextBox();
            Log = new Button();
            Sign = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmailLog = new Label();
            EmailTxt = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UsernameTxt
            // 
            UsernameTxt.Location = new Point(148, 81);
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(304, 27);
            UsernameTxt.TabIndex = 0;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Location = new Point(148, 129);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.Size = new Size(304, 27);
            PasswordTxt.TabIndex = 1;
            // 
            // Log
            // 
            Log.BackColor = Color.DodgerBlue;
            Log.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Log.ForeColor = SystemColors.ButtonHighlight;
            Log.Location = new Point(148, 235);
            Log.Name = "Log";
            Log.Size = new Size(109, 37);
            Log.TabIndex = 2;
            Log.Text = "Login";
            Log.UseVisualStyleBackColor = false;
            Log.Click += Log_Click;
            // 
            // Sign
            // 
            Sign.AccessibleName = "Loginf";
            Sign.BackColor = Color.DodgerBlue;
            Sign.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sign.ForeColor = SystemColors.ButtonHighlight;
            Sign.Location = new Point(348, 235);
            Sign.Name = "Sign";
            Sign.Size = new Size(104, 37);
            Sign.TabIndex = 3;
            Sign.Text = "Sign Up";
            Sign.UseVisualStyleBackColor = false;
            Sign.Click += Sign_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 81);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 4;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 129);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 23);
            label3.Name = "label3";
            label3.Size = new Size(214, 82);
            label3.TabIndex = 6;
            label3.Text = "Welcome to ProjectsGo";
            // 
            // EmailLog
            // 
            EmailLog.AutoSize = true;
            EmailLog.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLog.Location = new Point(37, 176);
            EmailLog.Name = "EmailLog";
            EmailLog.Size = new Size(51, 23);
            EmailLog.TabIndex = 7;
            EmailLog.Text = "Email";
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(148, 176);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(304, 27);
            EmailTxt.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(255, 309);
            button1.Name = "button1";
            button1.Size = new Size(110, 35);
            button1.TabIndex = 10;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(475, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 377);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(13, 117);
            label4.Name = "label4";
            label4.Size = new Size(174, 62);
            label4.TabIndex = 0;
            label4.Text = "Bringing Freelancers and Clients together. \r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(148, 32);
            label5.Name = "label5";
            label5.Size = new Size(191, 25);
            label5.TabIndex = 12;
            label5.Text = "Login or sign up here";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 375);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(EmailTxt);
            Controls.Add(EmailLog);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Sign);
            Controls.Add(Log);
            Controls.Add(PasswordTxt);
            Controls.Add(UsernameTxt);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameTxt;
        private TextBox PasswordTxt;
        private Button Log;
        private Button Sign;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label EmailLog;
        private TextBox EmailTxt;
        private Button button1;
        private Panel panel1;
        private Label label4;
        private Label label5;
    }
}
