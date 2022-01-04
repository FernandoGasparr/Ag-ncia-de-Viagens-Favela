using System.ComponentModel.DataAnnotations;

namespace travels_favela.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        
        public string nome { get; set; }    

        public string email { get; set; }
        
        
        public string CPF { get; set; }   

    }
}
