using System;
using System.Collections.Generic;

namespace Proyecto.Dominio 
{
    public class Registro_Cuidadora:Personas
    {
        public string Codigo {get;set;}
        public List <Manzanas> Manzanas {get;set;}
        
    }
}