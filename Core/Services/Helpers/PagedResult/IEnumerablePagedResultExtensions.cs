using System;
using System.Collections.Generic;
using System.Linq;

using Dtos.Shared;

namespace Services.Helpers.PagedResult
{
    public static class EnumerablePagedResultExtensions
    {
        public static IPagedResultDto<T> ToPagedResult<T>(
            this IEnumerable<T> source,
            int pageIndex,
            int pageSize,
            object extraData = null)
        {
            var count = source.Count();

            return new PagedResultDto<T>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalCount = count,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize),
                Items = source.Skip(pageIndex * pageSize).Take(pageSize).ToArray(),
                ExtraData = extraData,
            };
        }

        public static IPagedResultDto<TResult> ToPagedResult<TSource, TResult>(
            this IEnumerable<TSource> source,
            int pageIndex,
            int pageSize,
            Func<TSource, TResult> converter)
        {
            return source.ToPagedResult(pageIndex, pageSize).ConvertItems(converter);
        }
    }
}