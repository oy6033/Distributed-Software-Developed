using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSE445_Assignment_02
{
    public delegate void newOrderEvent();
    public delegate void priceCutEvent(Int32 price,string senderID);
    class Program
    {
        public static bool isRunning = true;
        public static MultiCellBuffer cellBuffer;
        public static Thread[] threads;
        static void Main(string[] args)
        {
            HotelSupplier hotel = new HotelSupplier();
            TravelAgency agency = new TravelAgency();
            //initializes size with 3
            cellBuffer = new MultiCellBuffer(3);
            Thread hotelFunction1 = new Thread(() => hotel.hotelFuction());
            Thread hotelFunction2 = new Thread(new ThreadStart(hotel.hotelFuction));
            hotelFunction1.Name = "1";
            hotelFunction2.Name = "2";
            hotelFunction1.Start();
            hotelFunction2.Start();
            HotelSupplier.priceCut += new priceCutEvent(agency.onSaleInformation);
            TravelAgency.NewOrder += new newOrderEvent(() => hotel.orderReceived());
            threads = new Thread[5];
            for (int i =0; i< 5;i++)
            {
                threads[i] = new Thread(() => agency.HotelFunction());
                threads[i].Name = (i + 1).ToString();
                threads[i].Start();
            }
        }
    }
}
