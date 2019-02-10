using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Level
    {
        public int level_Number { get; set; } // number, initally starts from 0
        public string level_Name { get; set; } //name of level - optional
        public int totalCapacity { get; set; }  //total capacity
        public int availableCapacity { get; set; } // number of spots left on the current level
        private List<ParkingPlace> parkingPlaces; 
        public List<Vehicle> ParkedVehicles { get; set; }
        public Level(int level_number, string level_name = "Default", int totalCap = 2) //default level name and total cap = 2 but can be changed
        {
            this.level_Name = level_name;
            this.level_Number = level_number;
            this.totalCapacity = totalCap;
            this.availableCapacity = totalCap;
            this.parkingPlaces = new List<ParkingPlace>();
            this.ParkedVehicles = new List<Vehicle>();
            for (int i = 0; i < totalCap; i++)
            {
                parkingPlaces.Add(new ParkingPlace(i, this.level_Number));
            }
        }
        public int FreePlaces()
        {
            return availableCapacity;
        }
        //parks vehicle at the any of the free spot on the current level and adds
        // it to the list of currently parked vehicle
        public bool parkVehicle(Vehicle v)
        {
            if (FreePlaces() >= 1)
            {
                ParkingPlace pk = getFreeParkingPlace();
                pk.setparkedVehicle(v);
                v.setPrakingPlace(pk);
                ParkedVehicles.Add(v);
                pk.isBooked = true;
                this.availableCapacity -= 1;
                return true;
            }
            else
                return false;
            
        }
        //checks if any free parking spots and returns one that can be used to park vehicle 
        public ParkingPlace getFreeParkingPlace()
        {
            var freeParkingPlaces = parkingPlaces.Where(x => x.isBooked == false).ToList();
            return freeParkingPlaces[0];
        }
        // increase capacity of the current level
        public void setAvailableCapacity(int cap)
        {
            this.availableCapacity += cap - this.totalCapacity;
            for (int i = this.totalCapacity - 1; i <= cap - this.totalCapacity; i++)
            {
                parkingPlaces.Add(new ParkingPlace(i, this.level_Number));
            }
            this.totalCapacity = cap;
            
        }
        //release vehicle from the parking space and also from the currently parked vehicle's list
        public bool ReleaseVehicle(Vehicle v,int index)
        {
            try
            {
                int ind = parkingPlaces.FindIndex(c => c.parkedVehicle !=null && c.parkedVehicle.getLicensePlateNum() == v.getLicensePlateNum() && c.parkedVehicle.getVehicleType() == v.getVehicleType());
                if (ind >= 0)
                {
                    this.parkingPlaces[ind].isBooked = false;
                    this.parkingPlaces[ind].setparkedVehicle(null);
                    this.ParkedVehicles.RemoveAt(index);
                    this.availableCapacity += 1;
                    return true;
                }
                else { return false; }
            }
            catch(Exception ex) {
                {
                    return false;
                }
            }
        }
        
    }
}
