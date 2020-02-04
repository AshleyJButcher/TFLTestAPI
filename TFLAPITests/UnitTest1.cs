using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TFLTest;

namespace TFLTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidRoad()
        {
            string result = APIRequest.GetRoadStatus("A2").GetAwaiter().GetResult();
            Assert.IsFalse(result.Contains("not a valid"));
        }


        [TestMethod]
        public void InValidRoad()
        {
            string result = APIRequest.GetRoadStatus("A233").GetAwaiter().GetResult();
            Assert.IsTrue(result.Contains("not a valid"));
        }
    }
}
