using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("Sobrenome")]
        public string Sobrenome { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("DataCadastro")]
        public DateTime DataCadastro { get; set; }

        [Column("Ativo")]
        public bool Ativo { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
