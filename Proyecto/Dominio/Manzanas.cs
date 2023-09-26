using System;
using System.Collections.Generic;

namespace Proyecto.Dominio
{
    public class Manzanas

    {
        public int Id {get;set;}
        public string Codigo {get;set;}
        public string Nombre {get;set;}
        public string Localidad {get;set;}
        public string Direccion {get;set;}
        public List<Servicios> Servicios {get;set;}
    }
}