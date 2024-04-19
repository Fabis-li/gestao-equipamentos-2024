using GestaoEquipamentos.ConsoleApp.Compartilhado;

namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    public class Equipamento
    {
        public int Id;
        public string Nome;
        public decimal PrecoAquisicao;
        public string NumeroSerie;
        public DateTime DataFabricacao;
        public string Fabricante;

        public Equipamento()
        {
        }

        public Equipamento(string nome, decimal precoAquisicao, string numeroSerie, DateTime dataFabricacao, string fabricante)
        {            
            Nome = nome;
            PrecoAquisicao = precoAquisicao;
            NumeroSerie = numeroSerie;
            DataFabricacao = dataFabricacao;
            Fabricante = fabricante;
        }
    }
}
