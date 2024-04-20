using System.ComponentModel;

namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    public class CadastrarEquipamento
    {
        public RepositorioEquipamentos repositorio = new RepositorioEquipamentos();


        public static void Iniciar(RepositorioEquipamentos repositorio)
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

            switch (opcao)
            {
                case 1:
                    ObterEquipamento(repositorio);
                    break;
                case 2:
                    ListarEquipamento.Iniciar(repositorio);
                    break;
                case 3:
                    EditarEquipamento.Iniciar(repositorio);
                    break;
                case 4:
                    ExcluirEquipamento.Iniciar(repositorio);
                    break;
                case 0: //Menu.Iniciar(repositorio);
                    break;


            }

            static void ObterEquipamento(RepositorioEquipamentos repositorio)
            {
                Equipamento equipamento = new Equipamento();

                Console.Clear();
                Console.WriteLine("Cadastro de Equipamentos\n");
                Console.WriteLine("Registrando um novo Equipamento\n");
                Console.Write("\nDigite o número de serie do equipamento: ");
                equipamento.NumeroSerie = Console.ReadLine();
                Console.Write("Digite o nome do equipamento: ");
                equipamento.Nome = Console.ReadLine();
                Console.Write("Digite o preço do equipamento: R$");
                equipamento.PrecoAquisicao = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Digite o fabricante: ");
                equipamento.Fabricante = Console.ReadLine();
                Console.Write("Digite a data de fabricação: ");
                equipamento.DataFabricacao = Convert.ToDateTime(Console.ReadLine());

                repositorio.RegistrarEquipamento(equipamento);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nEquipamento cadastrado com sucesso!");
                Console.ResetColor();

            }

        }
    }
}
