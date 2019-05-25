﻿using System;

using Common.Extensions;
using Dtos.Shared;

namespace Services.Helpers.PagedResult
{
    public static class PagedResultExtension
    {
        public static IPagedResultDto<TResult> ConvertItems<TResult, TSource>(this IPagedResultDto<TSource> source, Func<TSource, TResult> converter)
        {
            return new PagedResultDto<TResult>
            {
                PageIndex = source.PageIndex,
                PageSize = source.PageSize,
                TotalCount = source.TotalCount,
                TotalPages = source.TotalPages,
                Items = source.Items.ConvertArray(converter),
            };
        }
    }
}