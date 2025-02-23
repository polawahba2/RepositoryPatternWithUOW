using Microsoft.EntityFrameworkCore;

namespace BSmartBackEnd.EF
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}