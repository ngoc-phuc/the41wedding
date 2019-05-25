using System;
using System.Linq;
using System.Linq.Expressions;
using EntityFrameworkCore.Helpers.Linq;

namespace EntityFrameworkCore.Helpers
{
    /// <summary>
    /// More details on lazy loading / eager loading here: http://msdn.microsoft.com/en-us/data/jj574232.aspx
    /// 
    /// Often methods `ToEntity` will use nested tables or just call nested `ToSubEntity`, which will result in additional LazyLoad requests. 
    /// Such behavior impacts performance and should be prevented.
    ///
    /// Primary reason for this class is to provide single point where Includes for eager-loading will be defined.
    /// These extensions should be used whenever ConvertHelper's `ToEntity()` methods will be used as a result of a query to database.
    /// </summary>
}