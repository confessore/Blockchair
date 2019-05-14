using Blockchair.Models;

namespace Blockchair.Interfaces
{
    public interface IBlockchairClient
    {
        Dashboard BitCoinAddressInfo(string address);
        Dashboard BitCoinTransactionInfo(string transaction);
    }
}
