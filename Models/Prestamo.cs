using System.ComponentModel.DataAnnotations;
namespace MarcosDuran_Ap1_P1.Models;

public class Prestamo
{
    [Key ] 
    public int DeudorId { get; set; }
    [Required]
    public string Deudor { get; set; }
    [Required]
    public string Concepto { get; set; }
    [Required]
    public int Monto { get; set; }
}
