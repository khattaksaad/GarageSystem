using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ParkingMain
    {
        public static List<Level> levels;
        public static int parkVehicle(Vehicle v)
        {
            int res = -1; //res used to identify response of this method (1 : parked, 0 : already in garage, -1: not enough space)
            bool space = false;
            if (Convert.ToInt32(ParkingMain.findVehicle(v).Split('/')[1]) == -1) //the term returns -1 when it cannot find the vehicle in any of the parking spot at any levels                                                                // meaning the park is not in garage so can be parked.
            {
                res = -1;
                for (int i = 0; i < levels.Count; i++)
                {
                    if (levels[i].availableCapacity > 0)
                    {
                        levels[i].parkVehicle(v);
                        res = 1;
                    }
                }
            }
            else
                res = 0;
            return res;
        }
        //lookup for the vehicle, if in garage, release it.
        public static bool ReleaseVehicle(Vehicle v)
        {
            bool res = false;
            for (int i = 0; i < levels.Count; i++)
            {
                int ind = Convert.ToInt32(ParkingMain.findVehicle(v).Split('/')[1]);
                if (ind!=-1)
                {
                    res = levels[i].ReleaseVehicle(v,ind);
                    if(res)
                        return true;
                }
            }
            return false;
        }
        //find vehicle if in garage, return its level and parking spot number
        public static string findVehicle(Vehicle v)
        {
            
            for (int i = 0; i < levels.Count; i++)
            {
                int ind = levels[i].ParkedVehicles.FindIndex(c => c.getLicensePlateNum() == v.getLicensePlateNum() && c.getVehicleType() == v.getVehicleType());
                if (ind != -1)
                {
                    
                    return i + "/" + ind;
                }
            }
            return "/-1";
        }
    }
}
