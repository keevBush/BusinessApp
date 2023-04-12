using BusinessApp.Service.LaunchApplication;
using System;
using Wisej.Services;
using Wisej.Web;

namespace BusinessApp.Portal
{
    public partial class MyDesktop : Desktop
    {
        [Inject]
        private ILaunchApplicationService LaunchApplicationService { get; set; }
        [Inject]
        private IApplicationService ApplicationService { get; set; }
        public MyDesktop()
        {
            InitializeComponent();
            LaunchApplicationService.ApplicationLaunched += ApplicationService_ApplicationLaunched;
            Load += MyDesktop_Load;
        }

        private void MyDesktop_Load(object sender, EventArgs e)
        {
            this.Items.Clear();
            foreach (var application in ApplicationService.GetApplications())
            {
                var item = new ListViewItem
                {
                    Tag = application,
                    Text = application.Name,
                    ToolTipText = application.Description,
                    StateImageSource = $"resource.wx/{application.Icon}"
                };

                this.listView1.Items.Add(item);
            }
        }

        private void ApplicationService_ApplicationLaunched(object sender, ApplicationDTO e)
        {
            // Create window instance
            var window = (Form)Activator.CreateInstance(e.AssemblyClass, e.WindowClass).Unwrap();

            //You can add there Active Directory access for authorization
            //Customize authentication like you feel
            window.IconSource = $"resource.wx/{e.Icon}";
            window.Show();

        }

        private void listView1_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            var application = (ApplicationDTO)e.Item.Tag;
            if (application == null) return;

            LaunchApplicationService.LaunchApplication(application);
        }
    }
}
