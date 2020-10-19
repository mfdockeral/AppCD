using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCD
{

	public class MenuPrincipalMasterMenuItem
	{
		public MenuPrincipalMasterMenuItem()
		{
			TargetType = typeof(MenuPrincipalMasterMenuItem);
		}
		public int Id { get; set; }
		public string Title { get; set; }

		public Type TargetType { get; set; }
	}
}