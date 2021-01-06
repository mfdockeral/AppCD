using System;
using System.Collections.Generic;
using System.Text;

namespace AppCD.Models
{
	class PuntoVenta
	{
		public int PuntoVentaID { get; set; }

		public string PuntoVentaDescripcion { get; set; }

		public bool PuntoVentaEstado { get; set; }

		public virtual int CuentaID { get; set; }
	}
}
