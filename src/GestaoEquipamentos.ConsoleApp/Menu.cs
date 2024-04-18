

namespace GestaoEquipamentos.ConsoleApp
{
    public class Menu
    {
        public static void Iniciar(RepositorioEquipamentos repositorio)
        {
            bool opcaoSairEscolhida = false;

            while (!opcaoSairEscolhida)
            {
                Console.Clear();
                Opcoes();

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1: CadastrarEquipamento.Iniciar(repositorio); break;
                    case 2:;break;

                    default: opcaoSairEscolhida=true; break;
                }

            }

            Console.ReadLine();

            static void Opcoes()
            {
                Console.WriteLine("Gestão de Equipamentos");
                Console.WriteLine("-----------------------\n");
                Console.WriteLine("1 - Cadastro de Equipamentos");
                Console.WriteLine("2 - Cadastrar Chamado");
                Console.WriteLine("0 - Sair");

                
               
            }

        }
    }
}
