namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CadastrarEquipamento cadastro = new CadastrarEquipamento();
            cadastro.ObterDados();
            
        }
    }
}
