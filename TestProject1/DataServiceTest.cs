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
            // ������� �������� ������� ������������, ������� �� ����������
            var name = "�����";
            var res = DataService.GetMessage(name);

            // �������� ����� Assert � ����� AreaEqual
            Assert.AreEqual("������..., �����", res);

        }
    }
}