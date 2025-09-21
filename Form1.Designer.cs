namespace TicTacToeGameDesktop
{
    partial class Form1
    {
        // container of input players 
        private char[] arr = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };




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
            this.label2 = new System.Windows.Forms.Label();
            this.labTurn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labWinner = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(374, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(98, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn";
            // 
            // labTurn
            // 
            this.labTurn.AutoSize = true;
            this.labTurn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labTurn.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTurn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labTurn.Location = new System.Drawing.Point(66, 248);
            this.labTurn.Name = "labTurn";
            this.labTurn.Size = new System.Drawing.Size(168, 38);
            this.labTurn.TabIndex = 2;
            this.labTurn.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(78, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Winner";
            // 
            // labWinner
            // 
            this.labWinner.AutoSize = true;
            this.labWinner.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labWinner.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labWinner.Location = new System.Drawing.Point(36, 391);
            this.labWinner.Name = "labWinner";
            this.labWinner.Size = new System.Drawing.Size(229, 38);
            this.labWinner.TabIndex = 4;
            this.labWinner.Text = "In Progress";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRestartGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRestartGame.Location = new System.Drawing.Point(42, 482);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(216, 63);
            this.btnRestartGame.TabIndex = 5;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TicTacToeGameDesktop.Properties.Resources.question_mark_96;
            this.button1.Location = new System.Drawing.Point(365, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 138);
            this.button1.TabIndex = 15;
            this.button1.Tag = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::TicTacToeGameDesktop.Properties.Resources.question_mark_96;
            this.button2.Location = new System.Drawing.Point(575, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 138);
            this.button2.TabIndex = 16;
            this.button2.Tag = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::TicTacToeGameDesktop.Properties.Resources.question_mark_96;
            this.button3.Location = new System.Drawing.Point(779, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 138);
            this.button3.TabIndex = 17;
            this.button3.Tag = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::TicTacToeGameDesktop.Properties.Resources.question_mark_96;
            this.button4.Location = new System.Drawing.Point(365, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 138);
            this.button4.TabIndex = 18;
            this.button4.Tag = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::TicTacToeGameDesktop.Properties.Resources.question_mark_96;
            this.button7.Location = new System.Drawing.Point(365, 494);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 138);
            this.button7.TabIndex = 19;
            this.button7.Tag = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::TicTacToeGameDesktop.Properties.Resources.question_mark_96;
            this.button5.Location = new System.Drawing.Point(563, 293);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 138);
            this.button5.TabIndex = 20;
            this.button5.Tag = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::TicTacToeGameDesktop.Properties.Resources.question_mark_96;
            this.button6.Location = new System.Drawing.Point(779, 293);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 138);
            this.button6.TabIndex = 21;
            this.button6.Tag = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::TicTacToeGameDesktop.Properties.Resources.question_mark_96;
            this.button8.Location = new System.Drawing.Point(575, 494);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 138);
            this.button8.TabIndex = 22;
            this.button8.Tag = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::TicTacToeGameDesktop.Properties.Resources.question_mark_96;
            this.button9.Location = new System.Drawing.Point(779, 494);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(137, 138);
            this.button9.TabIndex = 23;
            this.button9.Tag = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1055, 668);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.labWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labTurn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labWinner;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

