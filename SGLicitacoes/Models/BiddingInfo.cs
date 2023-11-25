using System;
using System.ComponentModel.DataAnnotations;

namespace SGLicitacoes.Models
{
    public class BiddingInfo
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Digite a descrição de sua licitação!")]
        public string Description { get; set; }

        public DateTime OpeningData { get;set; }

        [Required(ErrorMessage = "Defina o status da sua licitação!")]
        public string Status { get; set; }
    }
}

