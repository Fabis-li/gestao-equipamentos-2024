namespace GestaoEquipamentos.ConsoleApp
{    
    public class RepositorioEquipamentos
    {      
        private Equipamento[] equipamentos = new Equipamento[100];
        public int contadorEquipamentos;

        public void RegistrarEquipamento(Equipamento equipamento)
        {
            equipamentos[contadorEquipamentos]  = equipamento;
            contadorEquipamentos++;
        }

        public void ListarEquipamentos()
        {
            for (int i = 0;  i < equipamentos.Length; i++)
            {
                Console.WriteLine(equipamentos[i].ToString());
            }
        }
    }
}
