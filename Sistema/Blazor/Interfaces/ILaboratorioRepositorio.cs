using Modelos;

namespace Blazor.Interfaces
{
    public interface ILaboratorioRepositorio
    {
        Task<bool> NuevoAsync(Examen examen);

        Task<Cliente> GetPorIdentidadAsync(string IdentidadCliente);
    }
}
