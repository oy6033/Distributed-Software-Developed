using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSE445_Assignment_02
{
    class HotelSupplier
    {
        public static Int32 oldPrice = 151;
        public static Int32 totalRoom = 50;
        public static string hotelsupplierName = "";
        Int32 num = 0;
        Int32 priceCount = 0;
        Random random = new Random();
        public static event priceCutEvent priceCut;
        public Int32 PricingModel()
        {
            Int32 price = random.Next(100, 150);
            //Console.WriteLine("PricingModel method is excuted {0}",oldPrice);
            return price;
        }

        public void orderReceived()
        {
            /* Console.WriteLine("HotelSupplier {0} is porcessing order", name);*/
            var watch = System.Diagnostics.Stopwatch.StartNew();
            string orderData = Program.cellBuffer.getOneCell();
            OrderClass order = Decoder.DecoderMethod(orderData);
            Thread thread = new Thread(() => OrderProcessing.OrderProcessed(order, getPrice(), hotelsupplierName, priceCount - 1));
            thread.Start();
        }


        public void rePricing(Int32 newPrice)
        {
            Mutex m = new Mutex(false, "MyMutex");
            m.WaitOne();
            if (num == 5)
            {
                num = 0;
            }

            //Console.WriteLine("new price {0}",newPrice);
            if (priceCut != null)
            {
                if (newPrice < oldPrice)
                {
                    priceCut(newPrice, Program.threads[num].Name);
                    priceCount = priceCount + 1;
                    num = num + 1;
                    // Console.WriteLine("rePricing method is excuted");
                }
                if(newPrice != oldPrice)
                {
                    oldPrice = newPrice;
                }
            }
            m.ReleaseMutex();
        }
        public void hotelFuction()
        {
            while(priceCount<= 10)
            {
                Thread.Sleep(1000);
                Int32 price = PricingModel();
                rePricing(price);
                hotelsupplierName = Thread.CurrentThread.Name;
            }
            //if priceCount > 10 stop
            Program.isRunning = false;
        }
        public Int32 getPrice() {
            return oldPrice;
        }
    }
}
