namespace AdventureGame
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
            this.optionOne = new System.Windows.Forms.Button();
            this.optionTwo = new System.Windows.Forms.Button();
            this.optionThree = new System.Windows.Forms.Button();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // optionOne
            // 
            this.optionOne.Location = new System.Drawing.Point(120, 301);
            this.optionOne.Name = "optionOne";
            this.optionOne.Size = new System.Drawing.Size(530, 43);
            this.optionOne.TabIndex = 0;
            this.optionOne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionOne.UseVisualStyleBackColor = true;
            this.optionOne.Visible = false;
            this.optionOne.Click += new System.EventHandler(this.optionOne_Click);
            // 
            // optionTwo
            // 
            this.optionTwo.Location = new System.Drawing.Point(120, 350);
            this.optionTwo.Name = "optionTwo";
            this.optionTwo.Size = new System.Drawing.Size(530, 43);
            this.optionTwo.TabIndex = 1;
            this.optionTwo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionTwo.UseVisualStyleBackColor = true;
            this.optionTwo.Visible = false;
            this.optionTwo.Click += new System.EventHandler(this.optionTwo_Click);
            // 
            // optionThree
            // 
            this.optionThree.Location = new System.Drawing.Point(120, 399);
            this.optionThree.Name = "optionThree";
            this.optionThree.Size = new System.Drawing.Size(530, 43);
            this.optionThree.TabIndex = 2;
            this.optionThree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionThree.UseVisualStyleBackColor = true;
            this.optionThree.Visible = false;
            this.optionThree.Click += new System.EventHandler(this.optionThree_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(242, 273);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(296, 22);
            this.usernameInput.TabIndex = 3;
            // 
            // mainLabel
            // 
            this.mainLabel.Location = new System.Drawing.Point(92, 22);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(602, 66);
            this.mainLabel.TabIndex = 4;
            this.mainLabel.Text = "Enter Username";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(330, 301);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(115, 43);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Enter";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 350);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(100, 80);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "Score:";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(169, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(226, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 104);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.optionThree);
            this.Controls.Add(this.optionTwo);
            this.Controls.Add(this.optionOne);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button optionOne;
        private System.Windows.Forms.Button optionTwo;
        private System.Windows.Forms.Button optionThree;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

