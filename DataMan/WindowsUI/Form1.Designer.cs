
namespace WindowsUI
{
    partial class Form1
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
            this.int1TextBox = new System.Windows.Forms.TextBox();
            this.int2TextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.dividButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.multiplyLabel = new System.Windows.Forms.Label();
            this.divideLabel = new System.Windows.Forms.Label();
            this.equalLabel = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.answLabel = new System.Windows.Forms.Label();
            this.firstIntLabel = new System.Windows.Forms.Label();
            this.secIntLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // int1TextBox
            // 
            this.int1TextBox.Location = new System.Drawing.Point(153, 79);
            this.int1TextBox.Name = "int1TextBox";
            this.int1TextBox.Size = new System.Drawing.Size(100, 20);
            this.int1TextBox.TabIndex = 0;
            // 
            // int2TextBox
            // 
            this.int2TextBox.Location = new System.Drawing.Point(323, 80);
            this.int2TextBox.Name = "int2TextBox";
            this.int2TextBox.Size = new System.Drawing.Size(100, 20);
            this.int2TextBox.TabIndex = 1;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(544, 80);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 20);
            this.answerTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(153, 225);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(291, 224);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(75, 23);
            this.subButton.TabIndex = 4;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // multButton
            // 
            this.multButton.Location = new System.Drawing.Point(429, 224);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(75, 23);
            this.multButton.TabIndex = 5;
            this.multButton.Text = "x";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.multButton_Click);
            // 
            // dividButton
            // 
            this.dividButton.Location = new System.Drawing.Point(544, 224);
            this.dividButton.Name = "dividButton";
            this.dividButton.Size = new System.Drawing.Size(75, 23);
            this.dividButton.TabIndex = 6;
            this.dividButton.Text = "/";
            this.dividButton.UseVisualStyleBackColor = true;
            this.dividButton.Click += new System.EventHandler(this.dividButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(358, 369);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(178, 187);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(26, 13);
            this.addLabel.TabIndex = 8;
            this.addLabel.Text = "Add";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Location = new System.Drawing.Point(304, 186);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(47, 13);
            this.subLabel.TabIndex = 9;
            this.subLabel.Text = "Subtract";
            // 
            // multiplyLabel
            // 
            this.multiplyLabel.AutoSize = true;
            this.multiplyLabel.Location = new System.Drawing.Point(440, 186);
            this.multiplyLabel.Name = "multiplyLabel";
            this.multiplyLabel.Size = new System.Drawing.Size(42, 13);
            this.multiplyLabel.TabIndex = 10;
            this.multiplyLabel.Text = "Multiply";
            // 
            // divideLabel
            // 
            this.divideLabel.AutoSize = true;
            this.divideLabel.Location = new System.Drawing.Point(563, 186);
            this.divideLabel.Name = "divideLabel";
            this.divideLabel.Size = new System.Drawing.Size(37, 13);
            this.divideLabel.TabIndex = 11;
            this.divideLabel.Text = "Divide";
            // 
            // equalLabel
            // 
            this.equalLabel.AutoSize = true;
            this.equalLabel.Location = new System.Drawing.Point(491, 86);
            this.equalLabel.Name = "equalLabel";
            this.equalLabel.Size = new System.Drawing.Size(13, 13);
            this.equalLabel.TabIndex = 12;
            this.equalLabel.Text = "=";
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(344, 144);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(99, 13);
            this.chooseLabel.TabIndex = 13;
            this.chooseLabel.Text = "Chose an operation";
            // 
            // answLabel
            // 
            this.answLabel.AutoSize = true;
            this.answLabel.Location = new System.Drawing.Point(541, 36);
            this.answLabel.Name = "answLabel";
            this.answLabel.Size = new System.Drawing.Size(92, 13);
            this.answLabel.TabIndex = 14;
            this.answLabel.Text = "Enter your answer";
            // 
            // firstIntLabel
            // 
            this.firstIntLabel.AutoSize = true;
            this.firstIntLabel.Location = new System.Drawing.Point(150, 36);
            this.firstIntLabel.Name = "firstIntLabel";
            this.firstIntLabel.Size = new System.Drawing.Size(86, 13);
            this.firstIntLabel.TabIndex = 15;
            this.firstIntLabel.Text = "Enter first integer";
            // 
            // secIntLabel
            // 
            this.secIntLabel.AutoSize = true;
            this.secIntLabel.Location = new System.Drawing.Point(320, 36);
            this.secIntLabel.Name = "secIntLabel";
            this.secIntLabel.Size = new System.Drawing.Size(105, 13);
            this.secIntLabel.TabIndex = 16;
            this.secIntLabel.Text = "Enter second integer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secIntLabel);
            this.Controls.Add(this.firstIntLabel);
            this.Controls.Add(this.answLabel);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.equalLabel);
            this.Controls.Add(this.divideLabel);
            this.Controls.Add(this.multiplyLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dividButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.int2TextBox);
            this.Controls.Add(this.int1TextBox);
            this.Name = "Form1";
            this.Text = "Answer Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox int1TextBox;
        private System.Windows.Forms.TextBox int2TextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button dividButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label multiplyLabel;
        private System.Windows.Forms.Label divideLabel;
        private System.Windows.Forms.Label equalLabel;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Label answLabel;
        private System.Windows.Forms.Label firstIntLabel;
        private System.Windows.Forms.Label secIntLabel;
    }
}

