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
    [Table("Countrys")]
    public class Country : DomainEntity<int>, ISwitchable
    {
        public Country()
        {
            Medicine_Batches = new List<Medicine_Batch>();
        }

        public Country(int id, string country_name, int? display_order,
            Status status)
        {
            ID = id;
            Country_Name = country_name;
            Display_Order = display_order;
            Status = Status;
        }
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Country_ID { set; get; }

        [Required]
        [StringLength(256)]
        public string Country_Name { set; get; }

        public int? Display_Order { set; get; }

        public Status Status { set; get; }

        public virtual ICollection<Medicine_Batch> Medicine_Batches { set; get; }
    }
}
