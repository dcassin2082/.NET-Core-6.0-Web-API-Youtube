using WebApplication32.Models;
using WebApplication32.Repository;

namespace WebApplication32.Services
{
    public abstract class ServicesBase<T> where T : class
    {
        protected readonly IRepository<T> _repo;

        protected ServicesBase(IRepository<T> repo)
        {
            _repo = repo;
        }
    }
}
