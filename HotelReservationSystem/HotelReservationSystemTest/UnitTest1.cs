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
            Assert.AreEqual(expectedRate, hotel.WEEKDAY_RATE);
        }
        [TestMethod]
        public void CheapestHotelTest()
        {
            HotelService service = new HotelService();
            HotelTypes hotel = service.FindCheapestHotel("2020-01-01", "2020-01-04");
            HotelTypes expected = HotelTypes.LAKEWOOD;
            Assert.AreEqual(hotel, expected);
        }
    }
}
