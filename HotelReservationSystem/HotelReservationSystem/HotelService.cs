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

            if (LakeWoodRate < BridgeWoodRate && LakeWoodRate < RidgeWoodRate)
            {
                return HotelTypes.LAKEWOOD;
            }
            else if (BridgeWoodRate < LakeWoodRate && BridgeWoodRate < RidgeWoodRate)
            {
                return HotelTypes.BRIDGEWOOD;
            }
            else
            {
                return HotelTypes.RIDGEWOOD;
            }
        }
    }
}
