using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompleteGraphQL
{
    public class Caducidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]       
        public int ProductoId { get; set; }

        public Producto Producto { get; set; }

        [Required(ErrorMessage = "Required")]
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = "Required")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "Required")]
        public DateTime Fecha { get; set; }
    }
}