using System;
using System.ComponentModel.DataAnnotations;
 




namespace CoreWithSwag.Models
{
    public class ProductModel
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public double ProdPrice { get; set; }
        public int ProdTerm { get; set; }

    }
        


}


