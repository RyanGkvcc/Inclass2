using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Hanoi
    {
        public void moveDisk(int n, char source, char auxilary, char destination)
        {
            //Baase case to exit recursive loop.
            if (n == 1)
            {
                //Since we only have to move one disk. (n-1), we don't want to make another
                //recursive call. we jist want to output the move that we are performing.
                Console.WriteLine("Move disk from tower {0} to tower {1}", source, destination);
            }
            else
            {
                //Note: the desciption of source, auxilary, and destination are refering to
                //the first time this moveDisk mothod is called. As recursion works, it may
                //not make sense to associate the work source with a peg letter.
                                
                //Attempt to move (n-1) disks from source location (A) to auxilary location (B), using
                //the destination(C) peg as temporary storage.
                moveDisk(n - 1, source, destination, auxilary);

                //Move the Source disk (A) to the Destination (C).
                moveDisk(1, source, auxilary, destination);

                //Move the (n-1) from Auxilary (B) to Destination (C) using the Beginning
                //(A) as temporary storage.
                moveDisk(n - 1, auxilary, source, destination);
            }
        }
    }
}
