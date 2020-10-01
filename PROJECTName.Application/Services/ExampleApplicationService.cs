using AutoMapper;
using PROJECTName.Application.DTOs;
using PROJECTName.Application.Interfaces;
using PROJECTName.Domain.Core.Interfaces.Services;
using PROJECTName.Domain.Entities;
using System;

namespace PROJECTName.Application.Services
{
    public class ExampleApplicationService : IExampleApplicationService
    {
        private readonly IExampleService exampleService;
        private readonly IMapper mapper;

        public ExampleApplicationService(IExampleService exampleService, IMapper mapper)
        {
            this.exampleService = exampleService;
            this.mapper = mapper;
        }

        public void Add(ExampleDTO exampleDTO)
        {
            try
            {
                var example = mapper.Map<Example>(exampleDTO);

                exampleService.Add(example);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
