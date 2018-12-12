using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE445_Assignment_02
{
    class OrderClass
    {
        private string senderID;
        private int cardNo;
        private string receiverID;
        private int amount;
        private int orderedRoom;

        //constructor
        public OrderClass(string senderID, int cardNo, string receiverID, int amount, int aroom)
        {
            this.amount = amount;
            this.cardNo = cardNo;
            this.senderID = senderID;
            this.receiverID = receiverID;
            orderedRoom = aroom;
        }

        public string getSenderID()
        {
            return senderID;
        }
        public int getCardNo()
        {
            return cardNo;
        }
        public int getAmount()
        {
            return amount;
        }
        public string getReceiverID()
        {
            return receiverID;
        }
        public int getOrderRoom()
        {
            return orderedRoom;
        }
    }
}
