using System;

namespace СS3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;
            int age;
            String color;
            String fear;
            String drink;
            Console.Write("Как вас зовут? ");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ваш любимый цвет? ");
            color = Console.ReadLine();
            Console.Write("Чего вы боитесь? ");
            fear = Console.ReadLine();
            Console.Write("Ваш любимый напиток? ");
            drink = Console.ReadLine();
            Console.WriteLine($"Вас зовут - {name}. Вам - {age} лет. Ваш любимый цвет - {color}. " +
                $"Вы боитесь - {fear}. Ваш любимый напиток - {drink}.");
        }
    }
}