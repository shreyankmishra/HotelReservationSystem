using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Hotel
    {
        HotelTypes type;
        public double RATE { get; }
        public Hotel(HotelTypes hotelType)
        {
            this.type = hotelType;
            try
            {
                if (hotelType.Equals(HotelTypes.LAKEWOOD))
                {
                    this.RATE = 110;
                }
                if (hotelType.Equals(HotelTypes.BRIDGEWOOD))
                {
                    this.RATE = 150;
                }
                if (hotelType.Equals(HotelTypes.RIDGEWOOD))
                {
                    this.RATE = 220;
                }
            }
            catch (HotelReservationSystemException)
            {
                throw new HotelReservationSystemException(HotelReservationSystemException.ExceptionType.INVALID_HOTEL_TYPE, "Invalid Hotel Type");
            }
        }
    }
}
