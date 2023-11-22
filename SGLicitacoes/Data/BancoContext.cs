using Microsoft.EntityFrameworkCore;
using SGLicitacoes.Models;

namespace SGLicitacoes.Data
{
    public class BancoContext : DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)  
        {

        }

        public DbSet<BiddingInfo> Licitacao { get; set; } 
    }
}
