using System;
using System.Collections.Generic;
using System.Text;

namespace DrugStore.Utilities.Dtos
{
    public abstract class PagedResultBase
    {
        public int CurrentPage { get; set; }

        public int PageCount
        {
            get
            {
                var pageCount = (double)RowCount / PageSize;
                return (int)Math.Ceiling(pageCount); 
            }
            set { PageCount = value; }
        }
        public int PageSize { get; set; }

        public int RowCount { get; set; }

        public int FirstRowOnPage { get; set; }
        public int LastRowOnPage { get; set; }
    }
}
