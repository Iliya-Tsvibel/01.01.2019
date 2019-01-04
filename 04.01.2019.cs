using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter any number for cheking if it prime number");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            int m = 2;
            while (x % m != 0 && m < x)
            {
                m++;
            }
            if (m < x || x==1) 
            {
                Console.WriteLine($"{x} is not prime number");
            }
            else
            {
                Console.WriteLine($"{x} is prime number");

            }
            */

            /*

            Console.WriteLine("Enter amount of children");
            int children = Convert.ToInt32(Console.ReadLine());
            int room100 = children / 100;
            Console.WriteLine($"{room100} room of value 100 children");
            // children = children - room100
            children = children % 100;

            int room30 = children / 30;
            Console.WriteLine($"{room30} room of value 30 children");
            //children = children % 30;
            children = children - room30 * 30;
            

            int room10 = children / 10;
            Console.WriteLine($"{room10} room of value 10 children");
            //children = children - room10;
            children = children - room10 * 10;


            int gohome = children;
            Console.WriteLine($"{gohome} children that going home");


            Console.WriteLine("Goodbye");
            */

            /* Triangle with numbers
             
            Console.WriteLine("Enter size of Triangle:");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= size; i++)
            {
                
                for (int j = 1; j <= size; j++)
                {
                   
                    if (j <= i)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                   
                   
                }


                Console.WriteLine(); // go down a line after each i iteration

            }
            for (int i = size - 1; i >= 1; i--)
            {
                for (int j = 1; j <= size; j++)
                {

                    if (j <= i)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write("*");
                    }


                }


                Console.WriteLine(); // go down a line after each i iteration
            }

    */
            // Triangle without numbers


        }



    }

}
