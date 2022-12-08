using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaTecnicaSebrae.Models
{
    [Table("Conta")]
    public class ContaDTO
    {
        [Key]
        public Int64? Id { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }

    }
}
