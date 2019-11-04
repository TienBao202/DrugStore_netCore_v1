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
    public class EmployeeViewModel 
    {
        public int ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Employee_Code { set; get; }

        public string First_Name { set; get; }

        public string Last_Name { set; get; }

        public string Birth_Day { set; get; }

        public bool Gender { set; get; }

        public string Address { set; get; }

        public string Phone_Number { set; get; }

        public string Email { set; get; }

        public string Identity_Number { set; get; }

        public string Identity_Date { set; get; }

        public string Identity_Address { set; get; }

        public decimal? Salary_Min { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public int ID_Position { set; get; }

        public int ID_Agency { set; get; }

        public  PositionViewModel Positions { set; get; }

        public  AgencyViewModel Agency { set; get; }

        public ICollection<AccountViewModel> Accounts { set; get; }

    }
}
