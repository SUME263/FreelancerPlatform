namespace Freelancer_Sume_Sikazwe_ADI
{
    partial class FreelancerManager
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
            AddBtn = new Button();
            Skills = new Label();
            SkillTxt = new RichTextBox();
            PortfolioTxt = new RichTextBox();
            WorkTxt = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.LimeGreen;
            AddBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = SystemColors.ButtonHighlight;
            AddBtn.Location = new Point(167, 325);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(119, 39);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // Skills
            // 
            Skills.AutoSize = true;
            Skills.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            Skills.Location = new Point(12, 69);
            Skills.Name = "Skills";
            Skills.Size = new Size(47, 23);
            Skills.TabIndex = 1;
            Skills.Text = "Skills";
            // 
            // SkillTxt
            // 
            SkillTxt.Location = new Point(167, 69);
            SkillTxt.Name = "SkillTxt";
            SkillTxt.Size = new Size(417, 58);
            SkillTxt.TabIndex = 2;
            SkillTxt.Text = "";
            // 
            // PortfolioTxt
            // 
            PortfolioTxt.Location = new Point(167, 234);
            PortfolioTxt.Name = "PortfolioTxt";
            PortfolioTxt.Size = new Size(417, 58);
            PortfolioTxt.TabIndex = 3;
            PortfolioTxt.Text = "";
            PortfolioTxt.TextChanged += PortfolioTxt_TextChanged;
            // 
            // WorkTxt
            // 
            WorkTxt.Location = new Point(167, 147);
            WorkTxt.Name = "WorkTxt";
            WorkTxt.Size = new Size(417, 58);
            WorkTxt.TabIndex = 4;
            WorkTxt.Text = "";
            WorkTxt.TextChanged += WorkTxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(12, 147);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 5;
            label2.Text = "Portfolio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(12, 234);
            label3.Name = "label3";
            label3.Size = new Size(139, 23);
            label3.TabIndex = 6;
            label3.Text = "Work Experience";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(588, 48);
            button1.TabIndex = 7;
            button1.Text = "Freelancer Management";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(490, 325);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 8;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FreelancerManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 389);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(WorkTxt);
            Controls.Add(PortfolioTxt);
            Controls.Add(SkillTxt);
            Controls.Add(Skills);
            Controls.Add(AddBtn);
            Name = "FreelancerManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FreelancerManager";
            Load += FreelancerManager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private Label Skills;
        private RichTextBox SkillTxt;
        private RichTextBox PortfolioTxt;
        private RichTextBox WorkTxt;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}