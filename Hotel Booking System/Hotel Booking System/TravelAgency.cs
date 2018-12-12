using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSE445_Assignment_02
{
    class TravelAgency
    {
        public static event newOrderEvent NewOrder;
        public static Stopwatch stopWatch;
        public static Random rnd = new Random();
/*        public TravelAgency1()
        {
            newRoomPrice = 0;
            oldRoomPrice = 151;
        }*/
        public void HotelFunction()
        {
            while (Program.isRunning)
            {
                Thread.Sleep(2000);
                createOrder(Thread.CurrentThread.Name);
            }
            Thread.Sleep(1000);
            Console.Write("\nThread {0} stop, becuase priceCount > 10\n", Thread.CurrentThread.Name);
            Console.ReadLine();
        }

        private void createOrder(string senderID)
        {
            string receiverID = "null";
            Int32 cardNo = rnd.Next(4000, 7000);
            Int32 p = rnd.Next(100, 150);
            Int32 orderRoom = rnd.Next(1, 5);
            OrderClass order = new OrderClass(senderID, cardNo, receiverID, p, orderRoom);
            string orderString = Encoder.EncoderMethod(order);
            Console.WriteLine("Hotel order has been created at {1}.", senderID, DateTime.Now.ToString("hh:mm:ss"));
            stopWatch = new Stopwatch();
            stopWatch.Start();
            Program.cellBuffer.setOneCell(orderString, stopWatch);
            NewOrder();
        }

        public void onSaleInformation(Int32 p, string senderID)
        {
            Console.WriteLine("Hotel are on sale: as low as ${1} per room!!!!!!!!!!!!!!!", Thread.CurrentThread.Name, p);
            createOrder(senderID);

        }

    }
}
