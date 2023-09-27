// See https://aka.ms/new-console-template for more information
using System;
using Proyecto.Dominio;
using Proyecto.Persistencia;

namespace Proyecto.Consola
{
        public class Program
    {
        //private static IRepositorio _repo =new Repositorio(new AppContextS());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddEstablecimiento();
        }
        public static void AddEstablecimiento()
        {
            var Establecimientos = new Establecimientos
            {
                Codigo="68780",
                Nombre="Discoteca",
                Responsable="Humberto",
                Direccion="El cable",
                
            };
            _repo.AddEstablecimiento(Establecimientos);
        }
    }
}