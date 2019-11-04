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
    [Table("Medicine_Batches")]
    public class Medicine_Batch : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Medicine_Batch()
        {
            Purchase_Order_Details = new List<Purchase_Order_Detail>();
        }

        public Medicine_Batch(int id, string medicine_batch_code, int quantity,
            DateTime start_date, DateTime end_date, Status status, string user_created,
            string user_modified, int id_medicine, int id_country)
        {
            ID = id;
            Medicine_Batch_Code = medicine_batch_code;
            Quantity = quantity;
            Start_Date = start_date;
            End_Date = end_date;
            Status = status;
            User_Created = user_created;
            User_Modified = user_modified;
            ID_Medicine = id_medicine;
            ID_Country = id_country;
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Medicine_Batch_ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Medicine_Batch_Code { set; get; }

        [Required]
        public int Quantity { set; get; }

        [Required]
        public DateTime Start_Date { set; get; }

        [Required]
        public DateTime End_Date { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        public int ID_Medicine { set; get; }

        public int ID_Country { set; get; }

        [ForeignKey("ID_Medicine")]
        public virtual Medicine Medicines { set; get; }

        [ForeignKey("ID_Country")]
        public virtual Country Countrys { set; get; }

        public virtual ICollection<Purchase_Order_Detail> Purchase_Order_Details { set; get; }
    }
}
