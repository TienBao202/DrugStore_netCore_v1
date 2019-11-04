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
    public class CountryViewModel 
    {
        public int ID { set; get; }

        [Required]
        [StringLength(256)]
        public string Country_Name { set; get; }

        public int? Display_Order { set; get; }

        public Status Status { set; get; }

        public ICollection<Medicine_BatchViewModel> Medicine_Batches { set; get; }
    }
}
