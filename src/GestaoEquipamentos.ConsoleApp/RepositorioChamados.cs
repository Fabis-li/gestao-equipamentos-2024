

namespace GestaoEquipamentos.ConsoleApp
{
    public class RepositorioChamados
    {
        private static Chamado[] chamados = new Chamado[100];
        public int contadorChamados;

        public void RegistrarChamado(Chamado chamado)
        {
            chamados[contadorChamados] = chamado;
            contadorChamados++;
            chamado.Id++;
        }

        public void ListarChamados()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0,-5} | {1,-15} | {2, -15} | {3, -15} | {4, -5}",
                    "Id","Título", "Equipamento", "Data da Abertura", "Dias em Aberto");
            Console.ResetColor();

            for (int i = 0; i < chamados.Length; i++)
            {
                Chamado chamado = chamados[i];

                if (chamado == null)
                    continue;

                Console.WriteLine("{0,-5} | {1,-15} | {2, -15} | {3, -15} | {4, -5}",
                    chamado.Id,chamado.Titulo, chamado.Equipamento, chamado.DataAbertura.ToShortDateString(), chamado.DiasEmAberto);

            }
        }

        public Chamado EncontrarChamadoPorId(int idEscolhido)
        {
            for (int i = 0; i < chamados.Length; i++)
            {
                Chamado ch = chamados[i];

                if (ch == null)
                    continue;

                if (ch.Id == idEscolhido)
                    return ch;
            }

            return null;

        }
    }
}
