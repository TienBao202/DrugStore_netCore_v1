using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DrugStore.Data.Enums;
using DrugStore.Data.Interfaces;

namespace DrugStore.Application.ViewModels
{
    public class Medicine_UnitViewModel 
    {
        public int ID { set; get; }

        [Required]
        public string Medicine_Unit_Name { set; get; }

        public int? Display_Order { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public ICollection<MedicineViewModel> Medicines { set; get; }
    }
}
