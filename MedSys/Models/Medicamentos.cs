using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedSys.Models
{
    [Table("Medicamentos")]
    public class Medicamentos
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("NomeMedicamento")]
        [Display(Name = "Nome")]
        public string NomeMedicamento { get; set; }

        [Column("LoteMedicamento")]
        [Display(Name = "Lote")]
        public int LoteMedicamento { get; set; }

        [Column("TipoMedicamento")]
        [Display(Name = "Tipo (comprimido, gotas)")]
        public string TipoMedicamento { get; set; }
    }
}
