using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace snake
{
    [Serializable]
    class Program
    {
        public static int level = 1;
        public static int direction = 0;
        public static int speed = 200;
        public static Snake snake = new Snake();
        public static Wall wall = new Wall(level);
        public static Food food = new Food();

        public static void Func()
        {
            while (true)
            {
                if (direction == 8)
                    snake.Move(0, -1);
                if (direction == 2)
                    snake.Move(0, 1);
                if (direction == 4)
                    snake.Move(-1, 0);
                if (direction == 6)
                    snake.Move(1, 0);

                if (snake.Eating(food))
                {
                    food.SetRandomPosition();
                }
                if (snake.Collision() || snake.WallCollision(wall))
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 10);
                    Console.WriteLine("GAME OVER!!!");
                    Console.ReadKey();
                    Console.Clear();
                    snake = new Snake();
                    wall = new Wall(level);
                }
                snake.Draw();
                wall.Draw();
                food.Draw();
                Thread.Sleep(speed);
            }
        
        }
       public static void F1(Snake snake)
        {
            BinaryFormatter bn = new BinaryFormatter();
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bn.Serialize(fs, snake);
            fs.Close();
        }
        static Snake F2()
        {
            BinaryFormatter bn = new BinaryFormatter();
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Snake snake = bn.Deserialize(fs) as Snake;
            fs.Close();
            return snake;
        }
        
        static void Main(string[] args)
        {
            Console.SetWindowSize(55, 25);
            Console.CursorVisible = false;

            ConsoleKeyInfo k2 = Console.ReadKey();
            Console.Clear();
            if(k2.Key == ConsoleKey.NumPad7)
            {
                snake = F2();
            }

            Thread tread = new Thread(Func);
            tread.Start();

            while (true)
            {
                ConsoleKeyInfo k = Console.ReadKey();
                if (k.Key == ConsoleKey.UpArrow && direction != 2)
                    direction = 8;
                if (k.Key == ConsoleKey.DownArrow && direction != 8)
                    direction = 2;
                if (k.Key == ConsoleKey.RightArrow && direction != 4)
                    direction = 6;
                if (k.Key == ConsoleKey.LeftArrow && direction != 6)
                    direction = 4;
                if (k.Key == ConsoleKey.S)
                    F1(snake);
            }
        }
    }
}
