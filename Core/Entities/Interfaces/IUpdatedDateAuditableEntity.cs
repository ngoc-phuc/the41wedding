using System;

namespace Entities.Interfaces
{
    public interface IUpdatedDateAuditableEntity
    {
        DateTime? AAUpdatedDate { get; set; }
    }
}