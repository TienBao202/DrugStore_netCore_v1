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
    public class MedicineViewModel
    {
      
        public int ID { set; get; }

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

        public  Medicine_CategoryViewModel Medicine_Categories { set; get; }

        public  Medicine_UnitViewModel Medicine_Units { set; get; }

        public ICollection<Medicine_BatchViewModel> Medicine_Batches { set; get; }

        public ICollection<Invoice_DetailViewModel> Invoice_Details { set; get; }

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
