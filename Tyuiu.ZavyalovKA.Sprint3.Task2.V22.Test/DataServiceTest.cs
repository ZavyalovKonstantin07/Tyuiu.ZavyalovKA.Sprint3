using Tyuiu.ZavyalovKA.Sprint3.Task2.V22.Lib;
namespace Tyuiu.ZavyalovKA.Sprint3.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 7;
            var res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0.125;
            Assert.AreEqual(wait, res);
        }
    }
}

                
                    

   

      
