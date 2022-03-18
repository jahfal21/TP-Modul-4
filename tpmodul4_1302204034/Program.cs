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
            //Console.Write("tes");
            HaloGeneric<string> halo = new HaloGeneric<string>();
            //String x = Console.ReadLine();
            String x = "Jahfal Mudrik Ramadhan!";
            halo.SapaUser(x);
        }
    }

    public class HaloGeneric<T>
    {
        public void SapaUser(T x)
        {
            Console.WriteLine("Hallo " + x);
        }
    }
}
