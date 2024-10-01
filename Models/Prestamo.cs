using System.ComponentModel.DataAnnotations;
namespace MarcosDuran_Ap1_P1.Models;

public class Prestamo
{
    [Key ] 
    public int DeudorId { get; set; }
    [Required(ErrorMessage ="El nombre del deudor es requerido")]
    public string Nombres { get; set; }
    [Required(ErrorMessage ="El concepto del prestamo es requerido")]
    public string Concepto { get; set; }
    [Required(ErrorMessage = "El monto del prestamo es requerido")]
    public int Monto { get; set; }
}
