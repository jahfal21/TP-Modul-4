using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("tesr");
            DataGeneric<String> data = new DataGeneric<string>("1302204034");
            data.PrintData();
        }
    }

    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + this.data);
        }
    }
}
