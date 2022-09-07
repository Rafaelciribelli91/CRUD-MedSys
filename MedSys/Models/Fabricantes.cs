using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedSys.Models
{
    [Table("Fabricantes")]
    public class Fabricantes
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }


        [Column("NumeroRegistro")]
        [Display(Name = "Número")]
        public int Registro { get; set; }


        [Column("NomeFabricante")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }


        [Column("Sede")]
        [Display(Name = "Sede")]
        public string Sede { get; set; }
    }
}
