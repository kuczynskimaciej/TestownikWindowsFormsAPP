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
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.A_Button = new System.Windows.Forms.Button();
            this.B_Button = new System.Windows.Forms.Button();
            this.C_Button = new System.Windows.Forms.Button();
            this.D_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.countOfRepetitionsOfQuestionLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(40, 433);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 50);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Powrót do MENU";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextBox.Location = new System.Drawing.Point(40, 30);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(800, 90);
            this.questionTextBox.TabIndex = 1;
            this.questionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Location = new System.Drawing.Point(640, 433);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(200, 50);
            this.nextQuestionButton.TabIndex = 2;
            this.nextQuestionButton.Text = "Następne pytanie";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // A_Button
            // 
            this.A_Button.Location = new System.Drawing.Point(40, 143);
            this.A_Button.Name = "A_Button";
            this.A_Button.Size = new System.Drawing.Size(392, 108);
            this.A_Button.TabIndex = 3;
            this.A_Button.UseVisualStyleBackColor = true;
            this.A_Button.Click += new System.EventHandler(this.A_Button_Click);
            // 
            // B_Button
            // 
            this.B_Button.Location = new System.Drawing.Point(448, 143);
            this.B_Button.Name = "B_Button";
            this.B_Button.Size = new System.Drawing.Size(392, 108);
            this.B_Button.TabIndex = 4;
            this.B_Button.UseVisualStyleBackColor = true;
            this.B_Button.Click += new System.EventHandler(this.B_Button_Click);
            // 
            // C_Button
            // 
            this.C_Button.Location = new System.Drawing.Point(40, 272);
            this.C_Button.Name = "C_Button";
            this.C_Button.Size = new System.Drawing.Size(392, 108);
            this.C_Button.TabIndex = 5;
            this.C_Button.UseVisualStyleBackColor = true;
            this.C_Button.Click += new System.EventHandler(this.C_Button_Click);
            // 
            // D_Button
            // 
            this.D_Button.Location = new System.Drawing.Point(448, 272);
            this.D_Button.Name = "D_Button";
            this.D_Button.Size = new System.Drawing.Size(392, 108);
            this.D_Button.TabIndex = 6;
            this.D_Button.UseVisualStyleBackColor = true;
            this.D_Button.Click += new System.EventHandler(this.D_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Liczba powtórzeń pytania:";
            // 
            // countOfRepetitionsOfQuestionLabel
            // 
            this.countOfRepetitionsOfQuestionLabel.AutoSize = true;
            this.countOfRepetitionsOfQuestionLabel.Location = new System.Drawing.Point(397, 433);
            this.countOfRepetitionsOfQuestionLabel.Name = "countOfRepetitionsOfQuestionLabel";
            this.countOfRepetitionsOfQuestionLabel.Size = new System.Drawing.Size(13, 13);
            this.countOfRepetitionsOfQuestionLabel.TabIndex = 8;
            this.countOfRepetitionsOfQuestionLabel.Text = "0";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(640, 433);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(200, 50);
            this.checkButton.TabIndex = 9;
            this.checkButton.Text = "Sprawdź";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.ResultLabel.Location = new System.Drawing.Point(513, 433);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 25);
            this.ResultLabel.TabIndex = 10;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 508);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.countOfRepetitionsOfQuestionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.D_Button);
            this.Controls.Add(this.C_Button);
            this.Controls.Add(this.B_Button);
            this.Controls.Add(this.A_Button);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Test";
            this.Text = "Pytanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Button A_Button;
        private System.Windows.Forms.Button B_Button;
        private System.Windows.Forms.Button C_Button;
        private System.Windows.Forms.Button D_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countOfRepetitionsOfQuestionLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}