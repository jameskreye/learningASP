using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendiendoDiagramaDeClases
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;


        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }

        // Put back the default constructor, which will
        // set all data members to default values.
        public Motorcycle() { }

        // Our custom constructor.
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }

        // New members to represent the name of the driver.
        public void SetDriverName(string nm)
        {
            name = nm;
        }
    }
}
