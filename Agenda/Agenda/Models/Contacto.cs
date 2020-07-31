using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    [Table("Contactos")] //nombre de la tabla
    public class Contacto //clase Contacto
    {
        public int Id { get; set; } //Id
        [Required] //not null
        [MaxLength(30)] //varchar(30) Nombre
        public string Nombre { get; set; } //Nombre
        public ICollection<Telefono> Telefonos { get; set; } //FK, relacion - un contacto tiene varios telefonos
    }
}