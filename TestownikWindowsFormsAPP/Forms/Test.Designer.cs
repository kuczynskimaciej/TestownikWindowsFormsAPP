namespace TestownikWindowsFormsAPP
{
    partial class Test
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
            this.backButton = new System.Windows.Forms.Button();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.tossButton = new System.Windows.Forms.Button();
            this.FirstAnswerTextBox = new System.Windows.Forms.TextBox();
            this.SecoundAnswerTextBox = new System.Windows.Forms.TextBox();
            this.ThirdAnswerTextBox = new System.Windows.Forms.TextBox();
            this.FourthAnswerTextBox = new System.Windows.Forms.TextBox();
            this.FifthTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(40, 498);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 50);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Powrót do MENU";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.questionTextBox.Location = new System.Drawing.Point(40, 30);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(800, 90);
            this.questionTextBox.TabIndex = 1;
            this.questionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tossButton
            // 
            this.tossButton.Location = new System.Drawing.Point(640, 498);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(200, 50);
            this.tossButton.TabIndex = 2;
            this.tossButton.Text = "Losuj";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.TossButton_Click);
            // 
            // FirstAnswerTextBox
            // 
            this.FirstAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.FirstAnswerTextBox.Location = new System.Drawing.Point(164, 126);
            this.FirstAnswerTextBox.Multiline = true;
            this.FirstAnswerTextBox.Name = "FirstAnswerTextBox";
            this.FirstAnswerTextBox.ReadOnly = true;
            this.FirstAnswerTextBox.Size = new System.Drawing.Size(676, 64);
            this.FirstAnswerTextBox.TabIndex = 3;
            this.FirstAnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstAnswerTextBox.Visible = false;
            // 
            // SecoundAnswerTextBox
            // 
            this.SecoundAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.SecoundAnswerTextBox.Location = new System.Drawing.Point(164, 196);
            this.SecoundAnswerTextBox.Multiline = true;
            this.SecoundAnswerTextBox.Name = "SecoundAnswerTextBox";
            this.SecoundAnswerTextBox.ReadOnly = true;
            this.SecoundAnswerTextBox.Size = new System.Drawing.Size(676, 64);
            this.SecoundAnswerTextBox.TabIndex = 4;
            this.SecoundAnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SecoundAnswerTextBox.Visible = false;
            // 
            // ThirdAnswerTextBox
            // 
            this.ThirdAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.ThirdAnswerTextBox.Location = new System.Drawing.Point(164, 266);
            this.ThirdAnswerTextBox.Multiline = true;
            this.ThirdAnswerTextBox.Name = "ThirdAnswerTextBox";
            this.ThirdAnswerTextBox.ReadOnly = true;
            this.ThirdAnswerTextBox.Size = new System.Drawing.Size(676, 64);
            this.ThirdAnswerTextBox.TabIndex = 5;
            this.ThirdAnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThirdAnswerTextBox.Visible = false;
            // 
            // FourthAnswerTextBox
            // 
            this.FourthAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.FourthAnswerTextBox.Location = new System.Drawing.Point(164, 336);
            this.FourthAnswerTextBox.Multiline = true;
            this.FourthAnswerTextBox.Name = "FourthAnswerTextBox";
            this.FourthAnswerTextBox.ReadOnly = true;
            this.FourthAnswerTextBox.Size = new System.Drawing.Size(676, 64);
            this.FourthAnswerTextBox.TabIndex = 6;
            this.FourthAnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FourthAnswerTextBox.Visible = false;
            // 
            // FifthTextBox
            // 
            this.FifthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.FifthTextBox.Location = new System.Drawing.Point(164, 406);
            this.FifthTextBox.Multiline = true;
            this.FifthTextBox.Name = "FifthTextBox";
            this.FifthTextBox.ReadOnly = true;
            this.FifthTextBox.Size = new System.Drawing.Size(676, 64);
            this.FifthTextBox.TabIndex = 7;
            this.FifthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FifthTextBox.Visible = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 560);
            this.Controls.Add(this.FifthTextBox);
            this.Controls.Add(this.FourthAnswerTextBox);
            this.Controls.Add(this.ThirdAnswerTextBox);
            this.Controls.Add(this.SecoundAnswerTextBox);
            this.Controls.Add(this.FirstAnswerTextBox);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.TextBox FirstAnswerTextBox;
        private System.Windows.Forms.TextBox SecoundAnswerTextBox;
        private System.Windows.Forms.TextBox ThirdAnswerTextBox;
        private System.Windows.Forms.TextBox FourthAnswerTextBox;
        private System.Windows.Forms.TextBox FifthTextBox;
    }
}