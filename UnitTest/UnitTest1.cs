using System;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod()]
        public void GetMD5Password()
        {
            string password = "1";
            var pas = Helpers.MD5Encrypt32(password);
            Assert.IsTrue(pas == "sdsfdsf");
        }
    }
}
