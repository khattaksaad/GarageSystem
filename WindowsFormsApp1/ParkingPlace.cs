using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ParkingPlace
    {
        private int placeNumber;
        private int level_number;
        public bool isBooked = false;
        public Vehicle parkedVehicle = null;
        public void setPlaceNum(int num)
        {
            placeNumber = num;
        }

        public int getPlaceNum()
        {
            return this.placeNumber;
        }

        public void setLevelNum(int num)
        {
            this.level_number = num;
        }

        public int getLevelNumber()
        {
            return this.level_number;
        }

        public void setparkedVehicle(Vehicle v)
        {
            this.parkedVehicle = v;
        }

        public Vehicle getparkedVehicle()
        {
            return this.parkedVehicle;
        }

        public ParkingPlace(int placeNum, int level_number)
        {
            this.placeNumber = placeNum;
            this.level_number = level_number;
        }

        public Boolean park(Vehicle v)
        {
            if (isBooked)
            {
                return false;
            }
            else
            {
                parkedVehicle = v;
                isBooked = true;
            }
            return true;
        }
    }
}
