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
    [Table("Customers")]
    public class Customer : DomainEntity<int>, ISwitchable
    {
        public Customer()
        {
            Invoices = new List<Invoice>();
        }

        public Customer(int id, string customer_code, string first_name, string last_name,
            string birth_day, bool? gender, string phone_number, string address, string email,
            string tax_code, bool customer_type, Status status, string user_created, string user_modified)
        {
            ID = id;
            Customer_Code = customer_code;
            First_Name = first_name;
            Last_Name = last_name;
            Birth_Day = birth_day;
            Gender = gender;
            Phone_Number = phone_number;
            Address = address;
            Email = email;
            Tax_Code = tax_code;
            Customer_Type = customer_type;
            Status = status;
            User_Created = user_created;
            User_Modified = user_modified;
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Customer_ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Customer_Code { set; get; }

        public string First_Name { set; get; }

        public string Last_Name { set; get; }

        public string Birth_Day { set; get; }

        public bool? Gender { set; get; }

        public string Phone_Number { set; get; }

        public string Address { set; get; }

        public string Email { set; get; }
        
        public string Tax_Code { set; get; }

        public bool Customer_Type { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public virtual ICollection<Invoice> Invoices { set; get; }

    }
}
