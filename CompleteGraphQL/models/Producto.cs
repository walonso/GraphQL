using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompleteGraphQL
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Id de la categoría
        /// </summary>
        [Required(ErrorMessage = "Required")]
        public int CategoriaId { get; set; }

        /// <summary>
        /// Clave del producto
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [Range(1, 999, ErrorMessage = "Range")]
        public int Clave { get; set; }

        /// <summary>
        /// Nombre del producto
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [Column(TypeName = "VARCHAR(80)")]
        public string Nombre { get; set; }

        public List<Caducidad> Caducidades {get; set; }
    }
}