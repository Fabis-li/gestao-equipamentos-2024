namespace GestaoEquipamentos.ConsoleApp
{
    public static class ListarEquipamento
    {
        public static void Iniciar(RepositorioEquipamentos repositorio)
        {            
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Visualizando Equipamento");

            repositorio.ListarEquipamentos();

            Console.ReadLine();       

        }
    }
}
