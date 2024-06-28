namespace ProjectIdeaGenerator4000
{
    partial class Form1
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
            generateIdeaBTN = new Button();
            projectIdeaLB = new Label();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // generateIdeaBTN
            // 
            generateIdeaBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            generateIdeaBTN.BackColor = Color.Gainsboro;
            generateIdeaBTN.FlatStyle = FlatStyle.Popup;
            generateIdeaBTN.Location = new Point(946, 316);
            generateIdeaBTN.Name = "generateIdeaBTN";
            generateIdeaBTN.Size = new Size(182, 78);
            generateIdeaBTN.TabIndex = 0;
            generateIdeaBTN.Text = "BAZINGA";
            generateIdeaBTN.UseVisualStyleBackColor = false;
            generateIdeaBTN.Click += generateIdeaBTN_Click;
            generateIdeaBTN.MouseHover += generateIdeaBTN_MouseHover;
            // 
            // projectIdeaLB
            // 
            projectIdeaLB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            projectIdeaLB.BackColor = Color.FromArgb(8, 8, 8);
            projectIdeaLB.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectIdeaLB.ForeColor = Color.White;
            projectIdeaLB.Location = new Point(-2, -10);
            projectIdeaLB.Name = "projectIdeaLB";
            projectIdeaLB.Size = new Size(1130, 323);
            projectIdeaLB.TabIndex = 1;
            projectIdeaLB.Text = "<No Ideas yet!>";
            projectIdeaLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(235, 235, 235);
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(-2, 440);
            label1.Name = "label1";
            label1.Size = new Size(617, 166);
            label1.TabIndex = 2;
            label1.Text = "ProjectIdeaGenerator4000";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.BackColor = Color.FromArgb(235, 235, 235);
            label2.Font = new Font("FreesiaUPC", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(621, 440);
            label2.Name = "label2";
            label2.Size = new Size(507, 166);
            label2.TabIndex = 3;
            label2.Text = "Made by Mervinpais14\r\nMIT License\r\n(C) 2024";
            label2.MouseHover += label2_MouseHover;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(32, 335);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(427, 36);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Movement effects during drumroll?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 210, 210);
            ClientSize = new Size(1129, 606);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(projectIdeaLB);
            Controls.Add(generateIdeaBTN);
            MinimumSize = new Size(1000, 640);
            Name = "Form1";
            Text = "ProjectIdeaGenerator4000";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generateIdeaBTN;
        private Label projectIdeaLB;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
    }
}
