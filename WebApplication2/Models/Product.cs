using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummyBear.Models
{
    [Table("Products")]
    public class Product
    {
      [Key]
      public int ProductId { get; set; }
      public string Name { get; set; }
      public string Cost { get; set; }
      public string Country { get; set; }
      public virtual ICollection<Product> Produccts { get; set; }
    }
    
}