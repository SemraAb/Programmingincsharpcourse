using System;

namespace FirstLessonProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first integer number");
            int var1;
            int var2;
            while (true)
            {
                
                    try
                    {
                        var1 = int.Parse(Console.ReadLine());
                    break;
                    }
                    catch (Exception exp)
                    {
                        Console.WriteLine("Please enter just integer numbers");
                        
                    }
            }
            
            
           
            Console.WriteLine("Please enter second integer number");
            while (true)
            {

                try
                {
                    var2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Please enter just integer numbers 2");

                }
            }

            int sum = Sum(var1, var2);
            Console.WriteLine("Sum is " + sum);
        }
        public static int  Sum(int var1, int var2)
        {
            return  var1 + var2;
        }
            
    }
}
