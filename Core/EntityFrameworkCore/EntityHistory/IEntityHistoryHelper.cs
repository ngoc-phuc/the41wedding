using System.Collections.Generic;

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EntityFrameworkCore.EntityHistory
{
    public interface IEntityHistoryHelper
    {
        EntityChangeSet CreateEntityChangeSet(ICollection<EntityEntry> entityEntries);

        void UpdateChangeSet(EntityChangeSet changeSet);
    }
}