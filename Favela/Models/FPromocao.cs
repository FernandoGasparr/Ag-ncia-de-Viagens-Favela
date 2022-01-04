using System.ComponentModel.DataAnnotations;

namespace Favela.Models
{
    public class FPromocao
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<FCliente> FCliente { get; set; }


    }
}
