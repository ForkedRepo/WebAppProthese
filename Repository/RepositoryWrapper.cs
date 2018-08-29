using Contracts;
using Entities;
 
namespace Repository
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IUsersRepository _users;
        private IDentisteRepository _dentiste;
 
        public IUsersRepository Users {
            get {
                if(_users == null)
                {
                    _users = new UsersRepository(_repoContext);
                }
 
                return _users;
            }
        }
 
        public IDentisteRepository Dentiste {
            get {
                if(_dentiste == null)
                {
                    _dentiste = new DentisteRepository(_repoContext);
                }
 
                return _dentiste;
            }
        }
 
        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}