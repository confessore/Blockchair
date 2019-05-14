using Blockchair.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Blockchair
{
    public class BlockchairClient
    {
        string BaseAddress = "https://api.blockchair.com/";
        string BitCoinAddressEndpoint = "bitcoin/dashboards/address/";
        string BitCoinTransactionEndpoint = "bitcoin/dashboards/transaction/";

        string GetUrl(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
                return reader.ReadToEnd();
        }

        public Dashboard BitCoinAddressInfo(string address) =>
            JsonConvert.DeserializeObject<Dashboard>(GetUrl(BaseAddress + BitCoinAddressEndpoint + address));

        public Dashboard BitCoinTransactionInfo(string transaction) =>
            JsonConvert.DeserializeObject<Dashboard>(GetUrl(BaseAddress + BitCoinTransactionEndpoint + transaction));
    }
}
