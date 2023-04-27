using Modelos;

namespace Blazor.Pages.MiLaboratorio
{
    public partial class TomaMuestras
    {
        private Examen examen = new Examen();
    }
}
enum tipoExamen
{
    Seleccione,
    Hemograma,
    Orina,
    Glucosa,
    PCR
}