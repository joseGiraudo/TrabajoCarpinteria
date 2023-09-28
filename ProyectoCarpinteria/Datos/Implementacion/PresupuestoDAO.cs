using ProyectoCarpinteria.Datos.Interfaz;
using ProyectoCarpinteria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCarpinteria.Datos.Implementacion
{
    public class PresupuestoDAO : IPresupuestoDAO
    {
        public bool Actualizar(Presupuesto oPresupuesto)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(int nroPresupuesto)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Presupuesto oPresupuesto)
        {
            throw new NotImplementedException();
        }

        public List<Presupuesto> ObtenerPresupuestoConFiltro(string cliente, DateTime desde, DateTime hasta)
        {
            throw new NotImplementedException();
        }

        public Presupuesto ObtenerPresupuestoPorNro(int nroPresupuesto)
        {
            throw new NotImplementedException();
        }

        public List<Producto> ObtenerProductos()
        {
            throw new NotImplementedException();
        }

        public int ObtenerProximoPresupuesto()
        {
            throw new NotImplementedException();
        }
    }
}
