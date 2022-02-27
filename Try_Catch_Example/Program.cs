using System;

namespace Try_Catch_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            // when everything is going ok the codes of try body will execute
            try
            {
                Console.WriteLine("If you enter string app will throw exception, so just enter your age:");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine("Congratulation you're " + age + " years old");
            }
            /* when app throw a exception the codes of catch body will execute and
               also we can have multiple catches with different types of exception */

            catch (FormatException)
            {
                Console.WriteLine("ERROR!!!");
            }
            // the body of finally will execute at the end and doesn't matter the try compiled or catch
            finally
            {
                Console.WriteLine("This is the body of finally command!");
            }

        }
    }
}
