using EntityFrameworkCore.Audits;

using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Contexts
{
    public class ErpDbContext : WeddingDbContext
    {
        public ErpDbContext(DbContextOptions<ErpDbContext> options, IAuditHelper auditHelper)
            : base(options, auditHelper)
        {
        }
    }
}