
using System.Text.Json.Serialization;
using Api_Tcc.Models.Enuns;
using RpgApi.Models;

namespace Api_Tcc.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoClasseEnum Classe { get; set; }

        [JsonIgnore]
        public UsuarioDetalhe UsuarioDetalhe { get; set; }

    }
}