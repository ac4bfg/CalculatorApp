using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculatorMachine;

namespace CaclulatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Versi Console";

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); 

            Console.Write("Inputkan nilai b = ");
            var b = Convert.ToInt32(Console.ReadLine());

            var cal = new Calculator();

            Console.WriteLine();

            Console.Title = "Aplikasi Calculator Versi Console";
            Console.WriteLine("Hasil Penambahan: " + a + " + " + b + " = " + cal.Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, cal.Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian: {0} * {1} = {2}", a, b, cal.Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b));
            Console.WriteLine("Hasil Pangkat: {0} ^ {1} = {2}", a, b, cal.Pangkat(a, b));
            Console.WriteLine("Hasil Module: {0} % {1} = {2}", a, b, cal.Modulo(a, b));

            Console.WriteLine("\nTekan ENTER untuk keluar");
            Console.ReadKey();
        }
    }
}
