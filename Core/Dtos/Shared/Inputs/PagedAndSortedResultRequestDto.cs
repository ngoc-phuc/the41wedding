using System;

namespace Dtos.Shared.Inputs
{
    [Serializable]
    public class PagedAndSortedResultRequestDto : PagedResultRequestDto, ISortedResultRequest
    {
        public virtual string Sorting { get; set; }
    }
}