using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*String, int, and combinding variable values
            string first = "Danielle";
            string last = " Smith";
            int replace = 2;
            int dontreplace = 1;
            Console.WriteLine(first + last);
            Console.Write(replace + dontreplace);
            Console.ReadLine();*/

            /*User input. Interpolation - using $ and {}. Age is not converted to int.
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"How's it going {name}, glad you are here.");
            Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("You are " + age);

            /*More practice with user input. ReadLine in introduce a pause
            Console.WriteLine("Press Enter to start");
            Console.WriteLine("Let's Begin");
            Console.ReadLine();
            Console.WriteLine("Danielle is cool");*/

            /* Indexing with string
            string name = "Danielle";
            int findindex = name.IndexOf('i');
            Console.WriteLine(findindex);
            Console.WriteLine("The placement for i is " + findindex + ".");*/

            /* User input. Interpolation. No int conversion.
            Console.WriteLine("Enter the first number:");
            string first = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            string second = Console.ReadLine();
            Console.WriteLine($"Your numbers are {first} & {second}");*/

            /* Intergers with operators
            int first = 3;
            int second = 6;
            Console.WriteLine(first + second);
            Console.ReadLine();*/

            /*Integer operators and variables 
            int number = 100;
            string multiple = $"The multiple is {number * 10}.";
            Console.WriteLine(multiple);*/

            /*Showing what happens when two strings with number values are combined
            Console.WriteLine("Please enter your first number:");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter your second number");
            string second = Console.ReadLine();
            string together = first + second;
            Console.WriteLine($"Your answer is {together}.");
            Console.ReadLine();*/

            /*Operators in strings to print
            Console.WriteLine("The answer is " + (12 * 4));
            Console.WriteLine(12 * 4)*/

            /*User input, string convert to number, operator
            Console.WriteLine("Please enter your first number:");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter your second number:");
            string second = Console.ReadLine();
            double third = Convert.ToDouble(first) * Convert.ToDouble(second);
            Console.WriteLine($"Your multiple is {third}.");*/

            /* Variable placement concatenation. 
            int x = 28;
            double y = 29;
            Console.WriteLine("Danielle is {1} and Jessie is {0}. But she wishes she was {0}.", x, y);*/

            /* Concatenation with +
            int z = 28;
            double a = 29;
            Console.WriteLine("Danielle is " + a + " and Jessie is " + z + ". But she wishes she was " + z + ".");*/

            /* More practice with $ and {} concatenation or interpolation
            int b = 28;
            double c = 29;
            Console.WriteLine($"Danielle is {c} and Jessie is {b}. But she wishes she was {b}.");*/


            /* Three ways to convert numbers and contatenate
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your age is {age}.");

            Console.WriteLine("Please enter your age:");
            string ageSecond = Console.ReadLine();
            Console.WriteLine("Your age is " + Convert.ToInt32(ageSecond) + ".");

            Console.WriteLine("Please enter your age:");
            string ageThird = Console.ReadLine();
            int ageThridNew = Convert.ToInt32(ageThird);
            Console.WriteLine("Your age is " + Convert.ToInt32(ageThird) + ".");*/

            /* Modulus (Remainder) and conversion practice
            int num = 10;
            int numSecond = 3;
            Console.WriteLine(num % numSecond);

            int numTest = Convert.ToInt32(10);
            int numSecondTest = Convert.ToInt32(3);
            Console.WriteLine("Your remainder is " + (numTest % numSecondTest));*/

            /* Assignment Operators
            int num = 12;
            num += 3;
            Console.WriteLine(num);
            Console.ReadLine();

            int x = 12;
            x += 3;
            x -= 10;
            Console.WriteLine(x);
            Console.ReadLine();*/

            /*Increase by 1
            int xNum = 12;
            xNum ++;
            Console.WriteLine(xNum);

            int y = 12;
            y = y + 2;
            Console.WriteLine(y);

            int yNum = 12;
            ++yNum;
            Console.WriteLine(yNum);*/


            /* if statements
            int x = 2;
            int y = 1;
            if (x < y)
            {
                Console.WriteLine("y is larger than x");
            }

            int a = 1;
            int b = 2;
            if (a < b)
            {
                Console.WriteLine("b is larger than a");
            }*/

            /* if else statement practice
            int c = 30;
            int d = 90;
            if (c > d)
            {
                Console.WriteLine("c is larger than d");
            }
            else
            {
                Console.WriteLine("d is larger than c");
            }*/

            /* User input. Conversion. Nested if statements
            Console.WriteLine("What grade did you receive");
            int grade = Convert.ToInt32(Console.ReadLine());
            if (grade > 60)
            {
                Console.WriteLine("You have passed the course");
                if (grade == 100)
                {
                    Console.WriteLine("You received a perfect score");
                }
                else
                {
                    Console.WriteLine("You were " + (100 - grade) + " points from a perfect score");
                }
            }
            else
            {
                Console.WriteLine("You did not pass the course");
                if (grade == 0)
                {
                    Console.Write("You are not eligible to retake this course");
                }
                else
                {
                    Console.WriteLine("You were " + (50 - grade) + " points from passing");
                }*/

            /* User input. Conversion. if else if statements
            Console.WriteLine("Please guess my favorite number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 8)
            {
                Console.WriteLine("You got it!");
            }
            else if (num == 16)
            {
                Console.WriteLine("Hint: try dividing this one by 2.");
            }
            else if (num <= 17)
            {
                Console.WriteLine("You're pretty close.");
            }
            else
            {
                if (num >= 18)
                {
                    Console.WriteLine("You're way too high!");
                }
            }*/

            /*User input. Conversion. Switch statement practice.
            Console.WriteLine("What is your age?");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
                {
                case 3:
                    Console.WriteLine("toddler");
                    break;
                case 10:
                    Console.WriteLine("child");
                    break;
                case 15:
                    Console.WriteLine("teenager");
                    break;
                case 21:
                    Console.WriteLine("adult");
                    break;
                case 60:
                    Console.WriteLine("senior");
                    break;
                default:
                    Console.WriteLine("age is not set in the program");
                    break;
            }*/

            /* while loop practice
            Console.WriteLine("Let's count to 10");
            Console.ReadLine();
            int num = 1;
            while (num < 11)
            {
                Console.WriteLine(num);
                num++;
            }

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How many times would you like to see you name displayed?");
            int x = int.Parse(Console.ReadLine());
            while (x > 0)
            {
                Console.WriteLine(name);
                x--;

            }

            /*int num = 1;
            while (++num < 6)
            {
                Console.WriteLine(num);
            }*/

            /* for loop practice 
            for (int x = 1; x < 5; x++)
            {
                Console.WriteLine(x);
            }

            int y = 1;
            for ( ; y < 5; y++)
            {
                Console.WriteLine(y);
            }

            int z = 1;
            for ( ; z < 5; )
            {
                Console.WriteLine(z);
                z++;
            }*/

            /* Increment practice
            int x = 2;
            int y = 3;
            int z = ++y * x++;

            Console.WriteLine(z);*/

            /* Logical Operator Practice
            Console.WriteLine("This camp is for children only.");
            Console.WriteLine("Must be between the ages 5-12.");
            Console.WriteLine("Please enter your child's age.");
            int age = int.Parse(Console.ReadLine());
            bool oldEnough = (age > 6 && age < 13);
            Console.WriteLine(oldEnough);
            
            Console.WriteLine("Please enter your child's age.");
            int age = int.Parse(Console.ReadLine());
            bool oldEnough = (age > 6 && age < 13);
            Console.WriteLine(!oldEnough);*/

            /* Ternary Operators Practice 
            Console.WriteLine("Please enter a number:");
            int num = int.Parse(Console.ReadLine());
            var firstTest = (num % 2 == 0) ? "Your number is even" : "Your number is odd";
            var secondTest = (num < 10) ? " and it is a single digit." : " and it is larger than one digit.";
            Console.WriteLine($"{firstTest}{secondTest}");*/

            /* do while loop practice 
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a > 5);

            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < 5);*/

            /* breaks
            for (int x = 1; x < 8; x++)
            {
                if (x > 5)
                    break;
                Console.WriteLine(x);
            }*/

            

        }
    }
}










       

    
