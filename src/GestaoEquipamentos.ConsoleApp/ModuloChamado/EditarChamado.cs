using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp.ModuloChamado
{
    public class EditarChamado
    {
        public static void Iniciar(RepositorioChamados repositorio)
        {
            Console.Clear();
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Editando Chamado\n");

            repositorio.ListarChamados();

            Console.Write("\nDigite o Id chamado para editar: ");
            int chamadoEscolhido = Convert.ToInt32(Console.ReadLine());
            Chamado chamadoEncontrado = repositorio.EncontrarChamadoPorId(chamadoEscolhido);

            Console.WriteLine();

            Console.Write("\nDigite o título do chamado: ");
            chamadoEncontrado.Titulo = Console.ReadLine();
            Console.Write("Digite a descrição do chamdo: ");
            chamadoEncontrado.Descricao = Console.ReadLine();
            Console.Write("Digite o equipamento");
            chamadoEncontrado.Equipamento = Console.ReadLine();
            Console.Write("Digite o fabricante: ");


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nChamado editado com sucesso!");
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
