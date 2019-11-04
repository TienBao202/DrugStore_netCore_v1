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
    [Table("Invoices")]
    public class Invoice : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Invoice()
        {
            Invoice_Details = new List<Invoice_Detail>();
        }

        public Invoice(int id, string invoice_code, decimal total_price, float? discount,
            decimal customer_pays, decimal return_customer, Status status, string user_created, 
            string user_modified, int id_customer, int id_agency)
        {
            ID = id;
            Invoice_Code = invoice_code;
            Total_Price = total_price;
            Discount = discount;
            Customer_Pays = customer_pays;
            Return_Customer = return_customer;
            Status = status;
            User_Created = user_created;
            User_Modified = user_modified;
            ID_Customer = id_customer;
            ID_Agency = id_agency;
        }


        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Invoice_ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Invoice_Code { set; get; }

        public decimal Total_Price { set; get; }

        [DefaultValue(0)]
        public float? Discount { set; get; }

        public decimal Customer_Pays { set; get; }

        public decimal Return_Customer { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public int ID_Customer { set; get; }

        public int ID_Agency { set; get; }

        [ForeignKey("ID_Customer")]
        public virtual Customer Customers { set; get; }

        [ForeignKey("ID_Agency")]
        public virtual Agency Agency { set; get; }

        public virtual ICollection<Invoice_Detail> Invoice_Details { set; get; }

    }
}
