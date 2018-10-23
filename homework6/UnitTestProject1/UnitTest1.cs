using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        //[ExpectedException(typeof(ArgumentException))]
        public interface IExpectException
        {
            void HandleException(System.Exception ex);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int Order = new int();
            Assert.IsTrue(Order == new int());
        }
        public void TestMethod3()
        {
            int OrderId = new int();
            Assert.IsTrue(OrderId == new int());
        }
        public void TestMethod4()
        {
            int OrderId = new int();
            throw new Exception("order-{orderId} is not existed!");
            Assert.IsFalse(OrderId == new int());
        }
        public void TestMethod5()
        {
            int OrderId = new int();
            Assert.IsTrue(OrderId == new int());
        }
        public void TestMethod6()
        {
            int GoodsName = new int();
            Assert.IsTrue(GoodsName == new int());
        }
        public void TestMethod7()
        {
            int CustomerName = new int();
            Assert.IsTrue(CustomerName == new int());
        }
        public void TestMethod8()
        {
            int newCustomer = new int();
            throw new Exception("order-{orderId} is not existed!");
            Assert.IsFalse(newCustomer == new int());
        }
    }
}
