using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_01_OOP_Implementation
{
    public sealed class MotorCycle:TwoWheeler
    {
        public MotorCycle()
        {
            
        }
        public MotorCycle(int maxPower, int maxTorque, string startingMethod, double millage,
            string cooling, string frontBrake, string rearBrake,string modelNo,int yearMake,int noOfGear,int engineCapacityInCC)
        {
            ModelNo = modelNo;
            YearMake=yearMake; 
            NoOfGear=noOfGear; 
            EngineCapacityInCC=engineCapacityInCC;
            MaxPower = maxPower;
            MaxTorque = maxTorque;
            StartingMethod = startingMethod;
            Millage = millage;
            Cooling = cooling;
            FrontBrake = frontBrake;
            RearBrake = rearBrake;
        }

        public int MaxPower { get; set; }
        public int MaxTorque { get; set; }
        public string StartingMethod { get; set; }
        public double Millage { get; set; }
        public string Cooling { get; set; }
        public string FrontBrake { get; set; }
        public string RearBrake { get; set; }

    }
}
