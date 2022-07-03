using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    public class Calculate_fare
    {
        private string id;
        protected double hours;
       
      public void sethours_id(double h, string str)
        {
            hours = h;
            id = str;
        }
        protected void getid()
        {
            Console.WriteLine("The id is " + id);
        }

        
        public double gethours()
        {
            return hours;
        }

        public void Display(double total)
        {
            getid();
            Console.WriteLine("The garage charges are $" + total);
        }
        public virtual void calculatefare()
        {
            double total = 0f;
            Display(total);
        }

    }
    class bike : Calculate_fare
    {
       private double total;

        public override void calculatefare()
        {

            total = 2.00f;
            if (hours > 3 && hours < 24)
            {
                total = (float)(total + (hours - 3) * 0.5);
            }
            else if (hours >= 24)
            {
                total = 10;
            }

            Display(total);
        }
    }
    class cars : Calculate_fare
    {
       
        private double total;
        public override void calculatefare()
        {
            total = 4.00f;
            if (hours > 3 && hours < 24)
            {
                total = (float)(total + (hours - 3) * 1);
            }
            else if (hours >= 24)
            {
                total = 20;
            }

            Display(total);
        }

    }
        class bus : Calculate_fare
        {
        private double total;
        public  override void calculatefare()
            {
                total = 6.00f;
                if (hours > 3 && hours < 24)
                {
                    total = (float)(total + (hours - 3) * 1.5);
                }
                else if (hours >= 24)
                {
                    total = 30;
                }
                Display(total);

            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the vehicle type:Bike/Car/Bus");
                string s = Console.ReadLine();

                Console.WriteLine("Enter the id");
                string id = Console.ReadLine();
                Console.WriteLine("Enter number of hours");
                double hr = Convert.ToDouble(Console.ReadLine());
           
            Calculate_fare bas;
           

          
            if (s == "Bike")
                {
                bike bik = new bike();
                bik.sethours_id(hr, id);
                bas = bik;
                  bas.calculatefare();
                }
                else if (s == "Car")

                {
                cars ca = new cars();
                ca.sethours_id(hr, id);

                bas =ca;
                bas.calculatefare();
            }

                else if (s == "Bus")
                {
                bus bu = new bus();
                bu.sethours_id(hr, id);
                bas =bu;
                bas.calculatefare();

            }

             
        }
        }


    
}