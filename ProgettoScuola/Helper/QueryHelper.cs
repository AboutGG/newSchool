using Microsoft.EntityFrameworkCore;
using ProgettoScuola.Utils;
using System.Linq.Dynamic.Core;

namespace ProgettoScuola.Helper;

public static class QueryHelper
{
    
    // This method builds a query by applying includes, filters, and ordering to an IQueryable<T>.
    public static async Task<PaginatedList<T>> BuildQuery<T>(
        this IQueryable<T> query,
        Func<IQueryable<T>, IQueryable<T>>? includeFunc,
        string? filterString,
        string? orderString,
        bool? sensitiveFilter,
        int page,
        int size)
    {
        // Apply includes to the query if provided.
        if (includeFunc != null)
        {
            query = includeFunc(query);
        }

        // Apply filters to the query if provided.
        if (filterString != null)
        {
            List<KeyValuePair<string, string>> filterList= ConvertFilterStringToList(filterString);
            query = query.FilterTable(filterList, sensitiveFilter ?? false );
        }

        // Apply ordering to the query if provided.
        if (orderString != null)
        {
            query = query.OrderByFields(orderString);
        }

        // Convert the query to a paginated list.
        return await query.ToPaginatedListAsync(page, size);
    }
    
    // This method builds a query by applying includes, filters, and ordering to an IQueryable<T>.
    public static async Task<PaginatedList<T>> BuildQuery<T>(
        this IQueryable<T> query,
        Func<IQueryable<T>, IQueryable<T>>? includeFunc,
        List<KeyValuePair<string, string>>? filterList,
        List<Tuple<string, bool>>? orderFieldsList,
        bool? sensitiveFilter,
        int page,
        int size)
    {
        // Apply includes to the query if provided.
        if (includeFunc != null)
        {
            query = includeFunc(query);
        }

        // Apply filters to the query if provided.
        if (filterList != null)
        {
            query = query.FilterTable(filterList, sensitiveFilter ?? false );
        }

        // Apply ordering to the query if provided.
        if (orderFieldsList != null)
        {
            query = query.OrderByFields(orderFieldsList);
        }

        // Convert the query to a paginated list.
        return await query.ToPaginatedListAsync(page, size);
    }

    
    /// <summary>
    /// This extension method for IQueryable<T> provides functionality to convert a queryable data source into a paginated list.
    /// The method takes in the page index and page size as parameters to determine the subset of data to include in the returned list.
    /// The method asynchronously counts the total number of items in the source and retrieves only the items for the specified page,
    /// thereby improving performance when working with large data sets.
    /// </summary>
    /// <param name="q">The IQueryable<T> data source to paginate.</param>
    /// <param name="pageIndex">The 1-based index of the page to retrieve.</param>
    /// <param name="pageSize">The number of items per page.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a PaginatedList<T> that includes only the items for the specified page and the total number of items in the source.</returns>
    public static async Task<PaginatedList<T>> ToPaginatedListAsync<T>(this IQueryable<T> q, int pageIndex,
        int pageSize)
    {
        // Count the total number of items in the source.
        var totalItems = await q.CountAsync();
        // Skip the items for the previous pages and take the items for the current page.
        var itemsOnPage = await q.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        // Return a new paginated list with the items for the current page and the total number of items.
        return new PaginatedList<T>(itemsOnPage, totalItems, pageIndex, pageSize);
    }
    

    public static List<Tuple<string, bool>> ConvertOrderStringToList(string orderString)
    {
        var sortList = new List<Tuple<string, bool>>();

        var sortExpressions = orderString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var sortExpression in sortExpressions)
        {
            var orderDescending = sortExpression[0] == '-';
            var propertyName = orderDescending ? sortExpression.Substring(1).Trim() : sortExpression.Trim();

            sortList.Add(new Tuple<string, bool>(propertyName, !orderDescending));
        }

        return sortList;
    }

    private static List<KeyValuePair<string, string>> ConvertFilterStringToList(string filterString)
    {
        var list = new List<KeyValuePair<string, string>>();

        var pairs = filterString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var pair in pairs)
        {
            var separatorIndex = pair.IndexOf(':');
            if (separatorIndex >= 0 && separatorIndex < pair.Length - 1)
            {
                var key = pair.Substring(0, separatorIndex).Trim();
                var value = pair.Substring(separatorIndex + 1).Trim();

                list.Add(new KeyValuePair<string, string>(key, value));
            }
        }

        return list;
    }
    
    
    // This extension method filters an IQueryable<T> based on provided criteria.
    private static IQueryable<T> FilterTable<T>(this IQueryable<T> q, List<KeyValuePair<string, string>> filterFields, bool caseSensitive = false)
    {
        // Define the filter expression based on case sensitivity.
        string filterExpression = caseSensitive ? "{0}.Contains(@0)" : "{0}.ToLower().Contains(@0.ToLower())";

        // Loop through each filter field.
        foreach (var kvp in filterFields)
        {
            // Filter the query based on the current filter field.
            q = q.Where(string.Format(filterExpression, kvp.Key), kvp.Value);
        }

        // Return the filtered query.
        return q;
    }
    
    // This extension method orders an IQueryable<T> by multiple fields.
    private static IQueryable<T> OrderByFields<T>(this IQueryable<T> q, List<Tuple<string, bool>> sortFields)
    {
        // Loop through each sort field.
        foreach (var sortField in sortFields)
        {
            // Determine the order direction for the current sort field.
            string order = sortField.Item2 ? "ASC" : "DESC";
            // Order the query by the current sort field.
            q = q.OrderBy($"{sortField.Item1} {order}");
        }

        // Return the ordered query.
        return q;
    }
    
    private static IQueryable<T> OrderByFields<T>(this IQueryable<T> query, string? orderFieldsList)
    {
        var sortExpressions = orderFieldsList.Split(',');

        foreach (var sortExpression in sortExpressions)
        {
            var trimmed = sortExpression.Trim();

            var orderDescending = trimmed.StartsWith("-");
            var propertyName = orderDescending ? trimmed.Substring(1) : trimmed;

            query = query.OrderBy($"{propertyName} {(orderDescending ? "DESC" : "ASC")}");
        }

        return query;
    }
    


    #region OLD
    #region NoDynamicLinq
    
    // public static IQueryable<T> OrderByField<T>(this IQueryable<T> q, string sortField, bool ascending)
    // {
    //     // Split the sortField in case it's a nested property
    //     var sortFields = sortField.Split('.');
    //     
    //     // Creating a parameter of the object passed 
    //     var param = Expression.Parameter(typeof(T), "p");
    //     
    //     // Creation to the property of the specified camp of the object passed
    //     Expression prop = param;
    //     foreach (var field in sortFields)
    //     {
    //         prop = Expression.PropertyOrField(prop, field);
    //     }
    //     
    //     // Creating a lambda expression using the property and the param
    //     var exp = Expression.Lambda(prop, param);
    //     
    //     // Selecting the ordering method  
    //     string method = ascending ? "OrderBy" : "OrderByDescending";
    //     
    //     // Getting the types of the T and of the passed parameter
    //     Type[] types = { q.ElementType, exp.Body.Type };
    //     
    //     //Calling the right ordering method
    //     var mce = Expression.Call(typeof(Queryable), method, types, q.Expression, exp);
    //     
    //     //Returning the new ordered IQueryable by making a new query that the provider translated
    //     return q.Provider.CreateQuery<T>(mce);
    // }
    
    #endregion
    
    #region OnlyWorksWithOneField

    // // This extension method orders an IQueryable<T> by a specified field.
    // public static IQueryable<T> OrderByField<T>(this IQueryable<T> q, string sortField, bool ascending)
    // {
    //     // Determine the order direction.
    //     string order = ascending ? "ASC" : "DESC";
    //     // Return the ordered query.
    //     return q.OrderBy($"{sortField} {order}");
    // }

    
    
    #endregion

    #region NoCaseSensitive
    // This extension method filters an IQueryable<T> based on provided criteria.
    // private static IQueryable<T> FilterTable<T>(this IQueryable<T> q, List<KeyValuePair<string, string>> filterFields)
    // {
    //     // Loop through each filter field.
    //     foreach (var kvp in filterFields)
    //     {
    //         // Filter the query based on the current filter field.
    //         q = q.Where($"{kvp.Key}.ToLower().Contains(@0.ToLower())", kvp.Value);
    //     }
    //
    //     // Return the filtered query.
    //     return q;
    // }

    #endregion
    #endregion
}