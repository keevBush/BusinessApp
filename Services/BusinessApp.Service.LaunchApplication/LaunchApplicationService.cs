using System;

namespace BusinessApp.Service.LaunchApplication
{
    public interface ILaunchApplicationService
    {
        event EventHandler<ApplicationDTO> ApplicationLaunched;
        public void LaunchApplication(ApplicationDTO applicationDTO);
    }
    public class LaunchApplicationService : ILaunchApplicationService
    {
        public event EventHandler<ApplicationDTO> ApplicationLaunched;

        public void LaunchApplication(ApplicationDTO applicationDTO) 
            => ApplicationLaunched?.Invoke(this, applicationDTO);
    }
}