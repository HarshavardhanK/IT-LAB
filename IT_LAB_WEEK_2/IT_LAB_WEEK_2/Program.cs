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
            //int num2 = int.TryParse
        }

        public static void Main(string[] args) {

            //Console.WriteLine("Hello, there!");
            //addNums();
            //arithmetic();

            //addTime();

        
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

        public static void addTime() {

            int day_, month_, year_, hour_, minutes_, seconds_;

            string day = Console.ReadLine();
            string month = Console.ReadLine();
            string year = Console.ReadLine();

            string hour = Console.ReadLine();
            String minutes = Console.ReadLine();
            string seconds = Console.ReadLine();

            int.TryParse(day, out day_);
            int.TryParse(month, out month_);
            int.TryParse(year, out year_);

            int.TryParse(hour, out hour_);
            int.TryParse(minutes, out minutes_);
            int.TryParse(seconds, out seconds_);

            if(day_ < 0 || day_ > 31) {
                Console.WriteLine("Invalid day");
                return;

            } else if(month_ < 0 || month_ > 12) {
                Console.WriteLine("Invalid month");
                return;

            } else if(hour_ < 0 || hour_ > 24) {
                Console.WriteLine("Invalid hour");
                return;

            } else if(minutes_ < 0 || minutes_ > 60) {
                Console.WriteLine("Invalid minutes");
            }

           // Console.WriteLine("Add ticks");
            long start = 10000000;
            long end = 999999999999;

            Console.WriteLine("Enter ticks");
            long ticks;

            long.TryParse(Console.ReadLine(), out ticks);

            if (!(ticks > start && ticks < end)) {
                return;
            }

            DateTime dt = new DateTime(year_, month_, day_, hour_, minutes_, seconds_);
            DateTime dt2 = dt.AddTicks(ticks);


            Console.WriteLine(dt2);


            
        }

    }
}