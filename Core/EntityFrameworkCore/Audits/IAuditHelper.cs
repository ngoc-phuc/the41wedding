using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EntityFrameworkCore.Audits
{
    public interface IAuditHelper
    {
        void ApplyBysConcepts(EntityEntry entry);
    }
}