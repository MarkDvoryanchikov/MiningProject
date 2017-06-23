using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningProject.Models
{
    [Table("LayersCalculations")]
    public class LayersCalculation
    {
        [Key]
        public int PK_LayersCalculation { get; set; }

        [Column("Calc")]
        //[ForeignKey("Model")]
        public int Calc { get; set; }

        [ForeignKey("Calc")]
        public virtual Calc FK_Calcs { get; set; }

        [Column("Class"), Required]
        public string Class { get; set; }

        [Column("C1")]
        public double C1 { get; set; }

        [Column("C2")]
        public double C2 { get; set; }

        [Column("C3")]
        public double C3 { get; set; }

        [Column("C4")]
        public double C4 { get; set; }

        [Column("C5")]
        public double C5 { get; set; }

        [Column("C6")]
        public double C6 { get; set; }
    }
}
