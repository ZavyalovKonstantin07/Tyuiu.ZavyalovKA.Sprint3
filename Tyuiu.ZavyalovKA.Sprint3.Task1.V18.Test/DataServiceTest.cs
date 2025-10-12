using Tyuiu.ZavyalovKA.Sprint3.Task1.V18.Lib;
namespace Tyuiu.ZavyalovKA.Sprint3.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;
            var res = ds.GetSumSeries(startValue, stopValue);
            double wait = 1.121;
            Assert.AreEqual(wait, res);
        }
    }
}
