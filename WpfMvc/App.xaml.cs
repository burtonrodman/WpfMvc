using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfMvc.Framework.Routing;

namespace WpfMvc
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IRouter _Router;
        public IRouter Router => _Router ?? (_Router = new Router());

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Router.RegisterController<Controllers.HomeController>(WellKnownRoutes.Home);
            Router.Navigate(WellKnownRoutes.Home);
        }
    }
}
