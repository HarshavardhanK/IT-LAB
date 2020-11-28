using System;

namespace IT_LAB_WEEK_3 {

    public delegate void PriceChangedEventHandler(int newPrice);

    public class Item {

        private string name;
        private int price;

        public string Name {

            get {
                return name;
            }

            set {
                name = value;
            }
        }

        public event PriceChangedEventHandler PriceChanged;

        public int Price {

            get {
                return price;
            }

            set {
                price = value;
                

                PriceChanged?.Invoke(value);
            }
        }

    }

    public class Item2 {

        public string Name { get; set; }
        public static int Cost;

        public Item2(string name, int cost) {
            Name = name;
            Cost = cost;
        }

        public double CalcGst() {
            return 0.08 * Cost;
        }
    }

    public delegate void TrafficDelegate();

    public class TrafficSignal {

        public void yellowSignal() {
            Console.WriteLine("Get ready to move");
        }

        public void greenSignal() {
            Console.WriteLine("Move");
        }

        public void redSignal() {
            Console.WriteLine("Stop");
        }

    }


    class Program {

        public static void priceChangeDetected(int newPrice) {
            Console.WriteLine("Price of the item changed to {0}", newPrice);
        }

        public static void quest1() {

            Item item = new Item();
            item.PriceChanged += priceChangeDetected;
            item.Price = 1299;

        }

        public static void quest2() {
            Item2 item = new Item2("iPhone X", 129000);
            Console.WriteLine(item.CalcGst());
        }

        public static void quest3() {
            TrafficDelegate trafDel;

            TrafficSignal trafSignal = new TrafficSignal();
            trafDel = trafSignal.redSignal;
            trafDel();
        }

        static void Main(string[] args) {

            quest3();
            

            //Quest 3
            
        }


    }

}
