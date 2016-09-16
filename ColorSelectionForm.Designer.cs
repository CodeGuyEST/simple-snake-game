namespace Snake
{
    partial class ColorSelectionForm
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
            this.Background = new System.Windows.Forms.Button();
            this.Snake = new System.Windows.Forms.Button();
            this.Food = new System.Windows.Forms.Button();
            this.backgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.snakeColorDialog = new System.Windows.Forms.ColorDialog();
            this.foodColorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.CausesValidation = false;
            this.Background.Font = new System.Drawing.Font("Segoe Print", 14F);
            this.Background.Location = new System.Drawing.Point(136, 50);
            this.Background.Margin = new System.Windows.Forms.Padding(0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(230, 96);
            this.Background.TabIndex = 0;
            this.Background.Text = "Background";
            this.Background.UseVisualStyleBackColor = true;
            this.Background.Click += new System.EventHandler(this.Background_Click);
            // 
            // Snake
            // 
            this.Snake.AutoSize = true;
            this.Snake.CausesValidation = false;
            this.Snake.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snake.Location = new System.Drawing.Point(135, 184);
            this.Snake.Margin = new System.Windows.Forms.Padding(0);
            this.Snake.Name = "Snake";
            this.Snake.Size = new System.Drawing.Size(230, 96);
            this.Snake.TabIndex = 1;
            this.Snake.Text = "Snake";
            this.Snake.UseVisualStyleBackColor = true;
            this.Snake.Click += new System.EventHandler(this.Snake_Click);
            // 
            // Food
            // 
            this.Food.AutoSize = true;
            this.Food.CausesValidation = false;
            this.Food.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food.Location = new System.Drawing.Point(135, 318);
            this.Food.Margin = new System.Windows.Forms.Padding(0);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(230, 96);
            this.Food.TabIndex = 2;
            this.Food.Text = "Food";
            this.Food.UseVisualStyleBackColor = true;
            this.Food.Click += new System.EventHandler(this.Food_Click);
            // 
            // ColorSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Snake);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Background;
        private System.Windows.Forms.Button Snake;
        private System.Windows.Forms.Button Food;
        private System.Windows.Forms.ColorDialog backgroundColorDialog;
        private System.Windows.Forms.ColorDialog snakeColorDialog;
        private System.Windows.Forms.ColorDialog foodColorDialog;
    }
}