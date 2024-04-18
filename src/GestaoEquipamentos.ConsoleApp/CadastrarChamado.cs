namespace GestaoEquipamentos.ConsoleApp
{
    public class CadastrarChamado
    {
        public RepositorioChamados repositorio = new RepositorioChamados();
        public static void Iniciar(RepositorioChamados repositorio)
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

            switch (opcao)
            {
                case 1: CriarChamado(repositorio);
                    break;
                case 2: ListarChamados.Iniciar(repositorio);
                    break;
                case 3: EditarChamado.Iniciar(repositorio);
                    break;
                case 4:
                    //ExcluirChamado.Iniciar();
                    break;
                case 0:
                    //Menu.Iniciar();
                    break;


            }

            static void CriarChamado(RepositorioChamados repositorio)
            {
                Chamado chamado = new Chamado();

                Console.Clear();
                Console.WriteLine("Cadastro de Chamados\n");
                Console.WriteLine("Registrando um novo Chamado\n");
                Console.Write("\nDigite o Título do chamado: ");
                chamado.Titulo = Console.ReadLine();
                Console.Write("Digite a descrição do chamado: ");
                chamado.Descricao = Console.ReadLine();
                Console.Write("Digite o nome do equipamento");
                chamado.Equipamento = Console.ReadLine();               
                Console.Write("Digite a data da abertura: ");
                chamado.DataAbertura = Convert.ToDateTime(Console.ReadLine());

                repositorio.RegistrarChamado(chamado);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nChamado cadastrado com sucesso!");
                Console.ResetColor();

            }
        }
    }
}
