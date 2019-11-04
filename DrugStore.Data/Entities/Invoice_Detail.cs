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
    [Table("Invoice_Details")]
    public class Invoice_Detail :DomainEntity<int>, ISwitchable
    {
        public Invoice_Detail()
        {

        }

        public Invoice_Detail(int id, int id_invoice, int id_medicine, int quantity,
            decimal price, Status status)
        {
            ID = id;
            ID_Invoice = id_invoice;
            ID_Medicine = id_medicine;
            Quantity = quantity;
            Price = price;
            Status = status;
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Invoice_Detail_ID { set; get; }

        [Column(Order = 1)]
        public int ID_Invoice { set; get; }

        [Column(Order = 2)]
        public int ID_Medicine { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public Status Status { set; get; }

        [ForeignKey("ID_Invoice")]
        public virtual Invoice Invoices { set; get; }

        [ForeignKey("ID_Medicine")]
        public virtual Medicine Medicines { set; get; }


    }
}
