namespace GestaoEquipamentos.ConsoleApp
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

        public Equipamento(int id, string nome, decimal precoAquisicao, string numeroSerie, DateTime dataFabricacao, string fabricante)
        {
            Id = GeradorId.GerarIdEquipamento();
            Nome = nome;
            PrecoAquisicao = precoAquisicao;
            NumeroSerie = numeroSerie;
            DataFabricacao = dataFabricacao;
            Fabricante = fabricante;
        }      

        public void ExcluirEquipamento()
        {
            this.Nome = "";
            this.PrecoAquisicao = 0;
            this.NumeroSerie = "";
            this.DataFabricacao = DateTime.MinValue;
            this.Fabricante = "";
        }


    }
}
