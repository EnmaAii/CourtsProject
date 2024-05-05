using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using CourtsProject.Tables;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace CourtsProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            
        }
        
        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            
            if (txtUserName.Text != null && txtPassword.Text != null)
            {
                
                var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                var db = new SQLiteConnection(dbPath);

                var myQuery = db.Table<RegUserTable>().Where(ui => ui.UserName == txtUserName.Text && ui.UserPassword == txtPassword.Text).FirstOrDefault();
                
                if (myQuery != null)
                {
                    /*var Tab = new NavigationPage(new tab()); // Создаем экземпляр класса tab
                    await Navigation.PushAsync(Tab); 
                */
                    if (Application.Current.MainPage.Navigation.NavigationStack.Last() is tab)
                    {
                        // Если последняя страница в стеке навигации является экземпляром tab, то не создаем новую страницу
                        await Application.Current.MainPage.Navigation.PopToRootAsync();
                    }
                    else
                    {
                        await Navigation.PushModalAsync(new tab());

                        /* var tabinstance = new tab();
                         await Application.Current.MainPage.Navigation.PushAsync(tabinstance);*/
                    }

                }
                else
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        var result = await DisplayAlert("Error!", "Invalid Username or Password", "Yes", "Cancel");

                        if (result)
                            await Shell.Current.GoToAsync(state: "//login");
                        else
                        {
                            await Shell.Current.GoToAsync(state: "//login");
                        }
                    });
                }
            }
            else
            {
                await DisplayAlert("ERROR!", "FORM CANNOT BE EMPTY", "OK");
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(state: "//login/registration");
        }
    }
}