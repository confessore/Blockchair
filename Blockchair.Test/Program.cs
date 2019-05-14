using System;
using System.Linq;

namespace Blockchair.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //1J5MYPMFFM1ikGLsQRaZAUtBkdWHktfDMX
            var client = new BlockchairClient();
            var address = client.BitCoinAddressInfo("bc1q2rdpyt8ed9pm56u9t0zjf94zrdu6gufa47pf62").Data.FirstOrDefault().Value.Address;
            foreach (var property in address.GetType().GetProperties())
                Console.WriteLine($"{property.Name}                {property.GetValue(address)}");
            var transaction = client.BitCoinTransactionInfo("90ae2064c51de2293e0d7590532e4a9c81d00bcfec4ba51ae859c8f5e4c14c80").Data.FirstOrDefault().Value.Transaction;
            foreach (var property in transaction.GetType().GetProperties())
                Console.WriteLine($"{property.Name}                {property.GetValue(transaction)}");
            Console.Read();
        }
    }
}
