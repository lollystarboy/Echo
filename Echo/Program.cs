﻿namespace Echo
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("Напишите что-то");
                var str = Console.ReadLine();

                Console.WriteLine("Укажите глубину эха");
                var deep = int.Parse(Console.ReadLine());

                Echo(str, deep);

                Console.ReadKey();
            }
            static void Echo(string saidworld, int deep)
            {
                var modif = saidworld;
                Console.WriteLine("..."+ modif);

                if (modif.Length > 2)
                {
                    modif = modif.Remove(0, 2);
                }
                if (deep > 1)
                { Echo(modif, deep - 1); }
            }
        
    }
}
