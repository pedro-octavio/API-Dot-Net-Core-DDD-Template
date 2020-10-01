using Autofac;

namespace PROJECTName.Infra.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder containerBuilder) => ConfigurationIOC.Load(containerBuilder);
    }
}
