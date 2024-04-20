namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    public class TelaEquipamento
    {
        RepositorioEquipamentos repositorio = new RepositorioEquipamentos();

        public TelaEquipamento()
        {
            Equipamento equiTest = new Equipamento("Notebook", 2000.00m, "AEX-120", DateTime.Now, "Acer");

            repositorio.CadastrarEquipamento(equiTest);
        }

        public int ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("1 - Cadastrar Equipamentos");
            Console.WriteLine("2 - Listar Equipamentos");
            Console.WriteLine("3 - Editar Equipamento");
            Console.WriteLine("4 - Excluir Equipamento");
            Console.WriteLine("0 - Voltar ao Menu\n");

            Console.Write("Digite uma opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            return opcao;
        }

        public void CadastrarEquipamento()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Equipamentos\n");
            Console.WriteLine("Registrando um novo Equipamento\n");
            Console.Write("\nDigite o número de serie do equipamento: ");
            string numeroSerie = Console.ReadLine();
            Console.Write("Digite o nome do equipamento: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do equipamento: R$");
            decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o fabricante: ");
            string fabricante = Console.ReadLine();
            Console.Write("Digite a data de fabricação: ");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Equipamento equipamento = new Equipamento(nome, precoAquisicao, numeroSerie,dataFabricacao, fabricante);

            repositorio.CadastrarEquipamento(equipamento);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEquipamento cadastrado com sucesso!");
            Console.ResetColor();
        }

        public void EditarEquipamento()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Editando Equipamento\n");            

            Console.Write("\nDigite o Id do equipamento que deseja editar: ");
            int equipamentoEscolhido = Convert.ToInt32(Console.ReadLine());

            if (!repositorio.ExisteEquipamento(equipamentoEscolhido))
            {
                Console.WriteLine("O equipamento não existe");
                return;
            }

            Console.WriteLine();

            Console.Write("\nDigite o número de serie do equipamento: ");
            string numeroSerie = Console.ReadLine();
            Console.Write("Digite o nome do equipamento: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do equipamento: R$");
            decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite o fabricante: ");
            string fabricante = Console.ReadLine();
            Console.Write("Digite a data de fabricação: ");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Equipamento equipamento = new Equipamento(nome, precoAquisicao, numeroSerie, dataFabricacao, fabricante);

            bool conseguiuEditar = repositorio.EditarEquipamento(equipamentoEscolhido, equipamento);

            if(!conseguiuEditar)
            {
                Console.WriteLine("Houve um erro durante a edição do equiapmento.");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEquipamento foi editado com sucesso!");
            Console.ResetColor();

            Console.ReadLine();
        }

        public void ExcluirEquipamento()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Excluindo Equipamento\n");            

            Console.Write("\nDigite o Id do equipamento que deseja Excluir: ");
            int equipamentoEscolhido = Convert.ToInt32(Console.ReadLine());

            if (!repositorio.ExisteEquipamento(equipamentoEscolhido))
            {
                Console.WriteLine("O equipamento mencionado não existe.");
                return;
            }

            bool conseguiuExcluir = repositorio.ExcluirEquipamento(equipamentoEscolhido);

            if (!conseguiuExcluir)
            {
                Console.WriteLine("Houve um erro durante a exclusão do equipamento");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEquipamento excluido com sucesso!");
            Console.ResetColor();

            Console.ReadLine();
        }

        public void ListarEquipamento()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Visualizando Equipamento");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0,-5} | {1,-15} | {2, -15} | {3, -15} | {4, -10} | {5,-10}",
                        "Id", "Número", "Nome", "Preço", "Fabricante", "Data de Fabricação");
            Console.ResetColor();

            Equipamento[] equipamentosCadastrados = repositorio.SelecionarEquipamento();

            for(int i = 0; i <  equipamentosCadastrados.Length; i++)
            {
                Equipamento e = equipamentosCadastrados[i];

                if(e == null)
                    continue;

                Console.WriteLine("{0,-5} | {1,-15} | {2, -15} | {3, -15} | {4, -10} | {5,-10}",
                    e.Id, e.NumeroSerie, e.Nome, e.PrecoAquisicao, e.Fabricante, e.DataFabricacao.ToShortDateString());
            }

            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
