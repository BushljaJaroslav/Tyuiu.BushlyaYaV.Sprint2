

using Tyuiu.BushlyaYaV.Sprint2.Task5.V5.Lib;

namespace Tyuiu.BushlyaYaV.Sprint2.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.FindCardValue(14), "туз");
        }
    }
}