using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Vehicle
    {
        protected ParkingPlace parkedPlace;
        protected string licensePlate;
        protected string VehicleType;
        public Vehicle(string PlateNum, string typeOfVehicle)
        {
            this.licensePlate = PlateNum;
            this.VehicleType = typeOfVehicle;
        }
        public string getLicensePlateNum()
        {
            return this.licensePlate;
        }
        public void setPrakingPlace(ParkingPlace p)
        {
            this.parkedPlace = p;
        }
        public string getVehicleType()
        {
            return this.VehicleType;
        }
    }
}
