using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Service.LaunchApplication
{
    public interface IApplicationService
    {
        IEnumerable<ApplicationDTO> GetApplications();
    }
    public class ApplicationService : IApplicationService
    {
        public IEnumerable<ApplicationDTO> GetApplications()
        {
            var data = new List<ApplicationDTO>();
            data.Add(new ApplicationDTO()
            {
                Icon = "Wisej.Ext.VisualStudioIcons/StatusSecurityOK_cyan.svg",
                AssemblyClass = "BusinessApp.Apps.Identity",
                Description = "Simple application",
                Name = "Identity",
                WindowClass = "BusinessApp.Apps.Identity.MainWindow"
            });

            return data;
        }
    }
}
