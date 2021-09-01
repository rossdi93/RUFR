using System.Linq;
using RUFR.Api.Service.Interfaces;
using RUFR.Api.DataLayer;

namespace RUFR.Api.Service.Services
{
    public class MainService<T> : IMainService<T> where T : class
    {
        protected readonly IDbContext Context;

        public MainService(IDbContext context)
        {
            Context = context;
        }

        public T GetById (long id)
        {
            return Context.Set<T>().Find(id);
        }
    }
}
