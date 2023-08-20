using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Adapters.Interfaces
{
    public interface IDataContext : IDisposable
    {
        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public int SaveChanges();
    }
}