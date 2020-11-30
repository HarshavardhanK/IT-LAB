using System;

namespace DateTime_Add
{
    class Program
    {
        static int DAY = 0;
        static int YEAR = 2;
        static int SECOND = 5;
        static long NANO_TO_SECONDS = 1000000000;
        static String addTicks(String inputDate, Int64 ticks)
        {
            //subString contains values as: Day, Month, Year, Hours, Minutes, Seconds (in String format)
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
            for(int i=SECOND; i >= DAY; i--)
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
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Date Time Add!");
            Console.WriteLine("Enter date in format: DD:MM:YY:hh:mm:ss");

            String inputDate;
            inputDate = Console.ReadLine();

            Console.WriteLine("Enter number of nano seconds to add:");
            Int64 ticks = Int64.Parse(Console.ReadLine());

            Console.WriteLine("After Adding: " + addTicks(inputDate, ticks));
        }
    }
}
