namespace ProgettoScuola.Utils;

public class PaginatedList<T> : List<T>
{
    public int PageIndex { get; private set; }
    public int TotalPages { get; private set; }
    public int TotalItems { get; private set; }

    public PaginatedList(List<T> items, int totalItems, int pageIndex, int pageSize)
    {
        PageIndex = pageIndex;
        TotalItems = totalItems;
        TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

        AddRange(items);
    }

    public bool HasPreviousPage => (PageIndex > 1);

    public bool HasNextPage => (PageIndex < TotalPages);
}

