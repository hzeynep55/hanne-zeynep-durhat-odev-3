using System;
using System.Threading.Tasks;

namespace proje_data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task CompleteAsync();
    }
}
