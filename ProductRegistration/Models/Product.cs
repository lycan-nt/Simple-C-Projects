using System.ComponentModel.DataAnnotations.Schema;

//Felipe D. Santos
namespace ProductRegistration.Models
{

    [Table("Produtos")]

    public class Product
    {
       
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string BarCod { get; set;}

        public string Provider { get; set; }
                   

    }
}
