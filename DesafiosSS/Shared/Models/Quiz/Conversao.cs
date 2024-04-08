
using System.Text.Json;

namespace DesafiosSS.Shared.Models
{
    public class Quiz
    {
        public int Nota { get; set; }
        public int AbaAtiva{ get; set; } = 0;
        public string Nome { get; set; }
        public List<Pergunta> Perguntas { get; set; } = new();
    }

    public class Pergunta
    {
        public int Id { get; set; }
        public bool Votado { get; set; }
        public string Descricao { get; set; }
        public string AlternativaEscolhida { get; set; }
        public string AlternativaCorreta { get; set; }
        public List<string> Alternativas { get; set; } = new();
    }

}
