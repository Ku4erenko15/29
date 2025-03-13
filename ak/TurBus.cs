using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ak
{
    class TurBus : Bus
    {
        private double excost;

        public double Excursioncost { get => excost; set => excost = value; }

        public TurBus(string brand, int seats, double price,double excost) :base (brand,seats,price)
        {
            excost = Seats * Price*1.1;
            this.Brand = brand;
            this.Seats = seats;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{Brand}\n{Seats}\n{Price}\n{excost}";
        }




    }
}
    

