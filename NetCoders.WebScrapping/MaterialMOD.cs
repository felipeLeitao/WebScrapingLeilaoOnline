using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoders.WebScrapping
{
    [Table("Material")]
    public class MaterialMOD
    {
        [Key]
        public int Codigo { get; set; }

        [Column("URL_IMAGEM")]
        public string UrlImagem { get; set; }

        public string Descricao { get; set; }

        public DateTime DataFinal { get; set; }

        public string Moeda { get; set; }

        [Required]
        public Decimal ValorInicial { get; set; }
    }
}
