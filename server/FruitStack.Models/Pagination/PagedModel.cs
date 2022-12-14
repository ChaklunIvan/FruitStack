namespace FruitStack.Models.Pagination
{
    public class PagedModel<TModel>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public IEnumerable<TModel> Items { get; set; }
    }
}
