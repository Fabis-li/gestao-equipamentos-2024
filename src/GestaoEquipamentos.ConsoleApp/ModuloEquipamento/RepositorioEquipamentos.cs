using GestaoEquipamentos.ConsoleApp.Compartilhado;

namespace GestaoEquipamentos.ConsoleApp.ModuloEquipamento
{
    public class RepositorioEquipamentos
    {
        private static Equipamento[] equipamentos = new Equipamento[100];        

        public void CadastrarEquipamento(Equipamento novoEquipamento)
        {
            novoEquipamento.Id = GeradorId.GerarIdEquipamento();

            RegistrarEquipamento(novoEquipamento);
        }

        public void RegistrarEquipamento(Equipamento equipamento)
        {
            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] != null)
                    continue;
                else
                {
                    equipamentos[i] = equipamento;
                    break;
                }
            }
        }

        public bool EditarEquipamento(int id, Equipamento novoEquipamento)
        {
            novoEquipamento.Id = id;

            for(int i = 0;i <equipamentos.Length;i++)
            {
                if (equipamentos[i] == null)
                    continue;
                else if (equipamentos[i].Id == id)
                {
                    equipamentos[i] = novoEquipamento;

                    return true;
                }
            }
            return false;
        }

        public bool ExisteEquipamento(int id)
        {
            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamento e = equipamentos[i];

                if(e == null)
                    continue;

                else if (e.Id == id)
                    return true;
            }
            return false;
        }

        public bool ExcluirEquipamento(int id)
        {
            for(int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null)
                    continue;

                else if (equipamentos[i].Id == id)
                {
                    equipamentos[i] = null;

                    return true;
                }
            }
            return false;
        }

        public Equipamento[] SelecionarEquipamento()
        {
            return equipamentos;
        }        
    }
}
