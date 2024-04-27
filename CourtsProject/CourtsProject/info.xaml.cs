using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CourtsProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class info : ContentPage
    {
        public info()
        {

            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);


            /*Pinfo.Source = ImageSource.FromResource("CourtsProject.Resources.info.png");
            Pcalendar.Source = ImageSource.FromResource("CourtsProject.Resources.calendar.png");
            Puser.Source = ImageSource.FromResource("CourtsProject.Resources.user.png");*/
        }
    }
}