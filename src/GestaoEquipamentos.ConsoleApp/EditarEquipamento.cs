namespace GestaoEquipamentos.ConsoleApp
{
    public static class EditarEquipamento
    {
        public static void Iniciar(RepositorioEquipamentos repositorio)
        {
            
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Editando Equipamento\n");

            repositorio.ListarEquipamentos();

            Console.Write("\nDigite o Id do equipamento que deseja editar: ");
            int equipamentoEscolhido = Convert.ToInt32(Console.ReadLine());
            Equipamento equipamentoEncontrado = repositorio.EncontrarEquipamentoPorId(equipamentoEscolhido);

            Console.WriteLine();

            Console.Write("\nDigite o número de serie do equipamento: ");
            equipamentoEncontrado.NumeroSerie = Console.ReadLine();
            Console.Write("Digite o nome do equipamento: ");
            equipamentoEncontrado.Nome = Console.ReadLine();
            Console.Write("Digite o preço do equipamento: R$");
            equipamentoEncontrado.PrecoAquisicao = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o fabricante: ");
            equipamentoEncontrado.Fabricante = Console.ReadLine();
            Console.Write("Digite a data de fabricação: ");
            equipamentoEncontrado.DataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEquipamento cadastrado com sucesso!");
            Console.ResetColor();

            Console.ReadLine();

        }

       
    }
}
