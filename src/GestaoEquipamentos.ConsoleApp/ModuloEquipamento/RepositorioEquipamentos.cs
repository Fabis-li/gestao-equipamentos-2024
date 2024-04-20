namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    public class RepositorioEquipamentos
    {
        private static Equipamento[] equipamentos = new Equipamento[100];
        public int contadorEquipamentos;

        public void RegistrarEquipamento(Equipamento equipamento)
        {
            equipamentos[contadorEquipamentos] = equipamento;
            contadorEquipamentos++;
            equipamento.Id++;
        }

        public void ListarEquipamentos()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0,-5} | {1,-15} | {2, -15} | {3, -15} | {4, -10} | {5,-10}",
                    "Id", "Número", "Nome", "Preço", "Fabricante", "Data de Fabricação");
            Console.ResetColor();

            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamento equip = equipamentos[i];

                if (equip == null)
                    continue;

                Console.WriteLine("{0,-5} | {1,-15} | {2, -15} | {3, -15} | {4, -10} | {5,-10}",
                    equip.Id, equip.NumeroSerie, equip.Nome, equip.PrecoAquisicao, equip.Fabricante, equip.DataFabricacao.ToShortDateString());

            }

        }

        public Equipamento EncontrarEquipamentoPorId(int idEscolhido)
        {
            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamento e = equipamentos[i];

                if (e == null)
                    continue;

                if (e.Id == idEscolhido)
                    return e;

            }

            return null;

        }
    }
}
