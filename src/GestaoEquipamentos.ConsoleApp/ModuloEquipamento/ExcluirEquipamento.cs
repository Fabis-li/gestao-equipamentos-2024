namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    public static class ExcluirEquipamento
    {
        public static void Iniciar(RepositorioEquipamentos repositorio)
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Excluindo Equipamento\n");

            repositorio.ListarEquipamentos();

            Console.Write("\nDigite o Id do equipamento que deseja Excluir: ");
            int equipamentoEscolhido = Convert.ToInt32(Console.ReadLine());
            Equipamento equipamentoEncontrado = repositorio.EncontrarEquipamentoPorId(equipamentoEscolhido);

            equipamentoEncontrado.Id = 0;
            equipamentoEncontrado.NumeroSerie = "";
            equipamentoEncontrado.Nome = "";
            equipamentoEncontrado.PrecoAquisicao = 0;
            equipamentoEncontrado.Fabricante = "";
            equipamentoEncontrado.DataFabricacao = DateTime.MinValue;

            Console.ReadLine();

        }
    }
}
