using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Data.Enums;

namespace DrugStore.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
