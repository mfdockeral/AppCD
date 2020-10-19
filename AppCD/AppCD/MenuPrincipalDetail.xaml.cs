using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCD
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPrincipalDetail : ContentPage
	{
		public MenuPrincipalDetail()
		{
			InitializeComponent();
		}

		async private void Btn1_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CumplimientoCV());
		}

		async private void Btn2_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new RadarExhibiciones());
		}

		async private void Btn3_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MedidasEspacio());
		}

		async private void Btn4_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Faltantes());
		}

		async private void Btn5_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new PreciosRegulares());
		}

		async private void Btn6_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new PreciosOferta());
		}

		async private void Btn7_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SOA());
		}
	}
}