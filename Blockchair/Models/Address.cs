using System;

namespace Blockchair.Models
{
    public class Address
    {
        public string Type { get; set; }
        public string Script_Hex { get; set; }
        public long Balance { get; set; }
        public float Balance_USD { get; set; }
        public long Received { get; set; }
        public float Received_USD { get; set; }
        public long Spent { get; set; }
        public float Spent_USD { get; set; }
        public int Output_Count { get; set; }
        public int Unspent_Output_Count { get; set; }
        public DateTime? First_Seen_Receiving { get; set; }
        public DateTime? Last_Seen_Receiving { get; set; }
        public DateTime? First_Seen_Spending { get; set; }
        public DateTime? Last_Seen_Spending { get; set; }
        public int Transaction_Count { get; set; }
    }
}
