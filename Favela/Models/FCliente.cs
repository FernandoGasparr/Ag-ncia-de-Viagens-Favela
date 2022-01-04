using System.ComponentModel.DataAnnotations;

namespace Favela.Models
{
    public class FCliente
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string nome { get; set; }

        [Required]
        public string email { get; set; }


        [Required]
        [MaxLength(11), MinLength(11)]
        public string CPF { get; set; }

        public int FPromocaoId { get; set; }
        public FPromocao FPromocao { get; set; }
    }
}
