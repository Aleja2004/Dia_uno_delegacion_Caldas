using System ;
using System.Collections.Generic;

namespace Proyecto.Dominio
{
    public class Municipios
    {
        public int Id {get;set;}
        public string Departamento {get;set;}
        public string Nombre {get;set;}
        public List<Manzanas> Manzanas {get;set;}
    }
}