using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomlevels
{
    class Program
    {
        /*
        * TODO
        * create a program to give an array of instructions for a boxing class
        * 
        * Take 3 arrays (low[10], medium[10], high[5]) and create a bigger array[30]
        * where the first third is all low level in a random order
        * the second third is a mix of low and medium levels where its more likely to be medium
        * the final third is a mix of all levels, but more likely to have the high level objects.
        * no repeats in the same third when an array runs out  you must use lower level
        */
        static void Main(string[] args)
        {
            
            //objects are boxing moves
            object[] low = new object[10] 
                { "1", "2", "3", "4", "5", "6", "1 2 1 2", "3 4 3 4", "5 6 5 6", "1 2 3 4 5 6" };
            object[] medium = new object[10]
                {"1 1 2", "2 3 2", "1 2 3 4", "3 4 5 6", "1 1 6", "1 1 4", "1 1 2 3 2", "3 4 5 6 1", "1 3 5", "2 4 6" };
            object[] high = new object[5]
                {"3 duck 4 duck", "1 slip 2 slip", "1 2 slip slip", "1 duck 2 duck", "1 2 3 slip 3 2 1 slip" };

            object[] firstThird = new object[10];
            object[] secondThird = new object[10];
            object[] finalThird = new object[10];

            Random r = new Random();
            int rNum = -1; //random number in array
            int rNum2 = -1; //see which array to take from
            object temp = -1;
            for (int x = 0; x < 10; x++)
            {
                rNum = r.Next(10);
                while (firstThird.Contains(low[rNum])) { rNum = r.Next(10); }
                firstThird[x] = low[rNum];
                Console.WriteLine(firstThird[x]);
            }
            Console.WriteLine();
            for (int x = 0; x < 10; x++)
            {
                do
                {
                    rNum2 = r.Next(3);
                    if (rNum2 < 2) { temp = medium[r.Next(10)]; }
                    else { temp = low[r.Next(10)]; }
                }
                while (secondThird.Contains(temp));
                secondThird[x] = temp;
                Console.WriteLine(secondThird[x]);
                
            }
            Console.WriteLine();
            for (int x = 0; x < 10; x++)
            {
                do
                {
                    rNum2 = r.Next(8);
                    if (rNum2 < 2) { temp = medium[r.Next(10)]; }
                    else if(rNum2 < 4){ temp = low[r.Next(10)]; }
                    else { temp = high[r.Next(5)]; }
                }
                while (finalThird.Contains(temp)) ;
                finalThird[x] = temp;
                Console.WriteLine(finalThird[x]);
            }

            Console.ReadLine();
            

            
        }
    }
}
