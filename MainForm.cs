using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

namespace Snake
{
    public partial class MainForm : Form
    {
        public static int WIDTH;
        public static int HEIGHT;
        private Graphics gra;
        private bool keepGoing = true;
        private Rectangle food;
        public static readonly SolidBrush emptyBrush = new SolidBrush(Properties.Settings.Default.BackgroundCol);
        public static readonly SolidBrush snakeBrush = new SolidBrush(Properties.Settings.Default.SnakeCol);
        public static readonly SolidBrush foodBrush = new SolidBrush(Properties.Settings.Default.FoodCol);
        private int score;
        GameSnake snake;
        public static MainForm mainForm;  


        public MainForm()
        {
            InitializeComponent();
            Keyboard.DefaultRestoreFocusMode = RestoreFocusMode.Auto;
            WIDTH = GameArea.ClientSize.Width;
            HEIGHT = GameArea.ClientSize.Height;
            score = 0;
            snake = new GameSnake();
            mainForm = this;
            RecLabel.Text = "HIGH SCORE: " + Properties.Settings.Default.HighScore.ToString();
            ScoreLabel.Text = "SCORE: 0";
        }

        private void UpdateScore()
        {
            ScoreLabel.Text = "SCORE: " + score.ToString();
            RecLabel.Text = "HIGH SCORE: " +  Properties.Settings.Default.HighScore.ToString();
        }
       
        private void NewGame()
        {
            UpdateScore();
            keepGoing = false;   
            RestartButton.Visible = true;
            RestartButton.Enabled = true;
            Col.Visible = true;
            Col.Enabled = true;
            if (Properties.Settings.Default.HighScore < score)
            {
                Properties.Settings.Default.HighScore = score;
                Properties.Settings.Default.Save();
            }

            RecLabel.Text = "HIGH SCORE: " + Properties.Settings.Default.HighScore.ToString();
        }


        private void GameArea_Paint(object sender, PaintEventArgs pe)
        {
            gra = GameArea.CreateGraphics();
            Properties.Settings.Default.Reload();
        }


       private void InputCheck ()
        {
                if ((Keyboard.IsKeyDown(Key.Up) || Keyboard.IsKeyDown(Key.W)) 
                && (snake.Dir != GameSnake.Direction.Down || 
                snake.snakeList.Count() <= 1))
                {   
                    snake.Dir = GameSnake.Direction.Up;

                }

                else if ((Keyboard.IsKeyDown(Key.Down) || Keyboard.IsKeyDown(Key.S)) 
                && (snake.Dir != GameSnake.Direction.Up || 
                snake.snakeList.Count() <= 1))
                {
                    snake.Dir = GameSnake.Direction.Down;

                }

                else if ((Keyboard.IsKeyDown(Key.Left) || Keyboard.IsKeyDown(Key.A)) 
                && (snake.Dir != GameSnake.Direction.Right 
                || snake.snakeList.Count() <= 1))
                {
                    snake.Dir = GameSnake.Direction.Left;

                }

                else if ((Keyboard.IsKeyDown(Key.Right) || Keyboard.IsKeyDown(Key.D)) 
                && (snake.Dir != GameSnake.Direction.Left 
                || snake.snakeList.Count() <= 1))
                {
                    snake.Dir = GameSnake.Direction.Right;

                }
            
       }

       private void MainForm_FormClosing(object sender,FormClosingEventArgs e)
       {
           keepGoing = false;
           Application.Exit();

       }

       private void Draw(GameSnake snake)
       {
            foreach (Rectangle cell in snake.snakeList)
            {
                gra.FillRectangle(snakeBrush, cell);
            }

            gra.FillRectangle(foodBrush, food);
            Thread.Sleep(60);
            gra.FillRectangle(emptyBrush, snake.Tail);
        }

       private void UpdateGame() {

               if (snake.Head.Y < 0 || snake.Head.Y > HEIGHT || 
                snake.Head.X < 0 || snake.Head.X > WIDTH) NewGame();
               
               if (snake.snakeList.Count() > 1)
               {
                   for (int i = 1; i < snake.snakeList.Count(); i++)
                   {
                       if (snake.Head == snake.snakeList[i]) NewGame();
                   }
               }

               if (snake.Head.Y == food.Y && snake.Head.X == food.X)
               {
                   SetFruit();
                   snake.Grow();
                   score++;
                   CheckRecord(); 
               }
           InputCheck();
           snake.Move();
           UpdateScore();
       }

       private void CheckRecord()
        {
            if (Properties.Settings.Default.HighScore < score)
            {
                Properties.Settings.Default.HighScore = score;
                Properties.Settings.Default.Save();
            }
        }

       private void SetFruit()
       {
           Random rand = new Random();
           List<Rectangle> foodList = new List<Rectangle>();
           bool canAdd = true;

           for (int x = 0; x < WIDTH; x += (int)WIDTH / GameSnake.Width)
           {
               for (int y = 0; y < HEIGHT; y += (int)HEIGHT / GameSnake.Height)
               {
                   canAdd = true;
                   foreach (Rectangle rect in snake.snakeList)
                   {
                       if (x == rect.X && y == rect.Y)
                       {
                           canAdd = false;
                           break;
                       }

                   }

                   if (canAdd)
                   {
                       foodList.Add(new Rectangle(x, y, GameSnake.Width, GameSnake.Height));
                   }
               }
           }

           if (foodList.Count() == 0)
           {
               NewGame();
           }

           else
           {

               food = foodList[rand.Next(foodList.Count)];
           }


       }

       private void Init()
       {
           RestartButton.Visible = false;
           RestartButton.Enabled = false;
           keepGoing = true;
           snake.InitSnake();
           score = 0;
           SetFruit();
           gra.FillRectangle(emptyBrush, new Rectangle(0, 0, WIDTH, HEIGHT));
           while (keepGoing)
           {
               Draw(snake);
               UpdateGame();
               Application.DoEvents();
           }
       }

       private void RestartButton_Click(object sender, EventArgs e)
       {
            score = 0;
            Col.Visible = false;
            Col.Enabled = false;
            Init();

       }

       private void Col_Click(object sender, EventArgs e)
       {   
           this.Visible = false;
           this.Enabled = false;
           ColorSelectionForm colorForm = new ColorSelectionForm();
           colorForm.Show();
       }

     }
 }
