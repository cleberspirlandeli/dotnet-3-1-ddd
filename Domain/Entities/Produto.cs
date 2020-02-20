using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("NomeProduto")]
        public string NomeProduto { get; set; }

        [Column("Valor")]
        public decimal Valor { get; set; }

        [Column("Disponivel")]
        public bool Disponivel { get; set; }

        [Column("ClienteId")]
        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
