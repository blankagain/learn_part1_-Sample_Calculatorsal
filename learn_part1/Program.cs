// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

class test
{
    //int slary;
    //int shift;
    //float saving;
    static int CalculateSal(int salary, float shifts)

    {
        
                int saving = (int)((salary * 0.5) + (salary * 0.02 * shifts));
                return saving;
                //Console.WriteLine(saving + "here is your saving"); 
            
            
    }

    static void Main(String[] args)
    {
        string userinput;
        while (true)
        {
            Console.WriteLine(("Input the salary"));
            int sal = Convert.ToInt32(Console.ReadLine());
            if (sal < 8000 && sal > 0)
            {
                Console.WriteLine("Input Shifts: ");
                float shift = Convert.ToInt32(Console.ReadLine());
                if (shift > 0)
                {
                    test sample = new test();
                    int final = CalculateSal(sal, shift);
                    Console.WriteLine("Savings = " + final);
                }
                else { Console.WriteLine("shift too small"); }
            }
            Console.WriteLine("Salary invalid, input ,ust be between 0-8000");
            Console.WriteLine("do you wish to continue(yes/no): ");
            userinput = Console.ReadLine().ToLower();
            if (userinput == "no")
            {
                break;
            }
        }

    }

    
}