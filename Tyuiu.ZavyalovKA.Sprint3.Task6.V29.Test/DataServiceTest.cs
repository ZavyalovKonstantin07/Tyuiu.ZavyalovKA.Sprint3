using Tyuiu.ZavyalovKA.Sprint3.Task6.V29.Lib;
namespace Tyuiu.ZavyalovKA.Sprint3.Task6.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 12;
            int stopValue = 18;
            var res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 178;
            Assert.AreEqual(wait, res);
        }
    }
}
