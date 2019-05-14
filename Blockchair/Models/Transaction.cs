using System;
using System.Collections.Generic;
using System.Text;

namespace Blockchair.Models
{
    public class Transaction
    {
        public long Block_ID { get; set; }
        public long ID { get; set; }
        public string Hash { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
        public int Version { get; set; }
        public int Lock_Time { get; set; }
        public bool Is_Coinbase { get; set; }
        public bool Has_Witness { get; set; }
        public int Input_Count { get; set; }
        public int Output_Count { get; set; }
        public long Input_Total { get; set; }
        public float Input_Total_USD { get; set; }
        public long Output_Total { get; set; }
        public float Output_Total_USD { get; set; }
        public long Fee { get; set; }
        public float Fee_USD { get; set; }
        public float Fee_Per_KB { get; set; }
        public float Fee_Per_KB_USD { get; set; }
        public float Fee_Per_KWU { get; set; }
        public float Fee_Per_KWU_USD { get; set; }
        public decimal CDD_Total { get; set; }
    }
}
