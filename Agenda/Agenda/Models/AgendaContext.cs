using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

//Contexto - Clase de enlace entre la aplicacion y la DB

namespace Agenda.Models
{
    public class AgendaContext : DbContext //clase deriva de clase particular de EntityFramework
    {
        //la clase DbContext tiene un constructor que recibe la referencia hacia una cadena de conexión
        //ConnAgendaDb es el nombre de la cadena de conexion
        public AgendaContext() : base("ConnAgendaDb")
        {

        }


        //hacer referencia a las tablas mediante propiedades publicas genericas DbSet
        //ya que son genericas, le pongo el tipo de dato del modelo
        public DbSet<Contacto> Contactos { get; set; } //referencia a tabla contactos
        public DbSet<Telefono> Telefonos { get; set; } //referencia a tabla telefonos
    }
}