using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IUsersRepository Users { get; }
        IDentisteRepository Dentiste { get; }
    }
}
