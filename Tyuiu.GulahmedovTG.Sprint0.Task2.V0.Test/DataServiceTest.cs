namespace Tyuiu.GulahmedovTG.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Игорь";
            var res = DataService.GetMessage(name);
        }
    }
}