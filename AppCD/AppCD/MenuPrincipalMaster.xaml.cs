using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCD
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPrincipalMaster : ContentPage
	{
		public ListView ListView;

		public MenuPrincipalMaster()
		{
			InitializeComponent();

			BindingContext = new MenuPrincipalMasterViewModel();
			ListView = MenuItemsListView;
		}

		class MenuPrincipalMasterViewModel : INotifyPropertyChanged
		{
			public ObservableCollection<MenuPrincipalMasterMenuItem> MenuItems { get; set; }

			public MenuPrincipalMasterViewModel()
			{
				MenuItems = new ObservableCollection<MenuPrincipalMasterMenuItem>(new[]
				{
					new MenuPrincipalMasterMenuItem { Id = 0, Title = "Page 1" },
					new MenuPrincipalMasterMenuItem { Id = 1, Title = "Page 2" },
					new MenuPrincipalMasterMenuItem { Id = 2, Title = "Page 3" },
					new MenuPrincipalMasterMenuItem { Id = 3, Title = "Page 4" },
					new MenuPrincipalMasterMenuItem { Id = 4, Title = "Page 5" },
				});
			}

			#region INotifyPropertyChanged Implementation
			public event PropertyChangedEventHandler PropertyChanged;
			void OnPropertyChanged([CallerMemberName] string propertyName = "")
			{
				if (PropertyChanged == null)
					return;

				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
			#endregion
		}
	}
}