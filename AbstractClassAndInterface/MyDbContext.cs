
namespace AbstractClassAndInterface
{
    public sealed partial class MyDbContext : BaseDBContext, IDbContext
    {

        protected override void OnConfiguring()
        {
            base.OnConfiguring();
        }

        protected override void OnModelCreating()
        {
            base.OnModelCreating();
        }
    }
}
