using System.Threading.Tasks;

using EntityFrameworkCore.UnitOfWork;

namespace EntityFrameworkCore.EntityHistory
{
    public static class EntityHistoryStore
    {
        public static async Task SaveAsync(IUnitOfWork unitOfWork, EntityChangeSet entityChangeSet)
        {
            await unitOfWork.Context.SaveChangesAsync();
        }
    }
}