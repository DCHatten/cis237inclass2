using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class TowerOfHanoi
    {
        public TowerOfHanoi()
        {
            //Prompting the user for the number of discs they want to move
            Console.WriteLine("Enter the number of disks to use. Less than 5 is good.");
            string input = Console.ReadLine();
            //Parsing the user input to an int value
            int diskNumber = Int32.Parse(input);
            //Running the disc movement of the discs
            this.moveDisc(diskNumber, 'A', 'B', 'C');
        }
        /// <summary>
        /// Method to actually move the discs from the source to the destination
        /// </summary>
        /// <param name="n">The total number of discs to be moved</param>
        /// <param name="source">The tower where the discs start</param>
        /// <param name="auxillary">The spare tower to aid the movement</param>
        /// <param name="destination">The tower the discs will end on</param>
        private void moveDisc(int n, char source, char auxillary, char destination)
        {
            if (n == 1)
            {
                //Prints the move
                Console.WriteLine("Move disk from tower {0} to tower {1}", source, destination);
            }
            else
            {
                //Makes a recursive call to move n-1 discs from the source to the auxillary
                moveDisc(n - 1, source, destination, auxillary);
                //Makes a recursive call to move the bottom disc from the source to the destination
                moveDisc(1, source, auxillary, destination);
                //Makes a recursive call to move n-1 discs from the auxillary to the destination
                moveDisc(n - 1, auxillary, source, destination);
            }
        }
    }
}
