using Microsoft.EntityFrameworkCore;
using SompoEngine.BaseLogic.Data.Implementation;
using SompoEngine.DataAccess.Abstract;
using SompoEngine.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace SompoEngine.DataAccess.Implementation.Repositories
{
    public class ServiceRequestResponseRepo : EntityRepositoryBase<ServiceRequestResponse>,IServiceRequestResponseRepo
    {
        public ServiceRequestResponseRepo(DbContext context) : base(context)
        {

        }
    }
}
