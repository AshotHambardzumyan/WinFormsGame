
namespace WindowsFormsApp1
{
    partial class GamePlay
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
            this.StartButton = new System.Windows.Forms.Button();
            this.PlayerButton1 = new System.Windows.Forms.Button();
            this.PlayerButton2 = new System.Windows.Forms.Button();
            this.PlayerButton3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(640, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(148, 62);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PlayerButton1
            // 
            this.PlayerButton1.Location = new System.Drawing.Point(640, 80);
            this.PlayerButton1.Name = "PlayerButton1";
            this.PlayerButton1.Size = new System.Drawing.Size(75, 66);
            this.PlayerButton1.TabIndex = 1;
            this.PlayerButton1.Text = "Player1";
            this.PlayerButton1.UseVisualStyleBackColor = true;
            // 
            // PlayerButton2
            // 
            this.PlayerButton2.Location = new System.Drawing.Point(640, 215);
            this.PlayerButton2.Name = "PlayerButton2";
            this.PlayerButton2.Size = new System.Drawing.Size(75, 68);
            this.PlayerButton2.TabIndex = 2;
            this.PlayerButton2.Text = "Player2";
            this.PlayerButton2.UseVisualStyleBackColor = true;
            // 
            // PlayerButton3
            // 
            this.PlayerButton3.Location = new System.Drawing.Point(640, 350);
            this.PlayerButton3.Name = "PlayerButton3";
            this.PlayerButton3.Size = new System.Drawing.Size(75, 68);
            this.PlayerButton3.TabIndex = 2;
            this.PlayerButton3.Text = "Player3";
            this.PlayerButton3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(721, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 66);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(721, 215);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 68);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(721, 350);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 68);
            this.textBox3.TabIndex = 3;
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.Location = new System.Drawing.Point(12, 12);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(148, 62);
            this.PlayAgainButton.TabIndex = 4;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PlayerButton3);
            this.Controls.Add(this.PlayerButton2);
            this.Controls.Add(this.PlayerButton1);
            this.Controls.Add(this.StartButton);
            this.Name = "GamePlay";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button PlayerButton1;
        private System.Windows.Forms.Button PlayerButton2;
        private System.Windows.Forms.Button PlayerButton3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button PlayAgainButton;
    }
}

