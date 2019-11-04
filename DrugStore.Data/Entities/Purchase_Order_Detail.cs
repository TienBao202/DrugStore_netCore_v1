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
    [Table("Purchase_Order_Details")]
    public class Purchase_Order_Detail : DomainEntity<int>, ISwitchable
    {
        public Purchase_Order_Detail()
        {

        }

        public Purchase_Order_Detail(int id, int id_purchase_order,
            int id_medicine_batch, int quantity, decimal price, Status status)
        {
            ID = id;
            ID_Purchase_Order = id_purchase_order;
            ID_Medicine_Batch = id_medicine_batch;
            Quantity = quantity;
            Price = price;
            Status = status;
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Purchase_Order_Detail_ID { set; get; }

        [Column(Order = 1)]
        public int ID_Purchase_Order { set; get; }

        [Column(Order = 2)]
        public int ID_Medicine_Batch { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public Status Status { set; get; }

        [ForeignKey("ID_Purchase_Order")]
        public virtual Purchase_Order Purchase_Orders { set; get; }

        [ForeignKey("ID_Medicine_Batch")]
        public virtual Medicine_Batch Medicine_Batch { set; get; }
    }
}
