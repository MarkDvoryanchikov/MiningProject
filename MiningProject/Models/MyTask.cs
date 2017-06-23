using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiningProject.Models
{
    [Table("MyTasks")]
    public class MyTask
    {
        [Key]
        public int PK_Task { get; set; }

        [Column("TaskName"), Required]
        public string TaskName { get; set; }

        [Column("Time"), Required]
        public DateTime Time { get; set; }

        public virtual ICollection<Layer> Layers { get; set; }

        public virtual ICollection<Calc> Calcs { get; set; }
    }
}
