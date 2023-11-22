using System;

namespace SGLicitacoes.Models
{
    public class BiddingInfo
    {

        public int Id { get; set; }
        public string Description { get; set; }

        public DateTime OpeningData { get;set; }
        public string Status { get; set; }
    }
}

