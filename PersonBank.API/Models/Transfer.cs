using System;
using System.ComponentModel.DataAnnotations;

namespace PersonBank.API.Models
{
    public class Transfer
    {
        public int Id { get; set; }
        public int TypeTransfer { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        [Required]
        public int Value { get; set; }
        public DateTime DateTransfer { get; set; }
    }
}
