using Microsoft.EntityFrameworkCore;

namespace TokenApi.Data
{
    public class TokenDbContext : DbContext
    {
        public TokenDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
