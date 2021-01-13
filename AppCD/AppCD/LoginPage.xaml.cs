using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppCD
{
    public class LoginResponse
    {
        public string Token { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		async private void Button_Clicked(object sender, EventArgs e)
		{
            if (TxtUser.Text == "602" && TxtPassword.Text == "profit26")
			{
                //await DisplayAlert("Aviso", "Bienvenido a su App de Recoleccion de informacion","Ok");
                await Navigation.PushModalAsync(new MenuPrincipal());
			}
			else
			{
                await DisplayAlert("ERROR!", "Datos ingresados no son los correctos", "Ok");
                return;
			}
		}



		public const string URL = @"http://66.42.91.17:81/api/profit_usuarios/1000";

        #region Propiedades
        private string _cod;
        public string Cod
        {
            get
            {
                return _cod;
            }

            set
            {
                _cod = value;
                this.OnPropertyChanged();
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
                this.OnPropertyChanged();
            }
        }

        public bool CanLogin { get { return !IsBusy; } }

        public Command Login { get; set; }
        //public Command Register { get; set; }
        #endregion Propiedades

        public HttpClient client = new HttpClient();

        public LoginPage()
        {
            InitializeComponent();

            Login = new Command(OnLogin);
            //Register = new Command(OnRegister);
            BindingContext = this;
        }

        /*private async void OnRegister(object obj)
        {
            await Navigation.PushAsync(new RegisterPage());
        }*/

        private async void OnLogin()
        {
            IsBusy = true;

            string credentials = JsonConvert.SerializeObject(new
            {
                username = Cod,
                password = Password,
            });

            //var client = new HttpClient();
            var content = new StringContent(credentials, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(URL, content);    
          
            
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();

                try
                {
                    var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(jsonResponse);

                    if (!string.IsNullOrEmpty(loginResponse.Token))
                    {
                        await Navigation.PushModalAsync(new MenuPrincipal());
                    }
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", "Credenciales Invalidas", "Ok");
                }

            }
            else
            {
                await DisplayAlert("Error", "Credenciales Invalidas", "Ok");
            }

            IsBusy = false;
        }
    }
}