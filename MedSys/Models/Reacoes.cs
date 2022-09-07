using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedSys.Models
{
    [Table("Reações")]
    public class Reacoes
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("TipoReacao")]
        [Display(Name = "Reação")]
        public string Reacao { get; set; }
    }
}
