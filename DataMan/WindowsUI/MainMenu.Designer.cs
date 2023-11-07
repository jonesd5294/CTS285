namespace WindowsUI
{
    partial class MainMenu
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
            this.answerCheckerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.numGuessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerCheckerButton
            // 
            this.answerCheckerButton.Location = new System.Drawing.Point(217, 302);
            this.answerCheckerButton.Name = "answerCheckerButton";
            this.answerCheckerButton.Size = new System.Drawing.Size(97, 37);
            this.answerCheckerButton.TabIndex = 0;
            this.answerCheckerButton.Text = "AnswerChecker";
            this.answerCheckerButton.UseVisualStyleBackColor = true;
            this.answerCheckerButton.Click += new System.EventHandler(this.answerCheckerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(307, 361);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(106, 37);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // numGuessButton
            // 
            this.numGuessButton.Location = new System.Drawing.Point(436, 302);
            this.numGuessButton.Name = "numGuessButton";
            this.numGuessButton.Size = new System.Drawing.Size(93, 37);
            this.numGuessButton.TabIndex = 2;
            this.numGuessButton.Text = "Number Guesser";
            this.numGuessButton.UseVisualStyleBackColor = true;
            this.numGuessButton.Click += new System.EventHandler(this.numGuessButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numGuessButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.answerCheckerButton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button answerCheckerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button numGuessButton;
    }
}