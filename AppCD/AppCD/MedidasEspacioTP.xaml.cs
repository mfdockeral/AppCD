using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using AppCD.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCD
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MedidasEspacioTP : ContentPage
	{
		MedidasEspacio ME = new MedidasEspacio();

		public int Rsp1, Rsp2, Rsp3, Rsp4, Rsp5, Rsp6, Rsp7, Rsp8, Rsp9, Rsp10, Rsp11, Rsp12, Rsp13, Rsp14, Rsp15, Calc1, Calc2, Total;
		public double PorcentajeTP;
		public string POS;
		
		public MedidasEspacioTP()
		{
			InitializeComponent();
		}

		public void Variables()
		{
			POS = Resp0.Text;
			Rsp1 = Convert.ToInt32(Resp1.Text);
			Rsp2 = Convert.ToInt32(Resp2.Text);
			Rsp3 = Convert.ToInt32(Resp3.Text);
			Rsp4 = Convert.ToInt32(Resp4.Text);
			Rsp5 = Convert.ToInt32(Resp5.Text);
			Rsp6 = Convert.ToInt32(Resp6.Text);
			Rsp7 = Convert.ToInt32(Resp7.Text);
			Rsp8 = Convert.ToInt32(Resp8.Text);
			Rsp9 = Convert.ToInt32(Resp9.Text);
			Rsp10 = Convert.ToInt32(Resp10.Text);
			Rsp11 = Convert.ToInt32(Resp11.Text);
			Rsp12 = Convert.ToInt32(Resp12.Text);
			Rsp13 = Convert.ToInt32(Resp13.Text);
			Rsp14 = Convert.ToInt32(Resp14.Text);
			Rsp15 = Convert.ToInt32(Resp15.Text);

			Calc1 = Rsp1 + Rsp2 + Rsp3 + Rsp4 + Rsp5 + Rsp6 + Rsp7 + Rsp8;
			Calc2 = Rsp9 + Rsp10;
			Total = Calc1 + Calc2 + Rsp11 + Rsp12 + Rsp13 + Rsp14 + Rsp15;
			PorcentajeTP = 1.0 * Calc1 / Total;
			//POS = Convert.ToString(SBPuntos.SelectedItem);

			ME.question0 = POS;
			ME.question1 = Rsp1;
			ME.question2 = Rsp2;
			ME.question3 = Rsp3;
			ME.question4 = Rsp4;
			ME.question5 = Rsp5;
			ME.question6 = Rsp6;
			ME.question7 = Rsp7;
			ME.question8 = Rsp8;
			ME.question9 = Rsp9;
			ME.question10 = Rsp10;
			ME.question11 = Rsp11;
			ME.question12 = Rsp12;
			ME.question13 = Rsp13;
			ME.question14 = Rsp14;
			ME.question15 = Rsp15;

		}


		private void Btn1_Clicked(object sender, EventArgs e)
		{
			Variables();

			var data = contenedor.Children.OfType<Entry>();
			int inicio = 0;
			int final = 59;


			if (data.Any())
				{
				final = 71;
				}

			inicio = final;

			foreach (var item2 in contenedor.Children.OfType<Entry>())
			{			
				if (item2.Text != null)
				{
					item2.BackgroundColor = Color.White;
					item2.PlaceholderColor = Color.Gray;	
				}
				else
				{
					item2.PlaceholderColor = Color.White;
					item2.BackgroundColor = Color.Red;
					
				}
		

			}


		/*	if (contenedor.Children.OfType<Entry>().ToList().Any(null))
			{
				LblTotalTPCP.Text = Convert.ToString(Calc1);
				LblTotalTPPG.Text = Convert.ToString(Calc2);
				LblTotalTP.Text = Convert.ToString(Total);
				LblPorcentajeTP.Text = PorcentajeTP.ToString("p02");
			}*/

			if (contenedor.Children.OfType<Entry>().Any() != null)
			{
				LblTotalTPCP.Text = Convert.ToString(Calc1);
				LblTotalTPPG.Text = Convert.ToString(Calc2);
				LblTotalTP.Text = Convert.ToString(Total);
				LblPorcentajeTP.Text = PorcentajeTP.ToString("p02");
			}

			
		}
		async private void Btn2_Clicked(object sender, EventArgs e)
		{
			var data = contenedor.Children.OfType<Entry>().Any();


			if (data == null)
			{
				
				await this.DisplayAlert("Error!", "No puede dejar campos vacíos", "Ok");
				
			}
			else
			{
				LblTotalTPCP.Text = Convert.ToString(Calc1);
				LblTotalTPPG.Text = Convert.ToString(Calc2);
				LblTotalTP.Text = Convert.ToString(Total);
				LblPorcentajeTP.Text = PorcentajeTP.ToString("p02");
				await Navigation.PushModalAsync(new MedidasEspacioTB());
			}
			

		}

	
	}
}