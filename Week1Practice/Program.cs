using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARING VARIABLES
            // 1. Declare a string variable called "myName" and set it equal to your name
            string myName = "Keith";
            // 2. Declare a number varible called "myAge" and set it equal to your age
            int myAge = 31;
            // 3. Declare a boolean value called "myBool" and set it equal to true or false;
            bool myBool = false;
            // 4. Declare a new list of strings called "productsList" and set it equal to "basketball", "baseball glove", "tennis shoes", "hockey puck"
            List<string> productList = new List<string>() { "basketball", "baseball glove", "tennis shoes", "hockey puck" };
            // PRINTING VARIABLES TO THE CONSOLE USING CONSOLE.WRITELINE()
            // 1. Print your name to the console using the format: "My name is <myName> and I'm a beast of a programmer."
            Console.WriteLine("My name is " + myName + " and I'm a beast of a programmer.");
            Console.WriteLine(); //added line for readability
            // 2. Print out your age to the console using the format: "I am <myAge> years awesome."
            Console.WriteLine("I am " + myAge + " years awesome.");
            Console.WriteLine();
            // 3. Print out your boolean value using the format: "I set my boolean value equal to <myBool>."
            Console.WriteLine("I set my boolean value equal to " + myBool + ".");
            Console.WriteLine();
            // 4. Using a For loop, print out each value in productsList.
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(productList[i]);
            }
            Console.WriteLine();
            // FOR LOOP PRACTICE
            // 1. Create a for loop that prints out the numbers 1 to 10.
            for (int i = 1; i <= 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            // 2. Create a for loop that prints out the numbers 10 to 1.
            for (int i = 11; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            // 3. Create a for loop that prints out the numbers 10 to 30, only printing the even numbers
            for (int i = 10; i <= 30; i += 2)
            {
                Console.WriteLine(i);
            }
            /*for(int i = 10; i <= 30; i++) {
             * if((i%2) != 0)
             * continue; // iterate 
             * Console.WriteLine(i); */
            Console.WriteLine();
            // 4. Create a for loop that prints out the numbers 100 to 75, only printing every 5th number (100, 95, 90, 85, 80, 75)
            for (int i = 100; i >= 75; i -= 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            // WHILE LOOP PRACTICE
            // 1. Create a while loop that prints out the numbers from 1 to 10.
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine();
            // 2. Create a while loop that prints out the numbers from 10 to 1.
            int k = 10;
            while (k >= 1)
            {
                Console.WriteLine(k);
                k--;
            }
            Console.WriteLine();
            // 3. Create a while loop that prints out the numbers from 15 to 30, only printing the even numbers
            int m = 15;
            while (m <= 30)
            {
                Console.WriteLine(m);
                m += 2;
            }
            Console.WriteLine();
            // 4. Create a while loop that prints out the numbers from 100 to 75, only printing every 5th number (100, 95, 90, 85, 80, 75)
            int n = 75;
            while (n <= 100)
            {
                Console.WriteLine(n);
                n += 5;
            }
            Console.WriteLine();
            // 5. Create a while loop that prints out the numbers from 1 to 10 until it reaches one that is divisible by 4.
            int p = 0;
            while (p <= 10)
                if (p / 4 == 1)
                {
                    break;
                }
                else
                {
                    p++;
                    Console.WriteLine(p);
                }
            Console.WriteLine();
            // PUTTING IT TOGETHER
            // Use either FOR or WHILE loops to accomplish the following:
            // 1. Print out the number of letters in your name using the format: "My name, <myName>, has <number of letters> letters in it."
            for (int i = 0; i <= myName.Length; i++)
                if (i == myName.Length)
                {
                    Console.WriteLine("My name, " + myName + ", has " + i + " letters in it.");
                }
            Console.WriteLine();
            // 2. Print out the number of items in your list using the format: "My product list has <number of items> items in it."
            int productListCount = productList.Count;
            Console.WriteLine("My product list has " + productListCount + " items in it.");
            Console.WriteLine();
            // 3. Print out the number of letters of each item in productsList using the format: "<product> has <number of letters> letters in it."
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(productList[i] + " has " + productList[i].Length + " letters in it.");
            }
            Console.WriteLine();
            Greeting("Geronimo Jackson");
            Console.WriteLine();
            Greeting(myName);
            Console.WriteLine();
            DoubleIt(1337);
            Console.WriteLine();
            DoubleIt(myAge);
            Console.WriteLine();
            Multiply(2, 8);
            Console.WriteLine();
            Multiply(3, myAge);
            Console.WriteLine();
            LoopThis(20, 30);
            Console.WriteLine();
            LoopThis(0, myAge);
            Console.WriteLine();
            SuperLoop(0, 100, 15);
            Console.WriteLine();
            SuperLoop(0, 200, myAge);
            Console.WriteLine();
            Console.WriteLine(NewGreeting("Neil deGrasse-Tyson"));
            Console.WriteLine();
            Console.WriteLine(NewGreeting(myName));
            Console.WriteLine();
            Console.WriteLine("10 tripled is " + TripleIt(10));
            Console.WriteLine();
            Console.WriteLine("My age tripled is " + TripleIt(myAge));
            Console.WriteLine();
            Console.WriteLine(RealMultiply(5, 10));
            Console.WriteLine();
            Console.WriteLine(RealMultiply(2, myAge));
            Console.WriteLine();
            SuperLoop(RealMultiply(1, 5), TripleIt(myAge), TripleIt(myAge - 10));
            Console.WriteLine();
            SuperLoop(RealMultiply(1, 3), TripleIt(RealMultiply(myAge, 7)), TripleIt(myAge - RealMultiply(2, 4)));
            Console.WriteLine();
            Console.ReadKey();
        }
        // DECLARING AND CALLING FUNCTIONS
        // 1. Create a function called "Greeting" that takes one string parameter called "name".  This function will print "Hello <name>"
        static void Greeting(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        // 2. Call the Greeting function by passing in "Geronimo Jackson" as your parameter.
        // See line 130
        // 3. Call the Greeting function by passing in myName as your parameter.
        // See line 132
        // 4. Create a function called "DoubleIt" that takes one integer parameter called "number".  This function will print "<number> doubled is <number * 2>"
        static void DoubleIt(int number)
        {
            Console.WriteLine(number + " doubled is " + (number * 2));
        }
        // 5. Call your DoubleIt Function by passing in 1337 as your parameter.
        // 6. Call your DoubleIt function by passing in myAge as your parameter.
        // 7. Create a function called "Multiply" that takes two integer parameters called "num1" and "num2".  This function will print "<num1> times <num2> is <num1 * num2>"
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 + " times " + num2 + " is " + (num1 * num2));
        }
        // 8. Call your Multiply function by passing in 2 and 8 as your parameters.
        // 9. Call your Multiply function by passing in 3 and myAge as your parameters.
        // 10. Create a function called "LoopThis" that takes two integer parameters called "startNum" and "endNum".
        //      This function will print out: 
        //          a. "I'm looping from <startNum> to <endNum>."  
        //          b. The numbers from startNum to endNum, one per line.
        static void LoopThis(int startNum, int endNum)
        {
            for (int i = 0; i < (endNum - startNum + 1); i++)
                if (i <= (endNum - (startNum + 1)))
                {
                    Console.WriteLine(i + startNum);
                }
                else
                {
                    Console.WriteLine(i + startNum);
                    Console.WriteLine("I'm looping from " + startNum + " to " + endNum + ".");
                }
        }
        // 11. Call your LoopThis function by passing in 20 and 30 as your parameters.
        // 12. Call your LoopThis function by passing in 0 and myAge as your parameters.

        // 13. Create a function called "SuperLoop" that takes three integer parameters called "startNum", "endNum", and "increment".  
        //      You will need to track how many times the loop has been executed in a variable called "loopCount".
        //      This function will print out: 
        //          a. "I'm looping from <startNum> to <endNum>, incrementing <increment> each time"  
        //          b. The numbers from startNum to endNum, one per line.
        //          c. "That loop was craaaaaazy, we looped X times"
        static void SuperLoop(int startNum, int endNum, int increment)
        {
            int loopCount = 0;
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum + ", " + "incrementing " + increment + " each time");
            while (startNum <= endNum)
            {
                Console.WriteLine(startNum);
                startNum = startNum + increment;
                loopCount++;
            }
            Console.WriteLine("That loop was craaaaaazy, we looped " + loopCount + " times");

        }
        // 14. Call your SuperLoop function by passing in 0, 100, and 15 as your parameters.
        // 15. Call your SuperLoop function by passing in 0, 200, and myAge as your parameters.

        //DECLARING AND CALLING RETURN FUNCTIONS
        // 1. Create a function called "NewGreeting" that takes one string parameter called "name".  This function will return a string in the format of "Hello, <name>"
        // 2. Using your NewGreeting function as the parameter for Console.WriteLine(), call your NewGreeting function using the parameter "Neil deGrasse-Tyson"
        //          EX: Console.WriteLine(FunctionCall("myParameter"));
        // 3. Using your NewGreeting function as the parameter for Console.WriteLine(), call your NewGreeting function using the parameter myName.
        public static string NewGreeting(string name)
        {
            return "Hello, " + name;
        }
        // 4. Create a function called "TripleIt" that takes one integer parameter called "number".  This function will return the number times 3.
        // 5. Using your TripleIt function as part of the parameter for Console.WriteLine(), 
        //      call your TripleIt function using the parameter of 10 to print out "10 tripled is <TripleIt Function Call>"
        // 6. Using your TripleIt function as part of the parameter for Console.WriteLine(), 
        //      call your TripleIt function using the parameter of myAge to print out "<myAge> tripled is <TripleIt Function Call>"
        public static int TripleIt(int number)
        {
            return number * 3;
        }
        // 7. Create a function called "RealMultiply" that takes two integer parameters called "num1", and "num2".  This function will return the num1 * num2.
        // 8. Using your RealMultiply function as part of the parameter for Console.WriteLine(), 
        //      call your RealMultiply function using the parameter of 5 and 10 to print out the returned value from your function.
        // 9. Using your RealMultiply function as part of the parameter for Console.WriteLine(), 
        //      call your RealMultiply function using the parameter of 2 and myAge to print out the returned value from your function.

        public static int RealMultiply(int num1, int num2)
        {
            return num1 * num2;
        }
        //FUNCTION CALL MADNESS!
        // 1. Call your SuperLoop function using the following parameters:
        //      startNum = Call RealMultiply with the parameters 1, 5
        //      endNum = Call TripleIt with the parameter myAge
        //      increment = Call TripleIt with the parameter of myAge minus 10

        // 2. Call your SuperLoop function using the following parameters:
        //      startNum = Call RealMultiply with the parameters 1, and TripleIt with the parameter of 3.
        //      endNum = Call TripleIt with the parameter RealMultiply with the parameters: myAge, 7
        //      increment = Call TripleIt with the parameter of myAge minus RealMultiply with the parameters 2, 4. */

        //START -- FUNCTION DECLARATIONS 

        //Example function declaration
        //static void MyFunction(string myParameter)
        // {
        //Code block
        //}

        //END   -- FUNCTION DECLARATIONS
    }//class
}//namespace
