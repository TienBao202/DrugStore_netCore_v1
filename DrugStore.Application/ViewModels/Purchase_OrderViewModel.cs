using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DrugStore.Data.Enums;
using DrugStore.Data.Interfaces;

namespace DrugStore.Application.ViewModels
{
    public class Purchase_OrderViewModel 
    {
        public int ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Purchase_Order_Code { set; get; }

        public decimal Total_Price { set; get; }

        public float? Discount { set; get; }

        public decimal Amount_Payment { set; get; }

        public decimal Amount_Owed { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public int ID_Supplier { set; get; }

        public int ID_Agency { set; get; }

        public SupplierViewModel Suppliers { set; get; }

        public AgencyViewModel Agency { set; get; }

        public ICollection<Purchase_Order_DetailViewModel> Purchase_Order_Details { set; get; }
    }
}
