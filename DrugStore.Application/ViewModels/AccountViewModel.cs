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
    public class AccountViewModel 
    {
        public int ID { set; get; }

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

        public bool IsAdmin { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public int ID_Employee { set; get; }

        public EmployeeViewModel Employees { set; get; }

    }
}
