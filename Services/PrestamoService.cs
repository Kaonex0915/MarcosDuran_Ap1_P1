using MarcosDuran_Ap1_P1.Components.DAL;
using Microsoft.EntityFrameworkCore;
using MarcosDuran_Ap1_P1.Models;
using System.Linq.Expressions;



namespace MarcosDuran_Ap1_P1.Services;

public class PrestamoService
{
    private readonly Contexto _contexto;
    
    public PrestamoService(Contexto contexto)
    {
        _contexto = contexto;
    }

    public async Task<bool>Existe(int id)
    {
        return await _contexto.Prestamo.AllAsync(p => p.DeudorId == id);
    }

    public async Task<bool> Insertar(Prestamo prestamo)
    {
        _contexto.Prestamo.Add(prestamo);
        int insertado = await _contexto.SaveChangesAsync();
        _contexto.Entry(prestamo).State = EntityState.Detached;
        return insertado > 0;

    }

    public async Task<bool> Modificar(Prestamo prestamo)
    {
        _contexto.Update(prestamo);
        int modificado = await _contexto.SaveChangesAsync();
        _contexto.Entry(prestamo).State = EntityState.Detached;
        return modificado > 0;
    }
    public async Task<bool> Guardar(Prestamo prestamo)
    {
        if (await Existe(prestamo.DeudorId))
        {
            return await Insertar(prestamo);
        }
        else
        {
            return await Modificar(prestamo);
        }

    }
    public async Task <bool>Eliminar(int Id)
    {
        var prestamo = await _contexto.Prestamo.Where(p => p.DeudorId == Id).ExecuteDeleteAsync();
        return prestamo > 0;
    }
    public async Task<Prestamo?> Buscar(int Id)
    {
        return await _contexto.Prestamo.AsNoTracking().FirstOrDefaultAsync(p => p.DeudorId == Id);
    }

    public async Task<List<Prestamo>> Listar(Expression<Func<Prestamo, bool>> criterio)
    {
        return await _contexto.Prestamo.AsNoTracking().Where(criterio).ToListAsync();
    }
}



