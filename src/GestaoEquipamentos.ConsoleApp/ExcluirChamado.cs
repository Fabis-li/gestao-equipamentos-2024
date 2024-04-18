namespace GestaoEquipamentos.ConsoleApp
{
    public class ExcluirChamado
    {
        public static void Iniciar(RepositorioChamados repositorio)
        {
            Console.Clear();
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Excluindo Chamado\n");

            repositorio.ListarChamados();

            Console.Write("\nDigite o Id do chamado que deseja Excluir: ");
            int chamadoEscolhido = Convert.ToInt32(Console.ReadLine());
            Chamado chamadoEncontrado = repositorio.EncontrarChamadoPorId(chamadoEscolhido);

            chamadoEncontrado.Id = 0;
            chamadoEncontrado.Titulo = "";
            chamadoEncontrado.Descricao = "";
            chamadoEncontrado.DataAbertura = DateTime.MinValue; 
            chamadoEncontrado.DiasEmAberto = 0;
           

            Console.ReadLine();
        }
    }
}
