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

        

        
    }
}
