using Blazor.Interfaces;

using Datos.Repositorios;
using Modelos;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Blazor.Servicios
{
    public class LaboratorioServicio : ILaboratorioRepositorio
    {
        public Task<Cliente> GetPorIdentidadAsync(string IdentidadCliente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NuevoAsync(Examen examen)
        {
            throw new NotImplementedException();
        }

        private readonly Config _config;
        private ILaboratorioRepositorio _LaboratorioRepositorio;

        public LaboratorioServicio(Config config)
        {
            _config = config;
            _LaboratorioRepositorio = new LaboratorioRepositorio(config.CadenaConexion);
        }
    }
    
}


