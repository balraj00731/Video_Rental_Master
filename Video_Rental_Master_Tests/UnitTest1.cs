using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_Rental_Master;
using System.Data;

namespace Video_Rental_Master_Tests
{
    [TestClass]
    public class UnitTest
    {
        BussinessLogic model = new BussinessLogic();

        [TestMethod()]
        public void UnitTest1()
        {

            model.Changes("Insert into BookingTable Values(1,1,'Test','Test')");
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void UnitTest2()
        {
            model.Changes("Insert into CustomerTable Values('Test','987653210','City','Country')");
            Assert.IsTrue(true);
        }
    }
}
