﻿using MarcosDuran_Ap1_P1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

namespace MarcosDuran_Ap1_P1.Components.DAL;

public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
{
    public DbSet<Prestamo> Prestamo { get; set; }

}

