namespace WindowsUI
{
    partial class NumberGuesser
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
            this.label1 = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number between 1 and 100";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(330, 153);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(100, 20);
            this.guessTextBox.TabIndex = 1;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(342, 200);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(436, 379);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(260, 379);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(75, 23);
            this.mainButton.TabIndex = 4;
            this.mainButton.Text = "Main Menu";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(330, 247);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(106, 42);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "New Number";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // NumberGuesser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NumberGuesser";
            this.Text = "NumberGuesser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button newButton;
    }
}