using System.ComponentModel.DataAnnotations;
namespace MarcosDuran_Ap1_P1.Components.Models
{
    public class Registro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}