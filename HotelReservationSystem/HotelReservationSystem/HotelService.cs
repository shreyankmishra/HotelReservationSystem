﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelService
    {
        public HotelTypes FindCheapestHotel(string startDate, string endDate)
    {
        Hotel LakeWood = new Hotel(HotelTypes.LAKEWOOD, CustomerType.NORMAL);
        Hotel BridgeWood = new Hotel(HotelTypes.BRIDGEWOOD, CustomerType.NORMAL);
        Hotel RidgeWood = new Hotel(HotelTypes.RIDGEWOOD, CustomerType.NORMAL);
        //Calculating Rate of Each Hotel Between the given dates
        double LakeWoodRate = LakeWood.FindTotalCost(startDate, endDate);
        double BridgeWoodRate = BridgeWood.FindTotalCost(startDate, endDate);
        double RidgeWoodRate = RidgeWood.FindTotalCost(startDate, endDate);

        double MinRate = Math.Min(LakeWoodRate, Math.Min(BridgeWoodRate, RidgeWoodRate));
        if (MinRate == LakeWoodRate && MinRate == BridgeWoodRate && MinRate == RidgeWoodRate)
            return HotelTypes.RIDGEWOOD;
        if (MinRate == LakeWoodRate && MinRate == BridgeWoodRate)
            return HotelTypes.BRIDGEWOOD;
        if (MinRate == BridgeWoodRate && MinRate == RidgeWoodRate)
            return HotelTypes.RIDGEWOOD;
        if (MinRate == LakeWoodRate && MinRate == BridgeWoodRate)
            return HotelTypes.RIDGEWOOD;
        if (MinRate == LakeWoodRate)
            return HotelTypes.LAKEWOOD;
        if (MinRate == BridgeWoodRate)
            return HotelTypes.BRIDGEWOOD;
        return HotelTypes.RIDGEWOOD;
    }
    public HotelTypes FindBestRatedHotel(string startDate, string endDate)
    {
        Hotel RidgeWood = new Hotel(HotelTypes.RIDGEWOOD, CustomerType.NORMAL);
        Hotel BridgeWood = new Hotel(HotelTypes.BRIDGEWOOD, CustomerType.NORMAL);
        Hotel LakeWood = new Hotel(HotelTypes.LAKEWOOD, CustomerType.NORMAL);

        double MaxRating = Math.Max(RidgeWood.RATING, Math.Max(BridgeWood.RATING, LakeWood.RATING));
        if (MaxRating == RidgeWood.RATING)
            return HotelTypes.RIDGEWOOD;
        if (MaxRating == BridgeWood.RATING)
            return HotelTypes.BRIDGEWOOD;
        else
            return HotelTypes.LAKEWOOD;
    }
}
}
