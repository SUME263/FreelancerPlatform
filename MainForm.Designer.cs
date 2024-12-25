namespace Freelancer_Sume_Sikazwe_ADI
{
    partial class MainForm
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
            splitContainer1 = new SplitContainer();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Logout = new Button();
            lblUserType = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            projectsDataGridView = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projectsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(Logout);
            splitContainer1.Panel1.Controls.Add(lblUserType);
            splitContainer1.Panel1.Controls.Add(lblPhoneNumber);
            splitContainer1.Panel1.Controls.Add(lblEmail);
            splitContainer1.Panel1.Controls.Add(lblUsername);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(projectsDataGridView);
            splitContainer1.Panel2.Controls.Add(button4);
            splitContainer1.Size = new Size(897, 450);
            splitContainer1.SplitterDistance = 298;
            splitContainer1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(19, 269);
            button3.Name = "button3";
            button3.Size = new Size(222, 38);
            button3.TabIndex = 7;
            button3.Text = "Manage profile";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(18, 325);
            button2.Name = "button2";
            button2.Size = new Size(223, 41);
            button2.TabIndex = 6;
            button2.Text = "Project and Reviews";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 18);
            button1.Name = "button1";
            button1.Size = new Size(287, 37);
            button1.TabIndex = 5;
            button1.Text = "User Details";
            button1.UseVisualStyleBackColor = false;
            // 
            // Logout
            // 
            Logout.BackColor = Color.DodgerBlue;
            Logout.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logout.ForeColor = SystemColors.ButtonHighlight;
            Logout.Location = new Point(18, 383);
            Logout.Name = "Logout";
            Logout.Size = new Size(223, 39);
            Logout.TabIndex = 4;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblUserType.Location = new Point(18, 65);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(78, 23);
            lblUserType.TabIndex = 3;
            lblUserType.Text = "Usertype";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(18, 202);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(51, 23);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Email";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(19, 155);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(91, 23);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Phone No:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblUsername.Location = new Point(18, 111);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // projectsDataGridView
            // 
            projectsDataGridView.BackgroundColor = SystemColors.Control;
            projectsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            projectsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsDataGridView.Location = new Point(3, 52);
            projectsDataGridView.Name = "projectsDataGridView";
            projectsDataGridView.RowHeadersWidth = 51;
            projectsDataGridView.Size = new Size(555, 386);
            projectsDataGridView.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.LimeGreen;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(-1, 18);
            button4.Name = "button4";
            button4.Size = new Size(559, 37);
            button4.TabIndex = 4;
            button4.Text = "Projects";
            button4.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 450);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)projectsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblUserType;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblUsername;
        private Button Logout;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView projectsDataGridView;
        private Button button4;
    }
}