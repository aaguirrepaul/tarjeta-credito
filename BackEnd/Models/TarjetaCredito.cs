using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class TarjetaCredito
    {   [Key]
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(100)")]
        public String Titular { get; set; }


        [Required]
        [Column(TypeName = "varchar(16)")]
        public String NumeroTarjeta { get; set; }


        [Required]
        [Column(TypeName = "varchar(5)")]
        public String FechaExpiracion { get; set; }


        [Required]
        [Column(TypeName = "varchar(3)")]
        public String CVV { get; set; }






    }
}
