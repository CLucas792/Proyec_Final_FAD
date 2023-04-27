using Modelos;

namespace Blazor.Pages.MiLaboratorio
{
    public partial class ReciboExamenes
    {
        private Examen examen = new Examen();
        private IEnumerable<Examen> lista { get; set; }
    }
}
