using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class ColorSelectionForm : Form
    {
        public ColorSelectionForm()
        {
            InitializeComponent();
            Background.BackColor = MainForm.emptyBrush.Color;
            Snake.BackColor = MainForm.snakeBrush.Color;
            Food.BackColor = MainForm.foodBrush.Color;
            if (Background.BackColor.B < 20 & Background.BackColor.G < 20 && Background.BackColor.R < 20)
            {
                Background.ForeColor = Color.White;
            }
            if (Snake.BackColor.B < 20 & Snake.BackColor.G < 20 && Snake.BackColor.R < 20)
            {
                Snake.ForeColor = Color.White;
            }
            if (Food.BackColor.B < 20 & Food.BackColor.G < 20 && Food.BackColor.R < 20)
            {
                Food.ForeColor = Color.White;
            }

            Properties.Settings.Default.Reload();
        }

        private void Background_Click(object sender, EventArgs e)
        {
            if (backgroundColorDialog.ShowDialog() == DialogResult.OK)
            {
                MainForm.emptyBrush.Color = backgroundColorDialog.Color;
                Background.BackColor = MainForm.emptyBrush.Color;
                if (Background.BackColor.B < 30 & Background.BackColor.G < 30 && Background.BackColor.R < 30)
                {
                    Background.ForeColor = Color.White;
                }

                Properties.Settings.Default.BackgroundCol = Background.BackColor;

                Properties.Settings.Default.Save();
            }

        }

        private void Snake_Click(object sender, EventArgs e)
        {
            if (snakeColorDialog.ShowDialog() == DialogResult.OK)
            {
                MainForm.snakeBrush.Color = snakeColorDialog.Color;
                Snake.BackColor = MainForm.snakeBrush.Color;
                if (Snake.BackColor.B < 30 & Snake.BackColor.G < 30 && Snake.BackColor.R < 30)
                {
                    Snake.ForeColor = Color.White;
                }

                Properties.Settings.Default.SnakeCol = Snake.BackColor;
                Properties.Settings.Default.Save();
            }
        }

        private void Food_Click(object sender, EventArgs e)
        {
            if (foodColorDialog.ShowDialog() == DialogResult.OK)
            {   
                MainForm.foodBrush.Color = foodColorDialog.Color;
                Food.BackColor = MainForm.foodBrush.Color;
                if (Food.BackColor.B < 30 & Food.BackColor.G < 30 && Food.BackColor.R < 30)
                {
                    Food.ForeColor = Color.White;
                }

                Properties.Settings.Default.FoodCol = Food.BackColor;
                Properties.Settings.Default.Save();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.mainForm.Enabled = true;
            MainForm.mainForm.Visible = true;
        }
    }
}
