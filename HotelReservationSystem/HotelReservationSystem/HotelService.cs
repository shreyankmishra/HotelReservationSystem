using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelService
    {
        public HotelTypes FindCheapestHotel(string startDate, string endDate)
        {
            Hotel LakeWood = new Hotel(HotelTypes.LAKEWOOD);
            Hotel BridgeWood = new Hotel(HotelTypes.BRIDGEWOOD);
            Hotel RidgeWood = new Hotel(HotelTypes.RIDGEWOOD);
            double LakeWoodRate = LakeWood.FindTotalCost(startDate, endDate);
            double BridgeWoodRate = BridgeWood.FindTotalCost(startDate, endDate);
            double RidgeWoodRate = RidgeWood.FindTotalCost(startDate, endDate);

            double MinRate = Math.Min(LakeWoodRate, Math.Min(BridgeWoodRate, RidgeWoodRate));
            if (MinRate == LakeWoodRate)
                return HotelTypes.LAKEWOOD;
            if (MinRate == BridgeWoodRate)
                return HotelTypes.BRIDGEWOOD;
            return HotelTypes.RIDGEWOOD;
        }
    }
}
