using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DrugStore.Data.Enums;
using DrugStore.Data.Interfaces;
using DrugStore.Infrastructure.SharedKernel;

namespace DrugStore.Data.Entities
{
    [Table("Purchase_Orders")]
    public class Purchase_Order : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Purchase_Order()
        {
            Purchase_Order_Details = new List<Purchase_Order_Detail>();
        }

        public Purchase_Order(int id, string purchase_order_code, decimal total_price,
            float? discount, decimal amount_payment, decimal amount_owed, string user_created,
            string user_modified, int id_supplier, int id_agency)
        {
            ID = id;
            Purchase_Order_Code = purchase_order_code;
            Total_Price = total_price;
            Discount = discount;
            Amount_Payment = amount_payment;
            Amount_Owed = amount_owed;
            User_Created = user_created;
            User_Modified = user_modified;
            ID_Supplier = id_supplier;
            ID_Agency = id_agency;
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Purchase_Order_ID { set; get; }

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

        [ForeignKey("ID_Supplier")]
        public virtual Supplier Suppliers { set; get; }

        [ForeignKey("ID_Agency")]
        public virtual Agency Agency { set; get; }

        public virtual ICollection<Purchase_Order_Detail> Purchase_Order_Details { set; get; }

    }
}
