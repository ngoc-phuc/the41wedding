using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

using Common.Extensions;
using Dtos.Shared;
using Dtos.Shared.Inputs;
using EntityFrameworkCore.Helpers.Linq;

using Microsoft.EntityFrameworkCore;

namespace Services.Helpers.PagedResult
{
    public static class QueryablePagedAndSortedExtensions
    {
        /// <summary>
        /// Should apply sorting if needed.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="input">The input.</param>
        public static IQueryable<TEntity> ApplySorting<TEntity>(this IQueryable<TEntity> query, ISortedResultRequest sortInput)
        {
            //Try to sort query if available
            if (sortInput != null)
            {
                if (!sortInput.Sorting.IsNullOrWhiteSpace())
                {
                    return query.OrderBy(sortInput.Sorting);
                }
            }

            //IQueryable.Task requires sorting, so we should sort if Take will be used.
            //if (input is ILimitedResultRequest)
            //{
            //    return query.OrderByDescending(e => e.Id);
            //}

            //No sorting
            return query;
        }

        public static async Task<IPagedResultDto<T>> GetPagedResultAsync<T>(
            this IQueryable<T> source,
            int pageIndex,
            int pageSize,
            object extraData = null)
        {
            if (pageSize == 0)
            {
                return EmptyPagedResult<T>.Instance;
            }

            var count = await source.CountAsync().ConfigureAwait(false);

            var items = await source
                .PageBy(pageIndex * pageSize, pageSize)
                .MakeQueryToDatabaseAsync()
                .ConfigureAwait(false);

            return new PagedResultDto<T>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalCount = count,
                Items = items.ToArray(),
                TotalPages = (int)Math.Ceiling(count / (double)pageSize),
                ExtraData = extraData,
            };
        }

        public static async Task<IPagedResultDto<TEntityDto>> GetPagedResultAsync<TProjection, TEntityDto>(
            this IQueryable<TProjection> source,
            int pageIndex,
            int pageSize,
            Func<TProjection, TEntityDto> convert)
        {
            var count = await source.CountAsync().ConfigureAwait(false);

            var items = source
                .PageBy(pageIndex * pageSize, pageSize)
                .MakeQueryToDatabase();

            return new PagedResultDto<TEntityDto>
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalCount = count,
                Items = items.ConvertArray(convert),
                TotalPages = (int)Math.Ceiling(count / (double)pageSize)
            };
        }
    }
}