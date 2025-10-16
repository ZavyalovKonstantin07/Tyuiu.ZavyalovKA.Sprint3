using Tyuiu.ZavyalovKA.Sprint3.Task3.V7.Lib;
namespace Tyuiu.ZavyalovKA.Sprint3.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();
            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '4';
            var res = ds.ReplaceCharOnNum(value, replaceable, replacement);
            string wait = "4ft h44t nt4";
            Assert.AreEqual(wait, res);
        }
    }
}
