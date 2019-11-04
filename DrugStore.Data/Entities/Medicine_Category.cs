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
    [Table("Medicine_Categories")]
    public class Medicine_Category : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Medicine_Category()
        {
            Medicines = new List<Medicine>();
        }

        public Medicine_Category(int id, string category_code, 
            string category_name, string category_alias, int? category_parent_id, int? display_order,
            Status status, string user_created, string user_modified)
        {
            ID = id;
            Category_Code = category_code;
            Category_Name = category_name;
            Category_Alias = category_alias;
            Category_Parent_ID = category_parent_id;
            Display_Order = display_order;
            Status = status;
            User_Created = user_created;
            User_Modified = user_modified;
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Medicine_Category_ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Category_Code { set; get; }

        [Required]
        [StringLength(256)]
        public string Category_Name { set; get; }

        public string Category_Alias { set; get; }

        public int? Category_Parent_ID { set; get; }

        public int? Display_Order { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public virtual ICollection<Medicine> Medicines { set; get; }

    }
}
