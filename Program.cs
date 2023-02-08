using Api_Tcc.Models;

class Program
{
    static void Main(string[] args)
    {
        Professor func = new Professor();

        func.Id = 1;
        func.Nome = "Valter Jr";
        func.TipoProfessor = Api_Tcc.Models.Enuns.TipoClasseEnum.Almoxarife;
    }
}
