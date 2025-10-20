using Tyuiu.VegerinaVV.Sprint3.Task0.V27.Lib;

namespace Tyuiu.VegerinaVV.Sprint3.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 13;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 16.016;
            Assert.AreEqual(res, wait);
        }
    }
}
