using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DrugStore.Data.Enums;
using DrugStore.Data.Interfaces;
using DrugStore.Infrastructure.SharedKernel;

namespace DrugStore.Application.ViewModels
{
    public class Medicine_CategoryViewModel
    {
        public int ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Category_Code { set; get; }

        [Required]
        [StringLength(256)]
        public string Category_Name { set; get; }

        public string Category_Alias { set; get; }

        public int? Category_Parent_ID { set; get; }

        public int? Display_Order { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public ICollection<MedicineViewModel> Medicines { set; get; }
    }
}
