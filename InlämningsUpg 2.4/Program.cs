using System;
namespace InlämningsUpg_2._4
{
     class Program
    {
        static void Main(string[] args)
        {
            //Lön för den första//
            Console.WriteLine("Skriv in lönen för den första anställda: ");
            double tal1= double.Parse(Console.ReadLine());
            //Lön för den andra//
            Console.WriteLine("Skriv in lönen för den andra  anställda: ");
            double tal2= double.Parse(Console.ReadLine());
            //Lön för den tredje//
            Console.WriteLine("skriv in lönen för den tredje anställda");
            double tal3= double.Parse(Console.ReadLine());
            //Räknar ur medellönen//
            double medellön = (tal1 + tal2+tal3) / 3;

            Console.WriteLine("medellönen är: " +medellön);
        }
    }
}
