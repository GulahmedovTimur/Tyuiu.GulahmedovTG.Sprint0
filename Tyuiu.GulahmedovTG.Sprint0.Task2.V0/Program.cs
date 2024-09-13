using System;
using Tyuiu.GulahmedovTG.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GulahmedovTG.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метод GetMessage
            //из библиотеки Tyuiu.GulahmedovTG.Sprint0.Task2.V0.lib
            Console.WriteLine(DataService.GetMessage("Игорь"));
            Console.ReadKey();

        }
    }
}
