using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert value a");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert value b");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose what do you want to do by intering relevant number: insert 1 for a+b, 2 for a-b. 3 for a*b, 4 for a^b, 5 for a^(1/b), 6 for EXIT");
            int action = Convert.ToInt32(Console.ReadLine());
            switch(action)
            {
                case 1:
                    Console.WriteLine(a+b);
                    break;
                case 2:
                    Console.WriteLine(a-b);
                    break;
                case 3:
                    Console.WriteLine(a*b);
                    break;
                case 4:

                    Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
                    break;
                case 5:
                    if (b==0)
                    {
                        Console.WriteLine("Action can't be perfprmed due to zero value of b");
                    }
                    else
                    
                        Console.WriteLine($"{a} ^ ( 1 / {b}) = {Math.Pow(a, 1 /b )}");
                        
                    
                    break;
                case 6:
                    Console.WriteLine("Good bye");
                    break;


            }


        }

    }
}
