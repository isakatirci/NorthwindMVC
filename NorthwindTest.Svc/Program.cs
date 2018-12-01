using Topshelf;

namespace NorthwindTest.Svc
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(serviceConfig =>
                {
                    serviceConfig.Service<Service>(
                        serviceInstance=>
                            {
                                serviceInstance.ConstructUsing(() => new Service());
                                serviceInstance.WhenStarted(execute => execute.Start());
                                serviceInstance.WhenStopped(execute => execute.Stop());
                                serviceInstance.WhenPaused(execute => execute.Pause());
                                serviceInstance.WhenContinued(execute => execute.Continue());

                            });

                    serviceConfig.EnableServiceRecovery(recoveryOption => recoveryOption.RestartService(1));
                    serviceConfig.EnablePauseAndContinue();
                    serviceConfig.SetServiceName("NorthwindTest.Svc.Service");
                    serviceConfig.SetDescription("NorthwindTest.Svc Service");
                    serviceConfig.SetDisplayName("NorthwindTest.Svc Service");

                    serviceConfig.StartAutomatically();
                });
        }
    }
}
