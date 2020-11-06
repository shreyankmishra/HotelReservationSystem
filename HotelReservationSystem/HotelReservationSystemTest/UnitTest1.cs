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
            Hotel hotel = new Hotel(HotelTypes.LAKEWOOD, CustomerType.NORMAL);
            double expectedRate = 110;
            Assert.AreEqual(expectedRate, hotel.WEEKDAY_RATE);
        }
        [TestMethod]
        public void CheapestBestRatedHotelForRewardCustomerTest()
        {
            HotelService service = new HotelService();
            HotelTypes hotel = service.FindCheapestHotel("2020-09-11", "2020-09-12", CustomerType.REWARD);
            HotelTypes expected = HotelTypes.RIDGEWOOD;
            Assert.AreEqual(hotel, expected);
        }
    }
}
