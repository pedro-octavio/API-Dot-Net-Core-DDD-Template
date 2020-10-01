using PROJECTName.Domain.Core.Interfaces.Repositories;
using PROJECTName.Domain.Entities;
using System;

namespace PROJECTName.Infra.Data.Repositories
{
    public class ExampleRepository : IExampleRepository
    {
        private readonly DataContext dataContext;

        public ExampleRepository(DataContext dataContext) => this.dataContext = dataContext;

        public void Add(Example example)
        {
            try
            {
                dataContext.Add(example);

                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
