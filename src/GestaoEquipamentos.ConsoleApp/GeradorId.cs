namespace GestaoEquipamentos.ConsoleApp
{
    public static class GeradorId
    {
        private static int IdEquipamento = 0;

        public static int GerarIdEquipamento()
        {
            return ++IdEquipamento;
        }
    }
}
