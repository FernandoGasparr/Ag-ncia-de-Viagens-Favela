using System.ComponentModel.DataAnnotations;

namespace travels_favela.Models
{
    public class Promocao
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }   

    }
}
