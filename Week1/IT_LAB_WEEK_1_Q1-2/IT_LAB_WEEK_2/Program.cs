using System;

namespace IT_LAB_WEEK_2 {

    class Program {

        public static void addNums() {

            Console.WriteLine("Enter numbers: ");
            int num1, num2;
            int.TryParse(Console.ReadLine(), out num1);
            int.TryParse(Console.ReadLine(), out num2);

            int res = num1 + num2;
            Console.WriteLine("The result of addition of {0} and {1} is {2}", num1, num2, res);
            //int num2 = int.TryParse(w
        }

        public static void Main(string[] args) {

            //Console.WriteLine("Hello, there!");
            //addNums();
            arithmetic();
            //String res = addTime("12:);

        
        }

        public static void arithmetic() {

            Console.WriteLine("Enter two numbers");

            int num1, num2;
            int.TryParse(Console.ReadLine(), out num1);
            int.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);

            switch(choice) {

                case 1:
                    Console.WriteLine("Sum of {0} and {1} is {2}", num1, num2, num1 + num2); break;
                case 2:
                    Console.WriteLine("Difference of {0} and {1} is {2}", num1, num2, num1 - num2); break;
                case 3:
                    Console.WriteLine("Product of {0} and {1} is {2}", num1, num2, num1 * num2); break;
                case 4:
                    Console.WriteLine("Quotient of {0} and {1} is {2}", num1, num2, num1 / num2); break;
                default:
                    Console.WriteLine("invalid option"); break;

            }
        }

        public static String addTime(String inputDate, Int64 ticks) {

            int DAY = 0;
            int YEAR = 2;
            int SECOND = 5;
            long NANO_TO_SECONDS = 1000000000;


            String[] subStrings = inputDate.Split(':');
            Int64 seconds = (ticks / NANO_TO_SECONDS);
            Int64 carry = seconds;

            String result = "";
            String dayTemp = "";
            Int64 add;

            //Shuffle "Year" and "Day" to make the "metrics" in increasing order (from Seconds to Years)
            String temp = subStrings[0];
            subStrings[0] = subStrings[2];
            subStrings[2] = temp;

            //The max values for each "metric": Day, Month, Year, Hours, Minutes, Seconds
            Int64[] mods = { 31, 12, 100, 24, 60, 60 };

            //Loop across input and build result string
            for (int i = SECOND; i >= DAY; i--)
            {
                add = (carry + Int64.Parse(subStrings[i])) % mods[i];
                carry = (carry + Int64.Parse(subStrings[i])) / mods[i];

                //result initially holds resultant ":hh:mm:ss"
                //dayTemp initially holds resultant "DD:MM:YY"
                if (i > YEAR)
                    result = ":" + (add + result);
                else if (i != DAY)
                    dayTemp += ((add) + ":");
                else
                    dayTemp += (add);
            }

            //Combine result and dayTemp
            result = (dayTemp + result);

            return result;


        }

    }
}