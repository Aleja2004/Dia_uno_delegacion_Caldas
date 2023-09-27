using Proyecto.Dominio;
using System.Collections.Generic;
namespace Proyecto.Persistencia
{
    public interface IRepositorio
    {
        //Establecimiento
        IEnumerable<Establecimientos> GetAllEstablecimientos(); //Consultar Establecimientos
        Establecimientos AddEstablecimientos(Establecimientos establecimientos); //Crear Establecimientos
        Establecimientos UpdateEstablecimientos(Establecimientos establecimientos); //Actualizar Establecimientos
        void DeleteEstablecimientos(int establecimientosId); //Eliminar Establecimientos
        Establecimientos GetEstablecimientos(int establecimientosId); //Consultar un Establecimiento

        // Manzanas
        IEnumerable<Manzanas> GetAllManzanas(); // Consultar Manzanas
        Manzanas AddManzanas(Manzanas manzanas); // Crear Manzanas
        Manzanas UpdateManzanas(Manzanas manzanas); // Actualizar Manzanas
        void DeleteManzanas(int manzanasId); // Eliminar Manzanas
        Manzanas GetManzanas(int manzanasId); // Buscar una Manzana

        // Municipio
        IEnumerable<Municipios> GetAllMunicipios(); // Consultar Municipios
        Municipios AddMunicipios(Municipios municipios); // Crear Municipios
        Municipios UpdateMunicipios(Municipios municipios); // Actualizar Municipios
        void DeleteMunicipios(int municipiosId); // Eliminar Municipios
        Municipios GetMunicipios(int municipiosId); // Buscar un Municipio

       

        // Servicios
        IEnumerable<Servicios> GetAllServicios(); // Consultar Servicios
        Servicios AddServicios(Servicios servicios); // Crear Servicios
        Servicios UpdateServicios(Servicios servicios); // Actualizar Servicios
        void DeleteServicios(int serviciosId); // Eliminar Servicios
        Servicios GetServicios(int serviciosId); // Buscar un Servicio
    }
}