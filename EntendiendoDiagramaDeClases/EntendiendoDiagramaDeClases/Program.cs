using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendiendoDiagramaDeClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            // Allocate and configure a Car object

            // Make a Car called Chuck going 10 MPH.
            Cars chuck = new Cars();
            chuck.PrintState();
            // Make a Car called Mary going 0 MPH.
            Cars mary = new Cars("Mary");
            mary.PrintState();
            // Make a Car called Daisy going 75 MPH.
            Cars daisy = new Cars("Daisy", 75);
            daisy.PrintState();


            // Speed up the car a few times and print out the
            // new state.
            //for(int i = 0; i <= 5; i++)
            //{
            //    MyCar.SpeedUp(5);
            //    MyCar.PrintState();
            //}
            Console.WriteLine("***** Class Motorcycle *****\n");

            // Make a Motorcycle with a rider named Tiny?
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.name); // Prints an empty name value!
            Console.ReadLine();
        }
    }
}
