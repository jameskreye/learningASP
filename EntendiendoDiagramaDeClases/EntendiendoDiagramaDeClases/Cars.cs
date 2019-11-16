using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendiendoDiagramaDeClases
{
    public class Cars
    {
        // The 'state' of the Car.
        public string petName;
        public int currSpeed;

        // A custom default constructor.
        public Cars()
        {
            petName = "chuck";
            currSpeed = 10;
        }

        // Here, currSpeed will receive the
        // default value of an int (zero).
        public Cars(string pn) => petName = pn;

        // Let caller set the full state of the Car.
        public Cars(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        // The functionality of the Car.
        // Using the expression-bodied member syntax introduced in C# 6
        public void PrintState()
        {
            Console.WriteLine($"{petName} is going {currSpeed} MPH. " );
        }

        public void SpeedUp(int Delta)
        {
            currSpeed += Delta;
        }

    }
}
