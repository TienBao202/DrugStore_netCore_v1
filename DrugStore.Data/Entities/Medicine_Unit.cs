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
    [Table("Medicine_Units")]
    public class Medicine_Unit : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Medicine_Unit()
        {
            Medicines = new List<Medicine>();
        }

        public Medicine_Unit(int id, string medicine_unit_name, int? display_order,
            Status status, string user_created, string user_modified)
        {
            ID = id;
            Medicine_Unit_Name = medicine_unit_name;
            Display_Order = display_order;
            Status = status;
            User_Created = user_created;
            User_Modified = user_modified;
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Medicine_Unit_ID { set; get; }

        [Required]
        public string Medicine_Unit_Name { set; get; }

        public int? Display_Order { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public virtual ICollection<Medicine> Medicines { set; get; }

    }
}
