using MarcosDuran_Ap1_P1.Components.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

namespace MarcosDuran_Ap1_P1.Components.DAL;

public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
{
    public DbSet<Registro> Registro { get; set; }

}

