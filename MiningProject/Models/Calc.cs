using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningProject.Models
{
    [Table("Calcs")]
    public class Calc
    {
        [Key]
        public int PK_Calc { get; set; }

        [Column("MyTask")]
        //[ForeignKey("Model")]
        public int MyTask { get; set; }

        [ForeignKey("MyTask")]
        public virtual MyTask FK_MyTasks { get; set; }

        [Column("NameCalc"), Required]
        public string NameCalc { get; set; }

        [Column("Participation"), Required]
        public string Participation { get; set; }

        public virtual ICollection<LayersCalculation> LayersCalculations { get; set; }
    }
}
