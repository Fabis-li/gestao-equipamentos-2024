namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioEquipamentos repositorio = new RepositorioEquipamentos();
            RepositorioChamados repositorioChamado = new RepositorioChamados();

            Menu.Iniciar(repositorio, repositorioChamado);           
            
        }
    }
}
