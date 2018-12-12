using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE445_Assignment_02
{
    class Decoder
    {
        public static OrderClass DecoderMethod(string encodeData)
        {
            string[] orderList = encodeData.Split(' ');
            OrderClass order = new OrderClass(orderList[0], Convert.ToInt32(orderList[1]),
                orderList[2], Convert.ToInt32(orderList[3]), Convert.ToInt32(orderList[4]));
            return order;
        }
    }
}
