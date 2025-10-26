using Tyuiu.ZavyalovKA.Sprint3.Task4.V5.Lib;
namespace Tyuiu.ZavyalovKA.Sprint3.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            var res = ds.Calculate(startValue, stopValue);
            double wait = 0.104;
            Assert.AreEqual(wait, res);
        }
    }
}
