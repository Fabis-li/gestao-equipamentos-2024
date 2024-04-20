namespace GestaoEquipamentos.ConsoleApp.ModuloChamado
{
    public class TelaChamado
    {
        RepositorioChamados repositorio = new RepositorioChamados();

        public int ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("1 - Cadastrar Chamado");
            Console.WriteLine("2 - Listar Chamados");
            Console.WriteLine("3 - Editar Chamado");
            Console.WriteLine("4 - Excluir Chamado");
            Console.WriteLine("0 - Voltar ao Menu\n");

            Console.Write("Digite uma opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            return opcao;
        }

        public void CadastrarChamado()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Chamados\n");
            Console.WriteLine("Registrando um novo Chamado\n");
            Console.Write("\nDigite o Título do chamado: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite a descrição do chamado: ");
            string descricao = Console.ReadLine();
            Console.Write("Digite o nome do equipamento: ");
            string equipamento = Console.ReadLine();
            Console.Write("Digite a data da abertura: ");
            DateTime dataAbertura = Convert.ToDateTime(Console.ReadLine());

            Chamado chamado = new Chamado(titulo, descricao, equipamento, dataAbertura);

            repositorio.CadastrarChamado(chamado);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nChamado cadastrado com sucesso!");
            Console.ResetColor();
        }

        public void EditarChamado()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Editando Chamado\n");            

            Console.Write("\nDigite o Id chamado para editar: ");
            int chamadoEscolhido = Convert.ToInt32(Console.ReadLine());

            if (!repositorio.ExisteChamado(chamadoEscolhido))
            {
                Console.WriteLine("O chamdo não existe");
                return;
            }

            Console.WriteLine();

            Console.Write("\nDigite o título do chamado: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite a descrição do chamdo: ");
            string descricao = Console.ReadLine();
            Console.Write("Digite o equipamento");
            string equipamento = Console.ReadLine();  
            
            Chamado chamado = new Chamado(titulo, descricao, equipamento);

            bool conseguiuEditar = repositorio.EditarChamado(chamadoEscolhido, chamado);

            if (!conseguiuEditar)
            {
                Console.WriteLine("Houve um erro durante a edição do chamado.");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nChamado editado com sucesso!");
            Console.ResetColor();

            Console.ReadLine();
        }

        public void ExcluirChamado()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Excluindo Chamado\n");            

            Console.Write("\nDigite o Id do chamado que deseja Excluir: ");
            int chamadoEscolhido = Convert.ToInt32(Console.ReadLine());

            if (!repositorio.ExisteChamado(chamadoEscolhido))
            {
                Console.WriteLine("O chamado mencionado não existe.");
                return;
            }

            bool conseguiuExcluir = repositorio.ExcluirChamado(chamadoEscolhido);

            if (!conseguiuExcluir)
            {
                Console.WriteLine("Houve um erro durante a exclusão do equipamento");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nChamado excluído com sucesso!");
            Console.ResetColor();

            Console.ReadLine();
        }

        public void ListarChamado()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Visualizando Chamados");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0,-5} | {1,-15} | {2, -15} | {3, -15} | {4, -5}",
                    "Id", "Título", "Equipamento", "Data da Abertura", "Dias em Aberto");
            Console.ResetColor();

            Chamado[] chamados = repositorio.SelecionarChamado();

            for (int i = 0; i < chamados.Length; i++)
            {
                Chamado chamado = chamados[i];

                if (chamado == null)
                    continue;

                Console.WriteLine("{0,-5} | {1,-15} | {2, -15} | {3, -15} | {4, -5}",
                    chamado.Id, chamado.Titulo, chamado.Equipamento, chamado.DataAbertura.ToShortDateString(), chamado.CalcularDias());

            }

            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
