using GestaoEquipamentos.ConsoleApp.ModuloChamado;
using GestaoEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoEquipamentos.ConsoleApp
{
    public class Menu
    {
        public static void Iniciar()
        {
            TelaEquipamento telaEquipamento = new TelaEquipamento();
            TelaChamado telaChamado = new TelaChamado();

            bool opcaoSairEscolhida = false;

            while (!opcaoSairEscolhida)
            {
                int opcaoEscolhida = Opcoes();                

                switch (opcaoEscolhida)
                {
                    

                    case 1:
                        int opEquip = telaEquipamento.ApresentarMenu();
                        
                        if (opEquip == 0)
                            break;

                        else if (opEquip == 1)
                            telaEquipamento.CadastrarEquipamento();

                        else if (opEquip == 2)
                            telaEquipamento.ListarEquipamento();

                        else if (opEquip == 3)
                            telaEquipamento.EditarEquipamento();

                        else if (opEquip == 4)
                            telaEquipamento.ExcluirEquipamento();

                        break;
                    
                    case 2:
                        int opChamado = telaChamado.ApresentarMenu();
                        
                        if (opChamado == 0)
                            break;

                        else if (opChamado == 1)
                            telaChamado.CadastrarChamado();

                        else if (opChamado == 2)
                            telaChamado.ListarChamado();

                        else if (opChamado == 3)
                            telaChamado.EditarChamado();

                        else if (opChamado == 4)
                            telaChamado.ExcluirChamado();                        

                        break;

                    default: opcaoSairEscolhida=true; break;
                }

            }

            Console.ReadLine();

            static int Opcoes()
            {
                Console.Clear();
                Console.WriteLine("Gestão de Equipamentos");
                Console.WriteLine("-----------------------\n");
                Console.WriteLine("1 - Cadastro de Equipamentos");
                Console.WriteLine("2 - Cadastrar Chamado");
                Console.WriteLine("0 - Sair");

                Console.WriteLine();

                Console.Write("Digite a opção desejada: ");
                int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

                return opcaoEscolhida;
               
            }

        }
    }
}
