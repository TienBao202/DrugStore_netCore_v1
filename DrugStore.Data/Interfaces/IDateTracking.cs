using System;
using System.Collections.Generic;
using System.Text;

namespace DrugStore.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime Date_Created { set; get; }

        DateTime Date_Modified { set; get; }
    }
}
