using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Service.LaunchApplication
{
    public class ApplicationDTO
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Icon { get; set; }
        public string WindowClass { get; set; }
        public string AssemblyClass { get; set; }
    }
}
