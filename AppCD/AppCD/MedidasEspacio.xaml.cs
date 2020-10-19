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
	public partial class MedidasEspacio : ContentPage
	{
		public int resp1, resp2, resp3, resp4, resp5, resp6, resp7, resp8, resp9, resp10, resp11, resp12, resp13, resp14, resp15,
			resp16, resp17, resp18, resp19, resp20, resp21, resp22, resp23, resp24, resp25, resp26, resp27, resp28, resp29, resp30,
			resp31, resp32, resp33, resp34, resp35, resp36, resp37, resp38, resp39, resp40, resp41, resp42, resp43, resp44, resp45,
			resp46, resp47, resp48, resp49, resp50, resp51, resp52, resp53, resp54, resp55, resp56, resp57, resp58, resp59, resp60;
		
		public int CalculoTP, Calculo2TP, CalculoTotalTP, CalculoTB, Calculo2TB, CalculoTotalTB, CalculoEB, Calculo2EB, CalculoTotalEB,
			CalculoDF, Calculo2DF, CalculoTotalDF, CalculoTS, Calculo2TS, CalculoTotalTS;

		public double CalculoPorcentajeTP, CalculoPorcentajeTB, CalculoPorcentajeEB, CalculoPorcentajeDF, CalculoPorcentajeTS;
		public MedidasEspacio()
		{
			InitializeComponent();

			resp1 = Convert.ToInt32(Resp1.Text);
			resp2 = Convert.ToInt32(Resp2.Text);
			resp3 = Convert.ToInt32(Resp3.Text);
			resp4 = Convert.ToInt32(Resp4.Text);
			resp5 = Convert.ToInt32(Resp5.Text);
			resp6 = Convert.ToInt32(Resp6.Text);
			resp7 = Convert.ToInt32(Resp7.Text);
			resp8 = Convert.ToInt32(Resp8.Text);
			resp9 = Convert.ToInt32(Resp9.Text);
			resp10 = Convert.ToInt32(Resp10.Text);
			resp11 = Convert.ToInt32(Resp11.Text);
			resp12 = Convert.ToInt32(Resp12.Text);
			resp13 = Convert.ToInt32(Resp13.Text);
			resp14 = Convert.ToInt32(Resp14.Text);
			resp15 = Convert.ToInt32(Resp15.Text);
			resp16 = Convert.ToInt32(Resp16.Text);
			resp17 = Convert.ToInt32(Resp17.Text);
			resp18 = Convert.ToInt32(Resp18.Text);
			resp19 = Convert.ToInt32(Resp19.Text);
			resp20 = Convert.ToInt32(Resp20.Text);
			resp21 = Convert.ToInt32(Resp21.Text);
			resp22 = Convert.ToInt32(Resp22.Text);
			resp23 = Convert.ToInt32(Resp23.Text);
			resp24 = Convert.ToInt32(Resp24.Text);
			resp25 = Convert.ToInt32(Resp25.Text);
			resp26 = Convert.ToInt32(Resp26.Text);
			resp27 = Convert.ToInt32(Resp27.Text);
			resp28 = Convert.ToInt32(Resp28.Text);
			resp29 = Convert.ToInt32(Resp29.Text);
			resp30 = Convert.ToInt32(Resp30.Text);
			resp31 = Convert.ToInt32(Resp31.Text);
			resp32 = Convert.ToInt32(Resp32.Text);
			resp33 = Convert.ToInt32(Resp33.Text);
			resp34 = Convert.ToInt32(Resp34.Text);
			resp35 = Convert.ToInt32(Resp35.Text);
			resp36 = Convert.ToInt32(Resp36.Text);
			resp37 = Convert.ToInt32(Resp37.Text);
			resp38 = Convert.ToInt32(Resp38.Text);
			resp39 = Convert.ToInt32(Resp39.Text);
			resp40 = Convert.ToInt32(Resp40.Text);
			resp41 = Convert.ToInt32(Resp41.Text);
			resp42 = Convert.ToInt32(Resp42.Text);
			resp43 = Convert.ToInt32(Resp43.Text);
			resp44 = Convert.ToInt32(Resp44.Text);
			resp45 = Convert.ToInt32(Resp45.Text);
			resp46 = Convert.ToInt32(Resp46.Text);
			resp47 = Convert.ToInt32(Resp47.Text);
			resp48 = Convert.ToInt32(Resp48.Text);
			resp49 = Convert.ToInt32(Resp49.Text);
			resp50 = Convert.ToInt32(Resp50.Text);
			resp51 = Convert.ToInt32(Resp01.Text);

		}

		async private void Button_Clicked(object sender, EventArgs e, MedidasEspacio medidasEspacio)
		{
			var POS = SBPOS.SelectedItem;
			if(POS != null){

				if (Resp1.Text != null)
				{
					if (Resp2.Text != null)
					{

						if (Resp3.Text != null)
						{

							if (Resp4.Text != null)
							{

								if (Resp5.Text != null)
								{

									if (Resp6.Text != null)
									{

										if (Resp7.Text != null)
										{
											if (Resp8.Text != null)
											{
												if (Resp9.Text != null)
												{
													if (Resp10.Text != null)
													{
														if (Resp11.Text != null)
														{
															if (Resp12.Text != null)
															{
																if (Resp13.Text != null)
																{
																	if (Resp14.Text != null)
																	{
																		if (Resp15.Text != null)
																		{
																			CalculoTP = resp1 + resp2 + resp3 + resp4 + resp5 + resp6 + resp7 + resp8;
																			Calculo2TP = resp9 + resp10;
																			CalculoTotalTP = CalculoTP + Calculo2TP + resp11 + resp12 + resp13 + resp14 + resp15;
																			CalculoPorcentajeTP = 1.0 * CalculoTP / CalculoTotalTP;
																			LblTotalTPCP.Text = "Total Cremas Dentales CP: " + Convert.ToString(CalculoTP);
																			LblTotalTPPG.Text = "Total Cremas Dentales P&G: " + Convert.ToString(Calculo2TP);
																			LblTotalTP.Text = "Total Cremas Dentales: " + Convert.ToString(CalculoTotalTP);
																			LblPORCTP.Text = "Porcentaje de Categoría: " + CalculoPorcentajeTP.ToString("p02");
																		}
																		else
																		{
																			await DisplayAlert("ERROR", "No puede dejar el campo --Otras Marcas-- Vacio", "Ok");
																			return;
																		}
																	}
																	else
																	{
																		await DisplayAlert("ERROR", "No puede dejar el campo --Marca Privada-- Vacio", "Ok");
																		return;
																	}
																}
																else
																{
																	await DisplayAlert("ERROR", "No puede dejar el campo --Centra Line-- Vacio", "Ok");
																	return;
																}
															}
															else
															{
																await DisplayAlert("ERROR", "No puede dejar el campo --Aquafresh-- Vacio", "Ok");
																return;
															}
														}
														else
														{
															await DisplayAlert("ERROR", "No puede dejar el campo --Sensodyne-- Vacio", "Ok");
															return;
														}
													}
													else
													{
														await DisplayAlert("ERROR", "No puede dejar el campo --Crest-- Vacio", "Ok");
														return;
													}
												}
												else
												{
													await DisplayAlert("ERROR", "No puede dejar el campo --Oral B-- Vacio", "Ok");
													return;
												}
											}
											else
											{
												await DisplayAlert("ERROR", "No puede dejar el campo --Resto Colgate-- Vacio", "Ok");
												return;
											}
										}
										else
										{
											await DisplayAlert("ERROR", "No puede dejar el campo --Pro-Alivio CSPR-- Vacio", "Ok");
											return;
										}
									}
									else
									{
										await DisplayAlert("ERROR", "No puede dejar el campo --Pro-Alivio Base 2-Pack-- Vacio", "Ok");
										return;
									}
								}
								else
								{
									await DisplayAlert("ERROR", "No puede dejar el campo --Luminous White-- Vacio", "Ok");
									return;
								}
							}
							else
							{
								await DisplayAlert("ERROR", "No puede dejar el campo --Total Profesional-- Vacio", "Ok");
								return;
							}
						}
						else
						{
							await DisplayAlert("ERROR", "No puede dejar el campo --Total Base-- Vacio", "Ok");
							return;
						}
					}
					else
					{
						await DisplayAlert("ERROR", "No puede dejar el campo --Triple Acción-- Vacio", "Ok");
						return;
					}
				}
				else
				{
					await DisplayAlert("ERROR", "No puede dejar el campo --Anticaries-- Vacio", "Ok");
					return;
				}
			}
			else
			{
				await DisplayAlert("ERROR", "Debe seleccionar una Tienda", "Ok");
			}
		}

		async private void Button_Clicked_1(object sender, EventArgs e)
		{
			var POS = SBPOS.SelectedItem;
			if (POS != null)
			{
				if (Resp1.Text != null)
				{
					if (Resp2.Text != null)
					{

						if (Resp3.Text != null)
						{

							if (Resp4.Text != null)
							{

								if (Resp5.Text != null)
								{

									if (Resp6.Text != null)
									{

										if (Resp7.Text != null)
										{
											if (Resp8.Text != null)
											{
												if (Resp9.Text != null)
												{
													if (Resp10.Text != null)
													{
														if (Resp11.Text != null)
														{
															if (Resp12.Text != null)
															{
																if (Resp13.Text != null)
																{
																	if (Resp14.Text != null)
																	{
																		if (Resp15.Text != null)
																		{
																			SBPOS.SelectedItem = SBPOS;
																			Resp1.Text = "";
																			Resp2.Text = "";
																			Resp3.Text = "";
																			Resp4.Text = "";
																			Resp5.Text = "";
																			Resp6.Text = "";
																			Resp7.Text = "";
																			Resp8.Text = "";
																			Resp9.Text = "";
																			Resp10.Text = "";
																			Resp11.Text = "";
																			Resp12.Text = "";
																			Resp13.Text = "";
																			Resp14.Text = "";
																			Resp15.Text = "";
																			await DisplayAlert("AVISO","Datos guardados exitosamente","Ok");


																		}
																		else
																		{
																			await DisplayAlert("ERROR", "No puede dejar el campo --Otras Marcas-- Vacio", "Ok");
																			return;
																		}
																	}
																	else
																	{
																		await DisplayAlert("ERROR", "No puede dejar el campo --Marca Privada-- Vacio", "Ok");
																		return;
																	}
																}
																else
																{
																	await DisplayAlert("ERROR", "No puede dejar el campo --Centra Line-- Vacio", "Ok");
																	return;
																}
															}
															else
															{
																await DisplayAlert("ERROR", "No puede dejar el campo --Aquafresh-- Vacio", "Ok");
																return;
															}
														}
														else
														{
															await DisplayAlert("ERROR", "No puede dejar el campo --Sensodyne-- Vacio", "Ok");
															return;
														}
													}
													else
													{
														await DisplayAlert("ERROR", "No puede dejar el campo --Crest-- Vacio", "Ok");
														return;
													}
												}
												else
												{
													await DisplayAlert("ERROR", "No puede dejar el campo --Oral B-- Vacio", "Ok");
													return;
												}
											}
											else
											{
												await DisplayAlert("ERROR", "No puede dejar el campo --Resto Colgate-- Vacio", "Ok");
												return;
											}
										}
										else
										{
											await DisplayAlert("ERROR", "No puede dejar el campo --Pro-Alivio CSPR-- Vacio", "Ok");
											return;
										}
									}
									else
									{
										await DisplayAlert("ERROR", "No puede dejar el campo --Pro-Alivio Base 2-Pack-- Vacio", "Ok");
										return;
									}
								}
								else
								{
									await DisplayAlert("ERROR", "No puede dejar el campo --Luminous White-- Vacio", "Ok");
									return;
								}
							}
							else
							{
								await DisplayAlert("ERROR", "No puede dejar el campo --Total Profesional-- Vacio", "Ok");
								return;
							}
						}
						else
						{
							await DisplayAlert("ERROR", "No puede dejar el campo --Total Base-- Vacio", "Ok");
							return;
						}
					}
					else
					{
						await DisplayAlert("ERROR", "No puede dejar el campo --Triple Acción-- Vacio", "Ok");
						return;
					}
				}
				else
				{
					await DisplayAlert("ERROR", "No puede dejar el campo --Anticaries-- Vacio", "Ok");
					return;
				}
			}
			else
			{
				await DisplayAlert("ERROR", "Debe seleccionar una Tienda", "Ok");
			}
		}

	}

}
	
