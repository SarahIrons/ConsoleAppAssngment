using System;

namespace ConsoleAppAssngment
{
    class Program
    {//CONSOLE APP ASSIGNMENT
     //Create a console app that does/includes the following:
     //Do a boolean comparison using a while statement.

        static void Main()
        {  //initializa an integer variable to zero
            int i = 0;
            while (i < 6)
            //while loop uses the variable in its condition to evaluate if i is less than 6. if it is 6 or more, the condition is false and the loop ends.
            {
                Console.WriteLine(i);
                i++;
            }
            //this increases increment operator (++) to increase variable by 1.
            //program will print all values 0-5.
            //Do a boolean comparison using a do while statement.
            //NOTE--if the curly braces are not around lines 15-17 above--this will result in an INFINITE loop running zero.

            //here is a do-while loop statement:
            //This type of statment is one that evaluates the condition, and then update the loop variable inside the loop.

            int x = 10, value = 5;
            do
            {
                Console.WriteLine("x = {0}, value = {1}", x, value);
                value--;
                //the decrement "--" decreases by value of "one".
                //Since the variable value was changed to 5 here--the new decrement is value of 5.
                //the program will now return values counting down in increments of 5 at a time and compare against zero.
            } while ((x = 5 + value) > 0);
        }
    }
}
