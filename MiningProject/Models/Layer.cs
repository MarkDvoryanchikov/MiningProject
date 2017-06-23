using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningProject.Models
{
    [Table("Layers")]
    public class Layer
    {
        [Key]
        public int PK_Layer { get; set; }

        [Column("MyTask")]
        public int MyTask { get; set; }

        [ForeignKey("MyTask")]
        public virtual MyTask FK_MyTasks { get; set; }

        [Column("NumberLayer"), Required]
        public int Numberlayer { get; set; }

        [Column("NameLayer"), Required]
        public string NameLayer { get; set; }

        [Column("C1")]
        public double? C1 { get; set; }

        [Column("C2")]
        public double? C2 { get; set; }

        [Column("C3")]
        public double? C3 { get; set; }

        [Column("C4")]
        public double? C4 { get; set; }

        [Column("C5")]
        public double? C5 { get; set; }

        [Column("C6")]
        public double? C6 { get; set; }

        [Column("C7")]
        public double? C7 { get; set; }

        [Column("C8")]
        public double? C8 { get; set; }

        [Column("C9")]
        public double? C9 { get; set; }

        [Column("C10")]
        public double? C10 { get; set; }

        [Column("C11")]
        public double? C11 { get; set; }

        [Column("C12")]
        public double? C12 { get; set; }

        [Column("C13")]
        public double? C13 { get; set; }

        [Column("C14")]
        public double? C14 { get; set; }
    }
}
