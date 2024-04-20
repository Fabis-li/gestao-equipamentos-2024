namespace GestaoEquipamentos.ConsoleApp.Compartilhado
{
    public static class GeradorId
    {
        private static int IdEquipamento = 0;
        private static int IdChamado = 0;

        public static int GerarIdEquipamento()
        {
            return ++IdEquipamento;
        }

        public static int GeraIdChamado()
        {
            return ++IdChamado;
        }

    }
}
