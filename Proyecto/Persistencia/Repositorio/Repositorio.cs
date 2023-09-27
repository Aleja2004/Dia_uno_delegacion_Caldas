using System.Linq;//Me permite hacer consultas con una sintaxis mas sencilla 
using System.Collections.Generic;
using Proyecto.Dominio;

namespace Proyecto.Persistencia
{
    
    public class Repositorio: IRepositorio
    {
        private readonly AppContextS _appContextS;
        public Repositorio (AppContextS appContextS)
        {
            _appContextS=appContextS;
        }
        //Establecimiento
       IEnumerable<Establecimientos> GetAllEstablecimientos()
        {
            return _appContextS.Establecimientos;
        }
         public Establecimientos AddEstablecimiento(Establecimientos establecimiento)
        {
            var establecimientoCreado = _appContextS.Establecimientos.Add(establecimiento);
            _appContextS.SaveChanges();
            return establecimientoCreado.Entity;
        }

        public void DeleteEstablecimiento(int establecimientoId)
        {
            var establecimientoEncontrado = _appContextS.Establecimientos.FirstOrDefault(e => e.Id == establecimientoId);

            if (establecimientoEncontrado == null)
                return;

            _appContextS.Establecimientos.Remove(establecimientoEncontrado);
            _appContextS.SaveChanges();
        }

        public Establecimientos GetEstablecimiento(int establecimientoId)
        {
            return _appContextS.Establecimientos.FirstOrDefault(e => e.Id == establecimientoId);
        }

        public Establecimientos UpdateEstablecimiento(Establecimientos establecimiento)
        {
            var establecimientoEncontrado = _appContextS.Establecimientos.FirstOrDefault(e => e.Id == establecimiento.Id);

            if (establecimientoEncontrado != null)
            {
                establecimientoEncontrado.Codigo = establecimiento.Codigo;
                establecimientoEncontrado.Nombre = establecimiento.Nombre;
                establecimientoEncontrado.Responsable = establecimiento.Responsable;
                establecimientoEncontrado.Direccion = establecimiento.Direccion;

                _appContextS.SaveChanges();
            }

            return establecimientoEncontrado;
        }



        // Manzanas
        public IEnumerable<Manzanas> GetAllManzanas()
        {
            return _appContextS.Manzanas;
        }

        public Manzanas AddManzana(Manzanas manzana)
        {
            var manzanaCreada = _appContextS.Manzanas.Add(manzana);
            _appContextS.SaveChanges();
            return manzanaCreada.Entity;
        }

        public void DeleteManzana(int manzanaId)
        {
            var manzanaEncontrada = _appContextS.Manzanas.FirstOrDefault(m => m.Id == manzanaId);

            if (manzanaEncontrada == null)
                return;

            _appContextS.Manzanas.Remove(manzanaEncontrada);
            _appContextS.SaveChanges();
        }

        public Manzanas GetManzana(int manzanaId)
        {
            return _appContextS.Manzanas.FirstOrDefault(m => m.Id == manzanaId);
        }

        public Manzanas UpdateManzana(Manzanas manzana)
        {
            var manzanaEncontrada = _appContextS.Manzanas.FirstOrDefault(m => m.Id == manzana.Id);

            if (manzanaEncontrada != null)
            {
                manzanaEncontrada.Codigo = manzana.Codigo;
                manzanaEncontrada.Nombre = manzana.Nombre;
                manzanaEncontrada.Localidad = manzana.Localidad;
                manzanaEncontrada.Direccion = manzana.Direccion;
                manzanaEncontrada.Servicios = manzana.Servicios;

                _appContextS.SaveChanges();
            }

            return manzanaEncontrada;
        }




        // Municipios
        public IEnumerable<Municipios> GetAllMunicipios()
        {
            return _appContextS.Municipios;
        }

        public Municipios AddMunicipio(Municipios municipio)
        {
            var municipioCreado = _appContextS.Municipios.Add(municipio);
            _appContextS.SaveChanges();
            return municipioCreado.Entity;
        }

        public void DeleteMunicipio(int municipioId)
        {
            var municipioEncontrado = _appContextS.Municipios.FirstOrDefault(m => m.Id == municipioId);

            if (municipioEncontrado == null)
                return;

            _appContextS.Municipios.Remove(municipioEncontrado);
            _appContextS.SaveChanges();
        }

        public Municipios GetMunicipio(int municipioId)
        {
            return _appContextS.Municipios.FirstOrDefault(m => m.Id == municipioId);
        }

        public Municipios UpdateMunicipio(Municipios municipio)
        {
            var municipioEncontrado = _appContextS.Municipios.FirstOrDefault(m => m.Id == municipio.Id);

            if (municipioEncontrado != null)
            {
                municipioEncontrado.Codigo = manzana.Codigo;
                municipioEncontrado.Nombre = manzana.Nombre;
                municipioEncontrado.Localidad = manzana.Localidad;
                municipioEncontrado.Direccion = manzana.Direccion;
                municipioEncontrado.Servicios = manzana.Servicios;

                _appContextS.SaveChanges();
            }

            return municipioEncontrado;
        }




         // Servicios
        public IEnumerable<Servicios> GetAllServicios()
        {
            return _appContextS.Servicios;
        }

        public Servicios AddServicio(Servicios servicio)
        {
            var servicioCreado = _appContextS.Servicios.Add(servicio);
            _appContextS.SaveChanges();
            return servicioCreado.Entity;
        }

        public void DeleteServicio(int servicioId)
        {
            var servicioEncontrado = _appContextS.Servicios.FirstOrDefault(m => m.Id == servicioId);

            if (servicioEncontrado == null)
                return;

            _appContextS.Servicios.Remove(servicioEncontrado);
            _appContextS.SaveChanges();
        }

        public Servicios GetServicio(int servicioId)
        {
            return _appContextS.Servicios.FirstOrDefault(m => m.Id == servicioId);
        }

        public Servicios UpdateServicio(Servicios servicio)
{
    var servicioEncontrado = _appContextS.Servicios.FirstOrDefault(s => s.Id == servicio.Id);

    if (servicioEncontrado != null)
    {
        servicioEncontrado.Codigo = servicio.Codigo;
        servicioEncontrado.Nombre = servicio.Nombre;
        servicioEncontrado.Descripcion = servicio.Descripcion;
        servicioEncontrado.Categoria = servicio.Categoria;
        servicioEncontrado.Establecimientos = servicio.Establecimientos;

        _appContextS.SaveChanges();
    }

    return servicioEncontrado;
        }

         // Registro_Cuidadora
        public IEnumerable<Registro_Cuidadora> GetAllRegistroCuidadoras()
        {
            return _appContextS.RegistroCuidadoras;
        }

        public Registro_Cuidadora AddRegistroCuidadora(Registro_Cuidadora cuidadora)
        {
            var cuidadoraCreada = _appContextS.RegistroCuidadoras.Add(cuidadora);
            _appContextS.SaveChanges();
            return cuidadoraCreada.Entity;
        }

        public void DeleteRegistroCuidadora(int cuidadoraId)
        {
            var cuidadoraEncontrada = _appContextS.RegistroCuidadoras.FirstOrDefault(c => c.Id == cuidadoraId);

            if (cuidadoraEncontrada == null)
                return;

            _appContextS.RegistroCuidadoras.Remove(cuidadoraEncontrada);
            _appContextS.SaveChanges();
        }

        public Registro_Cuidadora GetRegistroCuidadora(int cuidadoraId)
        {
            return _appContextS.RegistroCuidadoras.FirstOrDefault(c => c.Id == cuidadoraId);
        }

        public Registro_Cuidadora UpdateRegistroCuidadora(Registro_Cuidadora cuidadora)
        {
            var cuidadoraEncontrada = _appContextS.RegistroCuidadoras.FirstOrDefault(c => c.Id == cuidadora.Id);

            if (cuidadoraEncontrada != null)
            {
                cuidadoraEncontrada.Codigo = cuidadora.Codigo;

                cuidadoraEncontrada.Manzanas = cuidadora.Manzanas; 

                _appContextS.SaveChanges();
            }

            return cuidadoraEncontrada;
        }


    }

}