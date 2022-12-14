namespace FruitStack.Models.Pagination
{
    public class PagingSettings
    {
        /// <summary>
        /// Constant number of maximum page size
        /// </summary>
        private const int maxPageSize = 50;

        /// <summary>
        /// Number of current page. Default = 1
        /// </summary>
        public int CurrentPage { get; set; } = 1;

        /// <summary>
        /// Default page size field
        /// </summary>
        private int _pageSize = 10;


        /// <summary>
        /// Page size property. Default returning _pageSize. Setting new value if value <= maxPageSize
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value > maxPageSize ? maxPageSize : value; }
        }
    }
}
