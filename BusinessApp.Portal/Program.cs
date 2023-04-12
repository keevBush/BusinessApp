using BusinessApp.Service.LaunchApplication;
using System;
using Wisej.Web;

namespace BusinessApp.Portal
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            InitializeInjection();

            Application.Desktop = new MyDesktop();

        }

        static void InitializeInjection()
        {
            Application.Services.AddService<IApplicationService, ApplicationService>(Wisej.Services.ServiceLifetime.Shared);
            Application.Services.AddService<ILaunchApplicationService, LaunchApplicationService>(Wisej.Services.ServiceLifetime.Shared);
        }
        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}
    }
}