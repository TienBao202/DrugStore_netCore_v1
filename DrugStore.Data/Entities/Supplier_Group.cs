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
    [Table("Supplier_Groups")]
    public class Supplier_Group :DomainEntity<int>, ISwitchable
    {
        public Supplier_Group()
        {
            Suppliers = new List<Supplier>();
        }

        public Supplier_Group(int id, string supplier_group_code, string supplier_group_name,
            int? display_order, string description, Status status)
        {
            ID = id;
            Supplier_Group_Code = supplier_group_code;
            Supplier_Group_Name = supplier_group_name;
            Display_Order = display_order;
            Description = description;
            Status = status;
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Supplier_Group_ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Supplier_Group_Code { set; get; }

        public string Supplier_Group_Name { set; get; }

        public int? Display_Order { set; get; }

        public string Description { set; get; }

        public Status Status { set; get; }

        public virtual ICollection<Supplier> Suppliers { set; get; }
    }
}
