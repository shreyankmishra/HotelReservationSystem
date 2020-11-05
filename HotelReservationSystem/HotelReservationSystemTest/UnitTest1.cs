using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservationSystem;

namespace HotelReservationSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddingHotelTest()
        {
            Hotel hotel = new Hotel(HotelTypes.LAKEWOOD);
            double expectedRate = 110;
            Assert.AreEqual(expectedRate, hotel.RATE);
        }
    }
}
