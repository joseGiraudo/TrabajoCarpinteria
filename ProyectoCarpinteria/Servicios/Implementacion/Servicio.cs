
using ProyectoCarpinteria.Datos.Implementacion;
using ProyectoCarpinteria.Datos.Interfaz;
using ProyectoCarpinteria.Entidades;
using ProyectoCarpinteria.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCarpinteria.Servicios.Implementacion
{
    internal class Servicio : IServicio
    {
        private IPresupuestoDAO dao;

        public Servicio()
        {
            dao = new PresupuestoDAO();
        }

        // metodos
        public bool CrearPresupuesto(Presupuesto oPresupuesto)
        {
            return dao.Crear(oPresupuesto);
        }

        public List<Producto> TraerProductos()
        {
            return dao.ObtenerProductos();
        }

        public int TraerProximoPresupuesto()
        {
            return dao.ObtenerProximoPresupuesto();
        }
    }
}
