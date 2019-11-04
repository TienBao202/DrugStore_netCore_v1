using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DrugStore.Data.Enums;
using DrugStore.Data.Interfaces;

namespace DrugStore.Application.ViewModels
{
    public class PositionViewModel
    {
        public int ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Position_Code { set; get; }

        [Required]
        public string Position_Name { set; get; }

        public string Position_Alias { set; get; }

        public int? Display_Order { set; get; }

        public Status Status { set; get; }

        public ICollection<EmployeeViewModel> Employees { set; get; }
    }
}
