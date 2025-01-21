using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClickBonus_API.Entidades;

public class Oferta
{
    [Key]
    public int Id { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string Nome { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(200)")]
    public string Descricao { get; set; }
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Valor { get; set; }
    [Required]
    [Column(TypeName = "datetime")]
    public DateTime DataCriacao { get; set; } = DateTime.Now;
}
