using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace Account.Lextatico.Infra.Data.Context
{
    public interface IContextDb : IUnityOfWork
    {
        bool ActiveTransaction { get; }

        IDbContextTransaction CurrentTransaction { get; }

        Task<IDbContextTransaction> StartTransactionAsync();

        IExecutionStrategy CreateExecutionStrategy();

        Task SubmitTransactionAsync(IDbContextTransaction transaction);

        Task UndoTransaction(IDbContextTransaction transaction);
    }
}
