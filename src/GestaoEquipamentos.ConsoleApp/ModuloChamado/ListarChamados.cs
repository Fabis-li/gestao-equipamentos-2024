namespace GestaoEquipamentos.ConsoleApp.ModuloChamado
{
    public static class ListarChamados
    {
        public static void Iniciar(RepositorioChamados repositorio)
        {
            Console.Clear();
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Visualizando Chamados");

            repositorio.ListarChamados();

            Console.ReadLine();

        }
    }
}
