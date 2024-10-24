using System.ComponentModel.DataAnnotations.Schema;

namespace EF_ESERCIZIO_FERRAMENTA_REFACTORY.Models
{

    [Table("Reparto")]
    public class Reparto
    {
        public int repartoID { get; set; }

        public string repartoCOD { get; set; } = null!;

        public string nome { get; set; } = null!;

        public string? fila { get; set; }


    }
}
