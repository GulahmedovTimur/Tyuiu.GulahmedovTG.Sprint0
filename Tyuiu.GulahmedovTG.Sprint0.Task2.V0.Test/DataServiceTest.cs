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
            // ������� �������� ������� ������������, ������� �� ����������
            var name = "�����";
            var res = DataService.GetMessage(name);
        }
    }
}