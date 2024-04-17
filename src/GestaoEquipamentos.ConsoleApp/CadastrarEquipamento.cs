namespace GestaoEquipamentos.ConsoleApp
{
    public class CadastrarEquipamento
    {       
        public RepositorioEquipamentos repositorio = new RepositorioEquipamentos();        
        public void ObterDados()
        {
            Equipamento equipamento = new Equipamento();

            Console.WriteLine("Cadastro de Equipamentos\n");
            Console.WriteLine("Registrando um novo Equipamento\n");
            Console.Write("Digite o nome do equipamento: ");
            equipamento.Nome = Console.ReadLine();            
            Console.Write("\nDigite o preço do equipamento: ");
            equipamento.PrecoAquisicao = Convert.ToDecimal(Console.ReadLine());
            Console.Write("\nDigite o número de serie do equipamento: ");
            equipamento.NumeroSerie = Console.ReadLine();
            Console.Write("\nDigite a data de fabricação: ");
            equipamento.DataFabricacao = Console.ReadLine();
            Console.Write("\nDigite o fabricante: ");
            equipamento.Fabricante = Console.ReadLine();

            repositorio.RegistrarEquipamento(equipamento);
        }

        public static void Iniciar(RepositorioEquipamentos repositorio)
        {
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------");
            Console.WriteLine("1 - Cadastrar Equipamentos");
            Console.WriteLine("2 - Listar Equipamentos");
            Console.WriteLine("3 - Editar Equipamento");
            Console.WriteLine("4 - Excluir Equipamento");
            Console.WriteLine("0 - Voltar ao Menu\n");
            Console.Write("Digite uma opção: "); 
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                
            }
                

        }

        

        
    }
}
