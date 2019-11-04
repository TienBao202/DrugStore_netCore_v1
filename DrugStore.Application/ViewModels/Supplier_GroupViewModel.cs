using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DrugStore.Data.Enums;
using DrugStore.Data.Interfaces;

namespace DrugStore.Application.ViewModels
{
    public class Supplier_GroupViewModel 
    {
        public int ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Supplier_Group_Code { set; get; }

        public string Supplier_Group_Name { set; get; }

        public int? Display_Order { set; get; }

        public string Description { set; get; }

        public Status Status { set; get; }

        public ICollection<SupplierViewModel> Suppliers { set; get; }
    }
}
