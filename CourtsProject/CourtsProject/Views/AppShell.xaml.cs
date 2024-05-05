using CourtsProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourtsProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(route: "registration", typeof(RegisterPage));
            var tab = new tab(); // Создаем экземпляр tab
            
        }

        public class HiddenItem : ShellItem
        {

        }
    }
}