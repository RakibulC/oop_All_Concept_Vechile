using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_01_OOP_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int temp = 0;
                while (temp == 0)
                {
                    Console.Write("Which information do you want: \n[Hints]\n1. Car\n2. MotorCycle\nEnter sl no\t: ");

                    VehicleType vehicleType = (VehicleType)int.Parse(Console.ReadLine());
                    if(vehicleType==(VehicleType)1 || vehicleType == (VehicleType)2)
                    {
                        if(vehicleType== (VehicleType)1)
                        {
                            CarInfo();
                        }
                        else
                        {
                            MotorCycleInfo();
                        }
                        temp = 1;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter Correct no!!");
                        temp = 0;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
        }
        private static void MotorCycleInfo()
        {
            Console.Write("Model No\t: ");
            string modelNo = Console.ReadLine();

            Console.Write("Year Make\t: ");
            int yearMake = int.Parse(Console.ReadLine());

            Console.Write("No of Gear\t: ");
            int noOfGear = int.Parse(Console.ReadLine());

            Console.Write("Engine capacity in CC\t: ");
            int engineCapacityCC = int.Parse(Console.ReadLine());

            Console.Write("Max power in BPH\t: ");
            int maxPower = int.Parse(Console.ReadLine());

            Console.Write("Max torque in NM\t: ");
            int maxTorque = int.Parse(Console.ReadLine());

            Console.Write("Rear Break\t: ");
            string rearBreak = Console.ReadLine();

            Console.Write("Cooling System\t: ");
            string coolingSystem = Console.ReadLine();

            Console.Write("Starting Method\t: ");
            string startingMethod = Console.ReadLine();

            Console.Write("Front Break\t: ");
            string frontBreak = Console.ReadLine();

            Console.Write("Millage\t: ");
            double millage = double.Parse(Console.ReadLine());

            MotorCycle m = new MotorCycle(maxPower, maxTorque, startingMethod, millage, coolingSystem,
                frontBreak, rearBreak, modelNo, yearMake, noOfGear, engineCapacityCC);

            string specification = "";
            while (specification.ToLower()!="0")
            {
                Console.Write("Add Exterior Design [press 0 to stop]: ");
                specification = Console.ReadLine();
                if (specification.ToLower() != "0")
                {
                    m.AddSpecification(specification);
                }
            }

            Console.WriteLine();
            Console.WriteLine("***************************************");
            Console.WriteLine();
            Console.WriteLine($"Model No\t: {modelNo}");
            Console.WriteLine($"Year Make\t: {yearMake}");
            Console.WriteLine($"No of Gear\t: {noOfGear}");
            Console.WriteLine($"Engine capacity in CC\t: {engineCapacityCC}");
            Console.WriteLine($"Max Torque\t: {maxTorque}");
            Console.WriteLine($"Exterion Design\t: {m.ShowSpecification()}");
        }
        private static void CarInfo()
        {

        }
    }
}
