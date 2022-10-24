using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class car
    {
        public string model; 
        public int yearbuild;
        public const
            float MaxSpeed = 100;
        public int run;

        public bool startengine;

        public Vector3 Position;

        public car()
        {
            Position = new Vector3();
            model = "Неизвестно";
            yearbuild = 777;
            run = 8;
            startengine = false;
        }
        public car(string Model,Vector3 position)
        {
            Position = position;
            model = Model;
            yearbuild = DateTime.Today.Year;
            run = 8;
            startengine = false;
        }
        public void Start()
        {
            Console.WriteLine($"Машина {model} включилась");
            startengine = true;
        }
        public void Off()
        {
            Console.WriteLine($"Машина {model} выключилась");
            startengine = false;
        }
        public void Move(Vector3 vector)
        {
            if (!startengine)
                return;

            Position.X += vector.X;
            Position.Y += vector.Y;
            Position.Z += vector.Z;
            run++;
            Console.WriteLine($"Машина {model}  передвинулась на Позиция = X:{Position.X}X:{Position.Y}X: {Position.Z}");

        }
        public string GetInfo() => $"Тачка{model}. {yearbuild}  года выпуска. Двигатель{startengine}.  Позиция = X:{Position.X}X:{Position.Y}X: {Position.Z}";
    }
}
