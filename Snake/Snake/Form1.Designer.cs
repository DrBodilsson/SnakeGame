namespace Snake
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
            this.components = new System.ComponentModel.Container();
            this.pb_snakeGame = new System.Windows.Forms.PictureBox();
            this.lbl_titleScore = new System.Windows.Forms.Label();
            this.lbl_userScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_GameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_snakeGame)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_snakeGame
            // 
            this.pb_snakeGame.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pb_snakeGame.Location = new System.Drawing.Point(13, 13);
            this.pb_snakeGame.Name = "pb_snakeGame";
            this.pb_snakeGame.Size = new System.Drawing.Size(541, 560);
            this.pb_snakeGame.TabIndex = 0;
            this.pb_snakeGame.TabStop = false;
            this.pb_snakeGame.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // lbl_titleScore
            // 
            this.lbl_titleScore.AutoSize = true;
            this.lbl_titleScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleScore.Location = new System.Drawing.Point(654, 30);
            this.lbl_titleScore.Name = "lbl_titleScore";
            this.lbl_titleScore.Size = new System.Drawing.Size(87, 24);
            this.lbl_titleScore.TabIndex = 1;
            this.lbl_titleScore.Text = "SCORE:";
            // 
            // lbl_userScore
            // 
            this.lbl_userScore.AutoSize = true;
            this.lbl_userScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userScore.Location = new System.Drawing.Point(826, 30);
            this.lbl_userScore.Name = "lbl_userScore";
            this.lbl_userScore.Size = new System.Drawing.Size(60, 24);
            this.lbl_userScore.TabIndex = 2;
            this.lbl_userScore.Text = "label2";
            this.lbl_userScore.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_GameOver
            // 
            this.lbl_GameOver.AutoSize = true;
            this.lbl_GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameOver.Location = new System.Drawing.Point(667, 195);
            this.lbl_GameOver.Name = "lbl_GameOver";
            this.lbl_GameOver.Size = new System.Drawing.Size(60, 24);
            this.lbl_GameOver.TabIndex = 3;
            this.lbl_GameOver.Text = "label2";
            this.lbl_GameOver.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 591);
            this.Controls.Add(this.lbl_GameOver);
            this.Controls.Add(this.lbl_userScore);
            this.Controls.Add(this.lbl_titleScore);
            this.Controls.Add(this.pb_snakeGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_snakeGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_snakeGame;
        private System.Windows.Forms.Label lbl_titleScore;
        private System.Windows.Forms.Label lbl_userScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lbl_GameOver;
    }
}

