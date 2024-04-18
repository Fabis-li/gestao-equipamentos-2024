namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           RepositorioEquipamentos repositorio = new RepositorioEquipamentos();

            Menu.Iniciar(repositorio);           
            
        }
    }
}
