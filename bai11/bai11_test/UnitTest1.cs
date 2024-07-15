using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using bai11;

namespace bai11_test
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data\\dataDriven.csv", "dataDriven#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            string arr = TestContext.DataRow[0].ToString();
            bool expectedResult = bool.Parse(TestContext.DataRow[1].ToString());

            int[] a = string.IsNullOrWhiteSpace(arr) ? new int[0] : arr.Split(',').Select(int.Parse).ToArray();

            KtraDoiXung ktraDoiXung = new KtraDoiXung();
            bool result = ktraDoiXung.IsSymmetry(a, a.Length);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
