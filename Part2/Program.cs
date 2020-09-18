/// Lab No. 3		Exercise Part 1
/// File Name: LampFlowChart
/// @author: Evan Sinclair
/// Date:  Sept 18, 2020
///
/// Problem Statement: Write a program that simulates the Lamp flowchart.
/// 
/// 
/// Overall Plan:
/// 1)Create bools for possible problems with lamp
/// 2)set bools to simulate problems
/// 3)create "if" statements to navigate flowchart
/// 4)output correct solution to the console
///




using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // booleans needed for navigating flowchart
            bool pluggedIn, bulbGood;

            // Comment out as need for execution

            pluggedIn = false;
            pluggedIn = true;

            bulbGood = false;
            //bulbGood = true;

            // Diagram logic
            
            if (pluggedIn)
            {
                if (bulbGood)
                {
                    Console.WriteLine("Repair lamp");
                }
                else 
                {
                    Console.WriteLine("Replace bulb");
                }
            }
            else
            {
                Console.WriteLine("Plug in lamp");
            }


        }
    }
}
