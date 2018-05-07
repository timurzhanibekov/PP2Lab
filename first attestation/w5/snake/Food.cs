using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Food
    {
        public Point location;
        public char sign;
        public ConsoleColor color;
        //public static Snake a;
        public Food()
        {
            color = ConsoleColor.DarkRed;
            sign = '@';
            location = new Point(20, 10);
        }

        public void SetRandomPosition()
        {
             int x = new Random().Next(0, 55);
             int y = new Random().Next(0, 25);
             location = new Point(x, y);



            if (Collision())
            {
                SetRandomPosition();
            }
            
        }
        public bool Collision()
        {
            for (int i = 0; i < Program.wall.body.Count; i++)
                {
                    if(location.x == Program.wall.body[i].x && location.y == Program.wall.body[i].y)
                    {
                        return true ; 
                    } 
                }
            for (int i = 0; i < Program.snake.body.Count; i++)
            {
                if (location.x == Program.snake.body[i].x && location.y == Program.snake.body[i].y)
                {
                    return true;
                }
            }
            return false;
        } 
        
        
        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(location.x, location.y);
            Console.Write(sign);
        }

    }
    
}
