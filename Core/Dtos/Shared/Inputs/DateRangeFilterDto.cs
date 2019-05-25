using System;

using Common.Helpers;

namespace Dtos.Shared.Inputs
{
    public class DateRangeFilterDto
    {
        public DateRangeFilterDto(long? fromDate, long? toDate)
        {
            FromDate = fromDate.FromUnixTimeStamp();
            ToDate = toDate.FromUnixTimeStamp();
        }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }
    }
}