using System;

namespace Entities.Interfaces
{
    public interface ICreatedDateAuditableEntity
    {
        DateTime? AACreatedDate { get; set; }
    }
}