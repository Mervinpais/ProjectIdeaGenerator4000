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
            SuspendLayout();
            // 
            // generateIdeaBTN
            // 
            generateIdeaBTN.Location = new Point(313, 301);
            generateIdeaBTN.Name = "generateIdeaBTN";
            generateIdeaBTN.Size = new Size(150, 46);
            generateIdeaBTN.TabIndex = 0;
            generateIdeaBTN.Text = "button1";
            generateIdeaBTN.UseVisualStyleBackColor = true;
            // 
            // projectIdeaLB
            // 
            projectIdeaLB.AutoSize = true;
            projectIdeaLB.Location = new Point(341, 137);
            projectIdeaLB.Name = "projectIdeaLB";
            projectIdeaLB.Size = new Size(78, 32);
            projectIdeaLB.TabIndex = 1;
            projectIdeaLB.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(projectIdeaLB);
            Controls.Add(generateIdeaBTN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generateIdeaBTN;
        private Label projectIdeaLB;
    }
}
