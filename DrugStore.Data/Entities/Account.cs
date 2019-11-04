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
    [Table("Accounts")]
    public class Account : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Account()
        {

        }

        public Account(int id, string fullname, string username, string password, 
           string phone_number, string email, string address, bool? isadmin, Status status,
           string user_created, string user_modified, int id_employee)
        {
            ID = id;
            FullName = fullname;
            UserName = username;
            Password = password;
            Phone_Number = phone_number;
            Email = email;
            Address = address;
            IsAdmin = isadmin;
            Status = status;
            User_Created = user_created;
            User_Modified = user_modified;
            ID_Employee = id_employee;
        }

        [Required]
        [StringLength(256)]
        public string FullName { set; get; }

        [Required]
        [StringLength(50)]
        public string UserName { set; get; }

        public string Password { set; get; }

        public string Phone_Number { set; get; }

        public string Email { set; get; }

        public string Address { set; get; }    

        public bool? IsAdmin { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public int ID_Employee { set; get; }

        [ForeignKey("ID_Employee")]
        public virtual Employee Employees { set; get; }

    }
}
