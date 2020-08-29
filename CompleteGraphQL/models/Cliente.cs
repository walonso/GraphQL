
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompleteGraphQL
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]       
        public string Name { get; set; }

/// <summary>
        /// Clave del cliente
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [Range(1, 999999, ErrorMessage = "Range")]
        public int Clave { get; set; }

        /// <summary>
        /// Razón social del cliente 
        /// como esta registrado ante hacienda
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [Column(TypeName = "VARCHAR(250)")]
        public string  RazonSocial { get; set; }
        
        /// <summary>
        /// Nombre comercial del cliente
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [Column(TypeName = "VARCHAR(250)")]
        public string NombreComercial { get; set; }

        public List<Caducidad> Caducidades {get; set; }
    }
}