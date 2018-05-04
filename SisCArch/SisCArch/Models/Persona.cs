using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisCArch.Models
{
    public class Persona
    {
        public int PersonaID {get; set;}
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public int DepartamentoID { get; set; }
        public string Pwd { get; set; }


    }
}