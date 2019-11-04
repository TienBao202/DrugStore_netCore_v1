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
    [Table("Employees")]
    public class Employee : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Employee()
        {
            Accounts = new List<Account>();
        }

        public Employee(int id, string employee_code, string first_name, string last_name,
            string birth_day, bool gender, string address, string phone_number, string email,
            string identity_number, string identity_date, string identity_address, decimal? salary_min,
            Status status, string user_created, string user_modified, int id_position, int id_agency)
        {
            ID = id;
            Employee_Code = employee_code;
            First_Name = first_name;
            Last_Name = last_name;
            Birth_Day = birth_day;
            Gender = gender;
            Address = address;
            Phone_Number = phone_number;
            Email = email;
            Identity_Number = identity_number;
            Identity_Date = identity_date;
            Identity_Address = identity_address;
            Salary_Min = salary_min;
            Status = status;
            User_Created = user_created;
            User_Modified = user_modified;
            ID_Position = id_position;
            ID_Agency = id_agency;
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Employee_ID { set; get; }

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

        [ForeignKey("ID_Position")]
        public virtual Position Positions { set; get; }

        [ForeignKey("ID_Agency")]
        public virtual Agency Agency { set; get; }

        public virtual ICollection<Account> Accounts { set; get; }

    }
}
