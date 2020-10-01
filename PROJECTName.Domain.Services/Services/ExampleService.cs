using PROJECTName.Domain.Core.Interfaces.Helpers;
using PROJECTName.Domain.Core.Interfaces.Repositories;
using PROJECTName.Domain.Core.Interfaces.Services;
using PROJECTName.Domain.Entities;
using System;

namespace PROJECTName.Domain.Services.Services
{
    public class ExampleService : IExampleService
    {
        private readonly IExampleRepository exampleRepository;
        private readonly IValidation<Example> validation;

        public ExampleService(IExampleRepository exampleRepository, IValidation<Example> validation)
        {
            this.exampleRepository = exampleRepository;
            this.validation = validation;
        }

        public void Add(Example example)
        {
            try
            {
                example.GenerateId();

                validation.Validate(example);

                exampleRepository.Add(example);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
