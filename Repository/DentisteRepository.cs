using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class DentisteRepository: RepositoryBase<Dentiste>, IDentisteRepository
    {
        public DentisteRepository(RepositoryContext repositoryContext)
                : base(repositoryContext)
        {
        }
    }
}
