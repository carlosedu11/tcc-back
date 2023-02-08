using Api_Tcc.Models.Enuns;

namespace Api_Tcc.Models
{
    public class Professor
    {
    public int Id { get; set; }
    public string Nome { get; set; }
    public TipoClasseEnum TipoProfessor { get; set; }
    }
}