

using GestaoEquipamentos.ConsoleApp.ModuloChamado;
using GestaoEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoEquipamentos.ConsoleApp
{
    public class Menu
    {
        public static void Iniciar(RepositorioEquipamentos repositorio, RepositorioChamados repositorioChamados)
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
                    case 2:CadastrarChamado.Iniciar(repositorioChamados); break;

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
