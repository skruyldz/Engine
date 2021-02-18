using Microsoft.Extensions.DependencyInjection;
using SompoEngine.BusinessLogic.Abstract;
using SompoEngine.BusinessLogic.Implementation;
using SompoEngine.DataAccess.Abstract;
using SompoEngine.DataAccess.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SompoEngine.BusinessLogic.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadServices(this IServiceCollection serviceCollection)
        { 
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<IRequestResponseService, RequestResponseService>();
            return serviceCollection;
        }
    }
}
