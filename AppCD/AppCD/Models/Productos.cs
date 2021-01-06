using System;
using System.Collections.Generic;
using System.Text;

namespace AppCD.Models
{
	class Productos
	{
		public int ProductoID { get; set; }

		public string ProductoDescripcion { get; set; }

		public bool ProductoEstado { get; set; }

		public virtual int CategoriaID { get; set; } 
	}
}
