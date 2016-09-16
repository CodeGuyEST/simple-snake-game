using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class GameSnake
    {
        public static readonly int Width = (int)(1.0 / 50 * MainForm.WIDTH);
        public static readonly int Height = (int)(1.0 / 50 * MainForm.HEIGHT);
        private Direction dir;
        public Rectangle Head;
        public List<Rectangle> snakeList;
        public Rectangle Tail;

        public Direction Dir
        {
            get { return dir; }
            set { dir = value; }
        }

        public GameSnake()
        {
            dir = Direction.Up;
            snakeList = new List<Rectangle>();
        }

        public Direction GetDirection() { return dir;}

        public void InitSnake()
        {
            dir = Direction.Up;
            snakeList.Clear();
            Head = new Rectangle(MainForm.WIDTH / 2 - Width, MainForm.HEIGHT - Height, Width, Height);
            snakeList.Add(Head);
            Tail = snakeList[snakeList.Count() - 1];
        }

        public void Move()
        {

            switch (dir)
            {
                case Direction.Up:
                    Rectangle newHead = new Rectangle(Head.X, Head.Y - Height, Width, Height);
                    snakeList.Insert(0, newHead);
                    Head = snakeList[0];
                    snakeList.RemoveAt(snakeList.Count() - 1);
                    break;

                case Direction.Down:
                    Rectangle newHead2 = new Rectangle(Head.X, Head.Y + Height, Width, Height);
                    snakeList.Insert(0, newHead2);
                    Head = snakeList[0];
                    snakeList.RemoveAt(snakeList.Count() - 1);
                    break;

                case Direction.Left:
                    Rectangle newHead3 = new Rectangle(Head.X - Width, Head.Y, Width, Height);
                    snakeList.Insert(0, newHead3);
                    Head = snakeList[0];
                    snakeList.RemoveAt(snakeList.Count() - 1);
                    break;

                case Direction.Right:
                    Rectangle newHead4 = new Rectangle(Head.X + Width, Head.Y, Width, Height);
                    snakeList.Insert(0, newHead4);
                    Head = snakeList[0];
                    snakeList.RemoveAt(snakeList.Count() - 1);
                    break;
            }
            Tail = snakeList[snakeList.Count() - 1];
        }

        public void Grow()
        {
            Rectangle Tail = snakeList[snakeList.Count() - 1];
            switch (dir)
            {
                case Direction.Up:
                    snakeList.Add(new Rectangle(Tail.X, Tail.Y + Height, Width, Height));
                    break;

                case Direction.Down:
                    snakeList.Add(new Rectangle(Tail.X, Tail.Y - Height, Width, Height));
                    break;

                case Direction.Left:
                    snakeList.Add(new Rectangle(Tail.X - Width, Tail.Y, Width, Height));
                    break;

                case Direction.Right:
                    snakeList.Add(new Rectangle(Tail.X + Width, Tail.Y + Height, Width, Height));
                    break;
            }

        }


        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

    }
}

