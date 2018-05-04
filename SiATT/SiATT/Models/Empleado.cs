using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace SiATT.Models
{
    public class Empleado
    {
        public int ID_Empleado { get; set; }

        public int Id_Departamento { get; set; }

        public int Id_Ubicacion { get; set; }

        public string Nombre { get; set; }

        public string Pwd { get; set; }


    }
    public class EmpleadoDBContext : DbContext
    {
       public DbSet<Empleado> Empleados { get; set; }
    }
}