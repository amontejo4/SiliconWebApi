using SiliconApi.Data.Entities;
using SiliconApi.Data.Repository;
using System;
using System.Threading.Tasks;

namespace SiliconApi.Data.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<User> UserRepository { get; set; }
        IGenericRepository<UserToken> UserTokenRepository { get; set; }       

        Task<int> CommitAsync();
    }
}