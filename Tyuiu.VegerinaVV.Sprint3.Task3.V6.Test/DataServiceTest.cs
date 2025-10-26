using Tyuiu.VegerinaVV.Sprint3.Task3.V6.Lib;

namespace Tyuiu.VegerinaVV.Sprint3.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string str = "2as4e 5his 1ea";
            char item = 't';

            string res = ds.ReplaceNumOnChar(str, item);

            string wait = "taste this tea";

            Assert.AreEqual(wait, res);

        }
    }
}
