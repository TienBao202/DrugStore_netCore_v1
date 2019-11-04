using System;
using System.Collections.Generic;
using System.Text;

namespace DrugStore.Data.Interfaces
{
    public interface ISortable
    {
        int SortOrder { set; get; }
    }
}
