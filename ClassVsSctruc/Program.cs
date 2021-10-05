using System;

namespace ClassVsSctruc
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1, p2;

            p1 = new Player() {Health = 21.2f, Armor = 53.4f};
            p2 = p1;

            Console.WriteLine("Valores Inicias:");
            Console.WriteLine($"\tP1: Vida = {p1.Health}, Armor = {p1.Armor}");
            Console.WriteLine($"\tP2: Vida = {p2.Health}, Armor = {p2.Armor}");

            p1.Health = 0; 
            p1.Armor = 5;

            Console.WriteLine("Valores Finais:");
            Console.WriteLine($"\tP1: Vida = {p1.Health}, Armor = {p1.Armor}");
            Console.WriteLine($"\tP2: Vida = {p2.Health}, Armor = {p2.Armor}");
        }
    }
}
