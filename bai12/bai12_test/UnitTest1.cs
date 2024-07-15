using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using bai12;

namespace bai12_test
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
            string arrStr = TestContext.DataRow[0].ToString(); 
            string expResultTo = TestContext.DataRow[1].ToString();

            int[] arrStrToArray = string.IsNullOrWhiteSpace(arrStr) ? 
                new int[0] : arrStr.Split(',').Select(int.Parse).ToArray();
            int[] expResultToArray = string.IsNullOrWhiteSpace(expResultTo) ? 
                new int[0] : expResultTo.Split(',').Select(int.Parse).ToArray();

            Sort sort = new Sort();
            sort.QuickSort(arrStrToArray, 0, arrStrToArray.Length - 1);

            CollectionAssert.AreEqual(arrStrToArray, expResultToArray);
        }
    }
}
