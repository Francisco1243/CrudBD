using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ConexionBD2.Models
{
    public class datosPersonales
    {
      [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage ="Este campo es obligatorio.")]
        public string Direccion { get; set; }

        [EmailAddress(ErrorMessage ="Ingresa un correo valido.")]
        public string Email { get; set; }

        [Range(0, Int32.MaxValue,ErrorMessage ="El valor{0} no es valido.")]
        [RegularExpression("^\\d+$", ErrorMessage ="Debe ingresar solo numeros.")]
        public string Telefono { get; set; }
    }

    public class datosPersonalesContex : DbContext
    {
        public DbSet<datosPersonales> datosPersonales { get; set; }
    }
}