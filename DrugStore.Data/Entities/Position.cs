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
    [Table("Positions")]
    public class Position : DomainEntity<int>, ISwitchable
    {
        public Position()
        {
            Employees = new List<Employee>();
        }

        public Position(int id, string position_code, string position_name, 
            string position_alias, int? display_order, Status status)
        {
            ID = id;
            Position_Code = position_code;
            Position_Name = position_name;
            Position_Alias = position_alias;
            Display_Order = display_order;
            Status = status;
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Position_ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Position_Code { set; get; }

        [Required]
        //[MaxLength(256)]
        public string Position_Name { set; get; }

        public string Position_Alias { set; get; }

        public int? Display_Order { set; get; }

        public Status Status { set; get; }

        public virtual ICollection<Employee> Employees { set; get; }
    }
}
