namespace Snake
{
   public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       /* protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameArea = new System.Windows.Forms.GroupBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.Col = new System.Windows.Forms.Button();
            this.RecLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameArea
            // 
            this.GameArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameArea.Location = new System.Drawing.Point(9, 39);
            this.GameArea.Margin = new System.Windows.Forms.Padding(0);
            this.GameArea.Name = "GameArea";
            this.GameArea.Size = new System.Drawing.Size(500, 500);
            this.GameArea.TabIndex = 0;
            this.GameArea.TabStop = false;
            this.GameArea.Paint += new System.Windows.Forms.PaintEventHandler(this.GameArea_Paint);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.ScoreLabel.Location = new System.Drawing.Point(548, 66);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(121, 32);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "SCORE:";
            // 
            // RestartButton
            // 
            this.RestartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestartButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RestartButton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(559, 119);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(208, 198);
            this.RestartButton.TabIndex = 3;
            this.RestartButton.Text = "NEW GAME";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Col
            // 
            this.Col.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Col.AutoSize = false;
            this.Col.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Col.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Col.Location = new System.Drawing.Point(559, 353);
            this.Col.Name = "Col";
            this.Col.Size = new System.Drawing.Size(211, 182);
            this.Col.TabIndex = 6;
            this.Col.Text = "COLORS";
            this.Col.UseVisualStyleBackColor = false;
            this.Col.Click += new System.EventHandler(this.Col_Click);
            // 
            // RecLabel
            // 
            this.RecLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecLabel.AutoSize = true;
            this.RecLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecLabel.Location = new System.Drawing.Point(549, 37);
            this.RecLabel.Name = "RecLabel";
            this.RecLabel.Size = new System.Drawing.Size(204, 32);
            this.RecLabel.TabIndex = 7;
            this.RecLabel.Text = "HIGH SCORE:";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = false;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(841, 608);
            this.Controls.Add(this.RecLabel);
            this.Controls.Add(this.Col);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GameArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(50, 50);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(true);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GameArea;
        private System.Windows.Forms.Label ScoreLabel;
        public System.Windows.Forms.Button Col;
        public System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label RecLabel;
    }
}

