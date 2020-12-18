using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectProgra2020.Models
{
 [Table("t_usuario")]
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Required(ErrorMessage="Por favor, ingrese el número de documento")]
        [Display( Name = "Número de documento")]
        [StringLength(8, MinimumLength=8, ErrorMessage="Debe ingresar un número minimo de 8 dígitos")]
        [RegularExpression(@"^([0-9]{8})$", ErrorMessage = "Ingresa un numero valido")]

        [Column("dni")]
        public string Dni { get; set; }
        [Required(ErrorMessage="Por favor, Ingrese el nombre")]
        [StringLength(50, MinimumLength=2)]

        [Column("nom")]
        public string Nombre { get; set; }
        [Required(ErrorMessage="Por favor, ingrese el apellido")]
        [StringLength(50, MinimumLength=2)]

        [Column("ape")]
        public string Apellido { get; set; }
        [Required(ErrorMessage="Seleccione uno")]

        [Column("sex")]
        public char Sexo { get; set; }
        [Required(ErrorMessage="Ingrese un email")]

        [Column("email")]
        public string Email { get; set; }
        [Required(ErrorMessage="Ingrese un celular de contacto")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([9]{1}[0-9]{8})$", ErrorMessage = "Ingresa un numero celular valido")]

        [Column("celu")]
        public string Celular { get; set; }

        [Required(ErrorMessage="Debe ingresar una fecha")]
        [DataType(DataType.Date)]

        [Column("fec")]
        public DateTime? FecNac { get; set; }

        [Column("foto")]
        public byte[] Picture { get; set; }

        [NotMapped]
        public String imgData { get; set; }

        [NotMapped]
        public String Respuesta { get; set; }
    }
}