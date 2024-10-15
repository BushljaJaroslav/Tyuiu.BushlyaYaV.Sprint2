
using Tyuiu.BushlyaYaV.Sprint2.Task3.V21.Lib;

namespace Tyuiu.BushlyaYaV.Sprint2.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(242.0, ds.Calculate(2));
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.833, ds.Calculate(0));
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.5, ds.Calculate(-1));
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-285.962, ds.Calculate(-26));
        }
    }
}