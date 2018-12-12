using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE445_Assignment_02
{
    class Encoder
    {
        private int countGetSenderID;
        private int countGetReceiverID;
        private int countGetCardNo;
        private int countGetAmount;

        /*public Encoder(int senderID, int cardNo, int receiverID, int amount)
        {
            countGetAmount = amount;
            countGetCardNo = cardNo;
            countGetSenderID = senderID;
            countGetReceiverID = receiverID;
        }*/
        public static string EncoderMethod(OrderClass order)
        {
            string encodeData;
            encodeData = order.getSenderID() +" "+ order.getCardNo().ToString() +" "+ order.getReceiverID() +" "
                + order.getAmount().ToString() + " "+ order.getOrderRoom();
            return encodeData;
        }

        public void count(OrderClass order)
        {
            countGetSenderID = order.getSenderID().Length;
            countGetReceiverID = order.getReceiverID().Length;
            countGetCardNo = order.getCardNo().ToString().Length;
            countGetAmount = order.getAmount().ToString().Length;
        }

        public int getSenderID()
        {
            return countGetSenderID;
        }
        public int getCardNo()
        {
            return countGetCardNo;
        }
        public int getAmount()
        {
            return countGetAmount;
        }
        public int getReceiverID()
        {
            return countGetReceiverID;
        }
    }
}
