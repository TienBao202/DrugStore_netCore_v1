using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DrugStore.Data.Enums;
using DrugStore.Data.Interfaces;

namespace DrugStore.Application.ViewModels
{
    public class Purchase_Order_DetailViewModel
    {
        public int ID { set; get; }

        public int ID_Purchase_Order { set; get; }

        public int ID_Medicine_Batch { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public Status Status { set; get; }

        public  Purchase_OrderViewModel Purchase_Orders { set; get; }

        public  Medicine_BatchViewModel Medicine_Batch { set; get; }
    }
}
