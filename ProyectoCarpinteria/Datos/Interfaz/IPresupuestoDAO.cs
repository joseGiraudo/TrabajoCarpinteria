using ProyectoCarpinteria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCarpinteria.Datos.Interfaz
{
    interface IPresupuestoDAO
    {
        int ObtenerProximoPresupuesto();
        List<Producto> ObtenerProductos();
        bool Crear(Presupuesto oPresupuesto);
        bool Actualizar(Presupuesto oPresupuesto);
        bool Borrar(int nroPresupuesto);
        List<Presupuesto> ObtenerPresupuestoConFiltro(string cliente, DateTime desde, DateTime hasta);
        Presupuesto ObtenerPresupuestoPorNro(int nroPresupuesto);
    }
}
