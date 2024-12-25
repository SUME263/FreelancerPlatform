namespace Freelancer_Sume_Sikazwe_ADI
{
    partial class Review
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
            Rating = new TextBox();
            CommentTxt = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            submitBtn = new Button();
            FreeLancerBox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Rating
            // 
            Rating.Location = new Point(150, 102);
            Rating.Name = "Rating";
            Rating.Size = new Size(226, 27);
            Rating.TabIndex = 1;
            // 
            // CommentTxt
            // 
            CommentTxt.Location = new Point(150, 160);
            CommentTxt.Name = "CommentTxt";
            CommentTxt.Size = new Size(226, 65);
            CommentTxt.TabIndex = 2;
            CommentTxt.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(37, 45);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 3;
            label1.Text = "Freelancer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(37, 102);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 4;
            label2.Text = "Rating";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(40, 160);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 5;
            label3.Text = "Comment";
            label3.Click += label3_Click;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.DodgerBlue;
            submitBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitBtn.ForeColor = SystemColors.ButtonHighlight;
            submitBtn.Location = new Point(93, 275);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(135, 42);
            submitBtn.TabIndex = 6;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // FreeLancerBox
            // 
            FreeLancerBox.FormattingEnabled = true;
            FreeLancerBox.Location = new Point(150, 45);
            FreeLancerBox.Name = "FreeLancerBox";
            FreeLancerBox.Size = new Size(226, 28);
            FreeLancerBox.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(305, 283);
            button1.Name = "button1";
            button1.Size = new Size(71, 34);
            button1.TabIndex = 8;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Review
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 361);
            Controls.Add(button1);
            Controls.Add(FreeLancerBox);
            Controls.Add(submitBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CommentTxt);
            Controls.Add(Rating);
            Name = "Review";
            Text = "Review";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Rating;
        private RichTextBox CommentTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button submitBtn;
        private ComboBox FreeLancerBox;
        private Button button1;
    }
}