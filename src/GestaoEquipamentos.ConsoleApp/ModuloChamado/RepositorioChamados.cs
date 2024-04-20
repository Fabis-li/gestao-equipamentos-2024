using GestaoEquipamentos.ConsoleApp.Compartilhado;
using GestaoEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoEquipamentos.ConsoleApp.ModuloChamado
{
    public class RepositorioChamados
    {
        private static Chamado[] chamados = new Chamado[100];
        
        public void CadastrarChamado(Chamado novoChamado)
        {
            novoChamado.Id = GeradorId.GeraIdChamado();

            RegistrarChamado(novoChamado);
        }

        public void RegistrarChamado(Chamado chamado)
        {
            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] != null)
                    continue;
                else
                {
                    chamados[i] = chamado;
                    break;
                }
            }
        }

        public bool EditarChamado(int id, Chamado novoChamado)
        {
            novoChamado.Id = id;

            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] == null)
                    continue;
                else if (chamados[i].Id == id)
                {
                    chamados[i] = novoChamado;

                    return true;
                }
            }
            return false;
        }

        public bool ExisteChamado(int id)
        {
            for (int i = 0; i < chamados.Length; i++)
            {
                Chamado ch = chamados[i];

                if (ch == null)
                    continue;

                else if (ch.Id == id)
                    return true;
            }
            return false;
        }

        public bool ExcluirChamado(int id)
        {
            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] == null)
                    continue;

                else if (chamados[i].Id == id)
                {
                    chamados[i] = null;

                    return true;
                }
            }
            return false;
        }

        public Chamado[] SelecionarChamado()
        {
            return chamados;
        }

        public void ListarChamados()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0,-5} | {1,-15} | {2, -15} | {3, -15} | {4, -5}",
                    "Id", "Título", "Equipamento", "Data da Abertura", "Dias em Aberto");
            Console.ResetColor();

            for (int i = 0; i < chamados.Length; i++)
            {
                Chamado chamado = chamados[i];

                if (chamado == null)
                    continue;

                Console.WriteLine("{0,-5} | {1,-15} | {2, -15} | {3, -15} | {4, -5}",
                    chamado.Id, chamado.Titulo, chamado.Equipamento, chamado.DataAbertura.ToShortDateString(), chamado.CalcularDias());

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
