using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE445_Assignment_02
{
    class OrderProcessing
    {
        public static void OrderProcessed(OrderClass order, Int32 unitPrice, string name,Int32 times)
        {
            if(order.getCardNo()<=7000 && order.getCardNo() >= 5000)
            {
                if(HotelSupplier.totalRoom > order.getOrderRoom())
                {
                    double Tax = 0.068;
                    Int32 LocationCharge = 100;
                    Int32 payment = Convert.ToInt32((unitPrice + unitPrice * (1 + Tax) + LocationCharge)*order.getOrderRoom());
                    HotelSupplier.totalRoom = HotelSupplier.totalRoom - order.getOrderRoom();
                    TravelAgency.stopWatch.Stop();
                    Console.WriteLine("---------------------------------------------------------------\n" +
                        "HotelSupplier {4} is processing order\nThe order has been processed successfully which from Agency {0}.\nOrder Detail: \nOrder Payment: ${1}  Ordered Room: {2}  " +
                        "Avaiable Room: {3} \nOrder processing time: {5}ms PriceCut times: {6}\n---------------------------------------------------------------\n" +
                        "", order.getSenderID(), payment, order.getOrderRoom(), 
                        HotelSupplier.totalRoom, name,TravelAgency.stopWatch.ElapsedMilliseconds.ToString(),times);
//                    Console.WriteLine("\nOrder Detail: ");
//                   Console.WriteLine("\nOrder Payment: {0}  Ordered Room: {1}  Avaiable Room: {2}",payment,order.getOrderRoom(), HotelSupplier1.totalRoom);
                }
                else
                {
                    Console.WriteLine("\nAgency {0}'s order is canceled because Hotel is full",order.getSenderID());
                }
            }
            else
            {
                Console.WriteLine("Agency {0}'s order is canceled, because the credit card {1} is invalid\n",order.getSenderID(),order.getCardNo());
            }
        }
    }
}
