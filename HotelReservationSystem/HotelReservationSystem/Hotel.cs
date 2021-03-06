﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Hotel
    {
        HotelTypes type;
        public double WEEKDAY_RATE { get; }
        public double WEEKEND_RATE { get; }
        public double RATING { get; }
        public Hotel(HotelTypes hotelType, CustomerType customerType)
        {
            this.type = hotelType;
            try
            {
                if (hotelType.Equals(HotelTypes.LAKEWOOD))
                {
                    this.RATING = 3;
                    try
                    {
                        if (customerType.Equals(CustomerType.NORMAL))
                        {
                            this.WEEKDAY_RATE = 110;
                            this.WEEKEND_RATE = 90;
                        }
                        if (customerType.Equals(CustomerType.REWARD))
                        {
                            this.WEEKDAY_RATE = 80;
                            this.WEEKEND_RATE = 80;
                        }
                    }
                    catch (HotelReservationSystemException)
                    {
                        throw new HotelReservationSystemException(HotelReservationSystemException.ExceptionType.INVALID_CUSTOMER_TYPE, "Invalid customer type");
                    }
                }
                if (hotelType.Equals(HotelTypes.BRIDGEWOOD))
                {
                    this.RATING = 4;
                    try
                    {
                        if (customerType.Equals(CustomerType.NORMAL))
                        {
                            this.WEEKDAY_RATE = 150;
                            this.WEEKEND_RATE = 50;
                        }
                        if (customerType.Equals(CustomerType.REWARD))
                        {
                            this.WEEKDAY_RATE = 110;
                            this.WEEKEND_RATE = 50;
                        }
                    }
                    catch (HotelReservationSystemException)
                    {
                        throw new HotelReservationSystemException(HotelReservationSystemException.ExceptionType.INVALID_CUSTOMER_TYPE, "Invalid customer type");
                    }
                }
                if (hotelType.Equals(HotelTypes.RIDGEWOOD))
                {
                    this.RATING = 5;
                    try
                    {
                        if (customerType.Equals(CustomerType.NORMAL))
                        {
                            this.WEEKDAY_RATE = 220;
                            this.WEEKEND_RATE = 150;
                        }
                        if (customerType.Equals(CustomerType.REWARD))
                        {
                            this.WEEKDAY_RATE = 100;
                            this.WEEKEND_RATE = 40;
                        }
                    }
                    catch (Exception)
                    {
                        throw new HotelReservationSystemException(HotelReservationSystemException.ExceptionType.INVALID_CUSTOMER_TYPE, "Invalid customer type");
                    }
                }
            }
            catch (HotelReservationSystemException)
            {
                throw new HotelReservationSystemException(HotelReservationSystemException.ExceptionType.INVALID_HOTEL_TYPE, "Invalid Hotel Type");
            }
        }
        public double FindTotalCost(string startDateString, string endDateString)
        {
            double TotalCost = 0;
            try
            {
                DateTime startDate = Convert.ToDateTime(startDateString);
                DateTime endDate = Convert.ToDateTime(endDateString);
                for (; startDate <= endDate; startDate = startDate.AddDays(1))
                {
                    if (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday)
                        TotalCost += WEEKEND_RATE;
                    else
                        TotalCost += WEEKDAY_RATE;
                }
            }
            catch (Exception)
            {
                throw new HotelReservationSystemException(HotelReservationSystemException.ExceptionType.INVALID_DATE, "Invalid date entered");
            }
            return TotalCost;
        }

    }
}
