using System;
using System.Collections.Generic;

namespace Proyecto.Dominio{
    public class Servicios

{
    public int Id {get;set;}
    public string Codigo {get;set;}
    public string Nombre {get;set;}
    public string Descripcion{get;set;}
    public string Categoria {get;set;}
    public List<Establecimientos> Establecimientos{get;set;}
}

}