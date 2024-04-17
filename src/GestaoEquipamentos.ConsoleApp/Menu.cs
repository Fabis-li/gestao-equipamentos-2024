

namespace GestaoEquipamentos.ConsoleApp
{
    public class Menu
    {
        public void Iniciar(RepositorioEquipamentos repositorio)
        {

            Console.Clear();
            Opcoes();

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                 

            }

            static void Opcoes()
            {
                Console.WriteLine("Gestão de Equipamentos");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1 - Cadastro de Equipamentos");
                Console.WriteLine("0 - Sair");                
            }

        }
    }
}
