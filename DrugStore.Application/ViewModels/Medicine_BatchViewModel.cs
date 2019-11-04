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
    public class Medicine_BatchViewModel 
    {

        public int ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Medicine_Batch_Code { set; get; }

        [Required]
        public int Quantity { set; get; }

        [Required]
        public DateTime Start_Date { set; get; }

        [Required]
        public DateTime End_Date { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public int ID_Medicine { set; get; }

        public int ID_Country { set; get; }

        public  MedicineViewModel Medicines { set; get; }

        public CountryViewModel Countrys { set; get; }

       public ICollection<Purchase_Order_DetailViewModel> Purchase_Order_Details { set; get; }
    }
}
