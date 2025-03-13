using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ak
{
    class Bus
    {
        private string brand;
        private int seats;
        private double price;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("");
                brand = value;
            }
        }

        public int Seats
        {
            get { return seats; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("");
                seats = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("");
                price = value;
            }
        }

        public Bus(string brand, int seats, double price)
        {
            this.Brand = brand;
            this.Seats = seats;
            this.Price = price;
        }

        public double AllSeatsCost(double ticketPrice)
        {
            if (ticketPrice < 0)
                throw new ArgumentException("");

            return Seats * Price;
        }



    }
}
