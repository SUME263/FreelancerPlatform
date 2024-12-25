namespace Freelancer_Sume_Sikazwe_ADI
{
    partial class Projects
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
            TitleTxt = new TextBox();
            DurationTxt = new TextBox();
            DescriptionTxt = new RichTextBox();
            BudgetTxt = new TextBox();
            createBtn = new Button();
            lblTitle = new Label();
            lblDuration = new Label();
            lblBudget = new Label();
            lbLDesc = new Label();
            ReturnBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // TitleTxt
            // 
            TitleTxt.Location = new Point(165, 69);
            TitleTxt.Name = "TitleTxt";
            TitleTxt.Size = new Size(302, 27);
            TitleTxt.TabIndex = 0;
            // 
            // DurationTxt
            // 
            DurationTxt.Location = new Point(165, 109);
            DurationTxt.Name = "DurationTxt";
            DurationTxt.Size = new Size(302, 27);
            DurationTxt.TabIndex = 1;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Location = new Point(165, 209);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(302, 100);
            DescriptionTxt.TabIndex = 2;
            DescriptionTxt.Text = "";
            // 
            // BudgetTxt
            // 
            BudgetTxt.Location = new Point(165, 158);
            BudgetTxt.Name = "BudgetTxt";
            BudgetTxt.Size = new Size(302, 27);
            BudgetTxt.TabIndex = 3;
            BudgetTxt.TextChanged += textBox3_TextChanged;
            // 
            // createBtn
            // 
            createBtn.BackColor = Color.LimeGreen;
            createBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            createBtn.ForeColor = SystemColors.ButtonHighlight;
            createBtn.Location = new Point(165, 352);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(161, 39);
            createBtn.TabIndex = 4;
            createBtn.Text = "Create Project";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTitle.Location = new Point(42, 69);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDuration.Location = new Point(42, 109);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(70, 20);
            lblDuration.TabIndex = 6;
            lblDuration.Text = "Duration";
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBudget.Location = new Point(42, 158);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(58, 20);
            lblBudget.TabIndex = 7;
            lblBudget.Text = "Budget";
            // 
            // lbLDesc
            // 
            lbLDesc.AutoSize = true;
            lbLDesc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbLDesc.Location = new Point(42, 209);
            lbLDesc.Name = "lbLDesc";
            lbLDesc.Size = new Size(87, 20);
            lbLDesc.TabIndex = 8;
            lbLDesc.Text = "Description";
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = Color.DodgerBlue;
            ReturnBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            ReturnBtn.ForeColor = SystemColors.ButtonHighlight;
            ReturnBtn.Location = new Point(346, 352);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(121, 39);
            ReturnBtn.TabIndex = 9;
            ReturnBtn.Text = "Return";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(6, 12);
            button1.Name = "button1";
            button1.Size = new Size(538, 42);
            button1.TabIndex = 10;
            button1.Text = "Project Details";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(50, 354);
            button2.Name = "button2";
            button2.Size = new Size(94, 37);
            button2.TabIndex = 11;
            button2.Text = "Review";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Projects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(548, 423);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ReturnBtn);
            Controls.Add(lbLDesc);
            Controls.Add(lblBudget);
            Controls.Add(lblDuration);
            Controls.Add(lblTitle);
            Controls.Add(createBtn);
            Controls.Add(BudgetTxt);
            Controls.Add(DescriptionTxt);
            Controls.Add(DurationTxt);
            Controls.Add(TitleTxt);
            Name = "Projects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projects";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleTxt;
        private TextBox DurationTxt;
        private RichTextBox DescriptionTxt;
        private TextBox BudgetTxt;
        private Button createBtn;
        private Label lblTitle;
        private Label lblDuration;
        private Label lblBudget;
        private Label lbLDesc;
        private Button ReturnBtn;
        private Button button1;
        private Button button2;
    }
}