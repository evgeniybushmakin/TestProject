using Microsoft.EntityFrameworkCore;

namespace Jeka50.BDModel
{
    public class TestBdModel : DbContext
    {
        public TestBdModel(DbContextOptions<TestBdModel> options)
            : base(options)
        {
        }

        public DbSet<Transactions> Transactions { get; set; } = null!;
        public DbSet<TransactionDetails> TransactionDetailsEnumerable { get; set; } = null!;
    }
}