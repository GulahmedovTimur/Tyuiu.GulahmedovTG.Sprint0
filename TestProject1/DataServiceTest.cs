using System;
using Tyuiu.SprintTG.Sprint0.Task2.V0.Lib;
namespace TestProject1
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Игорь";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreaEqual
            Assert.AreEqual("Привет..., Игорь", res);

        }
    }
}