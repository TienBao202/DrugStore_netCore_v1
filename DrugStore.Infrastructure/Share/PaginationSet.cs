using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrugStore.Infrastructure.Share
{
    public class PaginationSet<T>
    {
        public int Page { set; get; }

        public int Count
        {
            get
            {
                return (Items != null) ? Items.Count() : 0;
            }
        }

        public int TotalPages { set; get; }

        public int TotalCount { set; get; }

        public IEnumerable<T> Items { set; get; }
    }
}
