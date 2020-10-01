using Autofac;
using FluentValidation;
using PROJECTName.Application.Interfaces;
using PROJECTName.Application.Services;
using PROJECTName.Domain.Core.Interfaces.Helpers;
using PROJECTName.Domain.Core.Interfaces.Repositories;
using PROJECTName.Domain.Core.Interfaces.Services;
using PROJECTName.Domain.Entities;
using PROJECTName.Domain.Helpers.Validator;
using PROJECTName.Domain.Services.Services;
using PROJECTName.Domain.Validators;
using PROJECTName.Infra.Data.Repositories;

namespace PROJECTName.Infra.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<ExampleApplicationService>().As<IExampleApplicationService>();

            containerBuilder.RegisterType<ExampleService>().As<IExampleService>();

            containerBuilder.RegisterType<Validator<Example>>().As<IValidation<Example>>();

            containerBuilder.RegisterType<ExampleValidator>().As<IValidator<Example>>();

            containerBuilder.RegisterType<ExampleRepository>().As<IExampleRepository>();
        }
    }
}
