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
    [Table("Suppliers")]
    public class Supplier : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Supplier()
        {
            Purchase_Orders = new List<Purchase_Order>();
        }

        public Supplier(int id, string supplier_code, string supplier_name, string phone_number, string address,
            string email, string tax_code, Status status, string user_created, string user_modified, 
            int id_supplier_group)
        {
            ID = id;
            Supplier_Code = supplier_code;
            Supplier_Name = supplier_name;
            Phone_Number = phone_number;
            Address = address;
            Email = email;
            Tax_Code = tax_code;
            Status = status;
            User_Created = user_created;
            User_Modified = user_modified;
            ID_Supplier_Group = id_supplier_group;
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Supplier_ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Supplier_Code { set; get; }

        [Required]
        //[MaxLength(256)]
        public string Supplier_Name { set; get; }

        public string Phone_Number { set; get; }

        public string Address { set; get; }

        public string Email { set; get; }

        public string Tax_Code { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public int ID_Supplier_Group { set; get; }

        [ForeignKey("ID_Supplier_Group")]
        public virtual Supplier_Group Supplier_Groups { set; get; }

        public virtual ICollection<Purchase_Order> Purchase_Orders { set; get; }
    }
}
