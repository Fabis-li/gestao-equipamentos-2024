using GestaoEquipamentos.ConsoleApp.Compartilhado;

namespace GestaoEquipamentos.ConsoleApp.ModuloChamado
{
    public class Chamado
    {
        public int Id;
        public string Titulo;
        public string Descricao;
        public string Equipamento;
        public DateTime DataAbertura;
        public int DiasEmAberto;


        public Chamado()
        {
        }

        public Chamado(string titulo, string descricao, string equipamento, DateTime dataAbertura)
        {
            Id = GeradorId.GeraIdChamado();
            Titulo = titulo;
            Descricao = descricao;
            Equipamento = equipamento;
            DataAbertura = dataAbertura;
        }

        public int CalcularDias()
        {
            TimeSpan dias = DateTime.Now - DataAbertura;
            return (int)dias.TotalDays;
        }


    }


}
