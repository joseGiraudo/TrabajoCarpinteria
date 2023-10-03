using ProyectoCarpinteria.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCarpinteria.Presentacion
{
    public partial class FrmConsultarPresupuesto : Form
    {
        public FrmConsultarPresupuesto()
        {
            InitializeComponent();
        }

        private void FrmConsultarPresupuesto_Load(object sender, EventArgs e)
        {
            // por defecto busca la ultima semana
            dtpFechaDesde.Value = DateTime.Now.AddDays(-7); 
            dtpFechaHasta.Value = DateTime.Now;
            txtCliente.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //validar campos de carga!!!
            List<Parametro> listParams = new List<Parametro>();
            listParams.Add(new Parametro("@fecha_desde", dtpFechaDesde.Value.ToString("yyyyMMdd")));
            listParams.Add(new Parametro("@fecha_hasta", dtpFechaHasta.Value.ToString("yyyyMMdd")));
            listParams.Add(new Parametro("@cliente", txtCliente.Text));

            // DataTable table = dbHelper.Consultar("SP_CONSULTAR_PRESUPUESTO", listParams);

            // eliminamos los resultados de la consulta anterior
            dgvPresupuestos.Rows.Clear();

            foreach (DataRow row in table.Rows)
            {
                dgvPresupuestos.Rows.Add(new object[] { row["presupuesto_nro"].ToString(),
                                                        ((DateTime)row["fecha"]).ToShortDateString(),
                                                        row["cliente"].ToString(),
                                                        row["descuento"].ToString(),
                                                        row["total"].ToString()});

            }
        }
    }
}
