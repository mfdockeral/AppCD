using System;
using System.Collections.Generic;
using System.Text;

namespace AppCD.Models
{
	class Empleado
	{
		public int EmpleadoID { get; set; }

		public string EmpleadoNombre { get; set; }

		public string EmpleadoTelefono { get; set; }

		public string EmpleadoPosicion { get; set; }

		public bool EmpleadoEstado { get; set; }

		public virtual int UsuarioID { get; set; }
	}
}
