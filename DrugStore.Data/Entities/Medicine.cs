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
    [Table("Medicines")]
    public class Medicine : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Medicine()
        {
            Medicine_Batches = new List<Medicine_Batch>();
            Invoice_Details = new List<Invoice_Detail>();
        }

        public Medicine(int id, string medicine_code, string medicine_name,
            string medicine_alias, string medicine_image, decimal price, decimal original_price,
            int quantity, string element, string effect, string indications, string contraindications,
            string caution, string dosage_and_administration, int? warranty, string packing,
            int? inventory_min, int? inventory_max, int id_medicine_category, int id_medicine_unit,
            Status status, string user_created, string user_modified)
        {
            ID = id;
            Medicine_Code = medicine_code;
            Medicine_Name = medicine_name;
            Medicine_Alias = medicine_alias;
            Medicine_Image = medicine_image;
            Price = price;
            Original_Price = original_price;
            Quantity = quantity;
            Element = element;
            Effect = effect;
            Indications = indications;
            Contraindications = contraindications;
            Caution = caution;
            Dosage_And_Administration = dosage_and_administration;
            Warranty = warranty;
            Packing = packing;
            Inventory_Min = inventory_min;
            Inventory_Max = inventory_max;
            ID_Medicine_Category = id_medicine_category;
            ID_Medicine_Unit = id_medicine_unit;
            Status = status;
            User_Created = user_created;
            User_Modified = user_modified;
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Medicine_ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Medicine_Code { set; get; }

        [Required]
        [StringLength(256)]
        public string Medicine_Name { set; get; }

        public string Medicine_Alias { set; get; }

        public string Medicine_Image { set; get; }


        [Required]
        [DefaultValue(0)]
        public decimal Price { set; get; }

        [Required]
        public decimal Original_Price { set; get; }

        public int Quantity { set; get; }

        public string Element { set; get; }

        public string Effect { set; get; }

        public string Indications { set; get; }

        public string Contraindications { set; get; }

        public string Caution { set; get; }

        public string Dosage_And_Administration { set; get; }

        public int? Warranty { set; get; }

        public string Packing { set; get; }

        public int? Inventory_Min { set; get; }

        public int? Inventory_Max { set; get; }

        [Required]
        public int ID_Medicine_Category { set; get; }

        [Required]
        public int ID_Medicine_Unit { set; get; }

        public Status Status { set; get; }

        public DateTime Date_Created { set; get; }

        public DateTime Date_Modified { set; get; }

        public string User_Created { set; get; }

        public string User_Modified { set; get; }

        [ForeignKey("ID_Medicine_Category")]
        public virtual Medicine_Category Medicine_Categories { set; get; }

        [ForeignKey("ID_Medicine_Unit")]
        public virtual Medicine_Unit Medicine_Units { set; get; }

        public virtual ICollection<Medicine_Batch> Medicine_Batches { set; get; }

        public virtual ICollection<Invoice_Detail> Invoice_Details { set; get; }

        //public Medicine()
        //{
        //    Medicine_Batches = new List<Medicine_Batch>();
        //}

        //public Medicine(string medicine_code, string medicine_name, string medicine_alias, string medicine_image,
        //    decimal price, decimal original_price, int quantity, string element, 
        //    string effect, string indications, string contraindications, string caution,
        //    string dosage_and_administration, int warranty, string packing, int inventory_min,
        //    string inventory_Max, int Id_medicine_category, int Id_medicine_unit)
        //{
        //    Medicine_Code = medicine_code;
        //    Medicine_Name = medicine_name;
        //    Medicine_Alias = medicine_alias;
        //    Medicine_Image = medicine_image;
        //    Price = price;
        //    Original_Price = original_price;
        //    Quantity = quantity;
        //    Element = element;
        //    Effect = effect;
        //    Indications = indications;
        //    Contraindications = contraindications;
        //    Caution = caution;
        //    Dosage_And_Administration = dosage_and_administration;
        //    Warranty = warranty;
        //    Packing = packing;
        //    In

        //}
    }
}
