using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSE445_Assignment_02
{
    class MultiCellBuffer
    {
        public static int count;
        private Int32 tempe;
        //private Int32 tail = 0;
        private static Semaphore writeData;
        private static Semaphore readData;
        private string[] bufferData;
        public MultiCellBuffer(Int32 numberOfBufferCelles)
        {
            lock (this)
            {
                count = 0;
                if(numberOfBufferCelles <= 3)
                {
                    bufferData = new string[numberOfBufferCelles];
                    tempe = numberOfBufferCelles;
                    //initialized and max                 
                    writeData = new Semaphore(numberOfBufferCelles, 3);
                    readData = new Semaphore(numberOfBufferCelles, 3);
                    for(int i =0; i < numberOfBufferCelles; i++)
                    {
                        bufferData[i] = "False";
                    }
                }

            }
        }
        //semaphore
        public string getOneCell()
        {
            readData.WaitOne();
            string getData = "";
            lock (this)
            {
                while (count == 0)
                {
                    Monitor.Wait(this);
                }
                for (int i = 0; i < tempe; i++)
                {
                    if (bufferData[i] != "False")
                    {
                        getData = bufferData[i];
                        bufferData[i] = "False";
                        /*tail = (tail + 1) % 3;
                        count++;*/
                        count--;
                        break;
                    }
                }
                readData.Release();
                Monitor.Pulse(this);
            }
            return getData;
        }
        public void setOneCell(string data,Stopwatch s)
        {
            writeData.WaitOne();
            lock (this)
            {
                while(count == 3)
                {
                    Monitor.Wait(this);
                }
                for(int i =0; i< tempe; i++)
                {
                    if (bufferData[i] == "False")
                    {
                        bufferData[i] = data;
                        /*tail = (tail + 1) % 3;
                        count++;*/
                        count++;
                        break;
                    }
                }
                writeData.Release();
                Monitor.Pulse(this);

            }
        }
    }
}
