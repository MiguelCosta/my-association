namespace Mpc.MyAssociation.Application.Dto
{
    using System;
    using System.Collections.Generic;

    public class PagedResult<T>
    {
        public PagedResult(
            IEnumerable<T> entries,
            int pageNumber,
            int pageSize,
            int totalItems)
        {
            this.Entries = entries;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.TotalItems = totalItems;
            this.TotalPages = pageSize > 0 ? (int)Math.Ceiling((double)totalItems / pageSize) : 1;
        }

        public IEnumerable<T> Entries { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public int TotalItems { get; set; }

        public int TotalPages { get; }
    }
}
