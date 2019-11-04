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
    [Table("Agencies")]
    public class Agency : DomainEntity<int>, ISwitchable
    {
        public Agency()
        {
            Employees = new List<Employee>();
            Invoices = new List<Invoice>();
            Purchase_Orders = new List<Purchase_Order>();
        }

        public Agency(int id, string agency_code, string agency_name, string phone_number,
            string email, string delegate_name, int? display_order, Status status)
        {
            ID = id;
            Agency_Code = agency_code;
            Agency_Name = agency_name;
            Phone_Number = phone_number;
            Email = email;
            Delegate_Name = delegate_name;
            Display_Order = display_order;
            Status = status;
        }

        [Required]
        [StringLength(50)]
        public string Agency_Code { set; get; }

        [Required]
        [StringLength(256)]
        public string Agency_Name { set; get; }

        public string Phone_Number { set; get; }

        public string Email { set; get; }

        public string Delegate_Name { set; get; }

        public int? Display_Order { set; get; }

        public Status Status { set; get; }

        public virtual ICollection<Employee> Employees { set; get; }

        public virtual ICollection<Invoice> Invoices { set; get; }

        public virtual ICollection<Purchase_Order> Purchase_Orders { set; get; }
    }
}
