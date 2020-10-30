using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFW_CodeFirst.Models
{
    [Table("manufacturer")]
    class Manufacturer
    {
        [Key]
        [Column(TypeName = "int(10)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }
    }
}
