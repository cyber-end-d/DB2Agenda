using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    [Table("Telefonos")] //Nombre de la tabla
    public class Telefono //clase Telefono
    {
        public int Id { get; set; } //Id
        [Required] //not null
        [MaxLength(10)] //varchar(10) Numero
        public string Numero { get; set; } //Numero de telefono
        [Required] //not null
        [MaxLength(30)] //varchar(30) Nombre
        public string Nombre { get; set; } //Nombre, que tipo de telefono
        public Contacto Contacto { get; set; } //FK, relacion - a que contacto pertenece el telefono
        public int ContactoId { get; set; } //asocia con la de arriba, crea FK usando nombre
    }
}