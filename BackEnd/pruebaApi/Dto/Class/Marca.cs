using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaApi.Model
{
    [Table("Marca", Schema = "dbo")]
    public class Marca
    {
        [Key]

        public  int ID { get; set; }
        public string Descripcion { get; set; }
    }
}
