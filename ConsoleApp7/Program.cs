using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector3 vector = new Vector3(1, 2, 3);
            car bmw = new car("BMW", vector);
            car audi = new car("AUDI", vector);
            bmw.Start();

            bmw.Move(new Vector3(0, 4, 5));
            Console.WriteLine(bmw.GetInfo());
            bmw.Move(new Vector3(0, 4, 5));
            Console.WriteLine(bmw.GetInfo());
           
            bmw.Move(new Vector3(0, 4, 5));
            Console.WriteLine(bmw.GetInfo());
            bmw.Move(new Vector3(0, 4, 5));
            Console.WriteLine(bmw.GetInfo());
            bmw.Off();

            audi.Start();
            audi.Move(new Vector3(2,3,5));
            Console.WriteLine(audi.GetInfo());
            audi.Move(new Vector3(2, 3, 5));
            Console.WriteLine(audi.GetInfo());
            audi.Move(new Vector3(2, 3, 5));
            Console.WriteLine(audi.GetInfo());
            audi.Off();
        }
    }
}
