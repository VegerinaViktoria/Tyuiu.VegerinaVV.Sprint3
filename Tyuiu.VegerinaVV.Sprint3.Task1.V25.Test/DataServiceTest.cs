using Tyuiu.VegerinaVV.Sprint3.Task1.V25.Lib;

namespace Tyuiu.VegerinaVV.Sprint3.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultSeries()
        {
            DataService ds = new DataService();

            int value = 2;
            int startValue = 1;
            int stopValue = 6;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 844.664;

            Assert.AreEqual(wait, res);
        }
    }
}
