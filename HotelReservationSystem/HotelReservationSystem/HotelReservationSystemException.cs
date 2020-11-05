using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelReservationSystemException : Exception
    {
        public enum ExceptionType
        {
            INVALID_HOTEL_TYPE
        }
        ExceptionType type;
        public HotelReservationSystemException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
