using DropGunAcademy.Utils.Entities;


namespace DropGunAcademy.Models.Aulas
{
    public class AulaModel
    {
        public int Id { get; set; }
        public string NomeAula { get; set; }
        public DateTime DataAula { get; set; }
        public int DuracaoAula { get; set; }
        public int StatusAula { get; set; } 
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Aula.SituacaoRegistro? Situacao_registro { get; set; }


        public AulaModel()
        {
            
        }

        public AulaModel (Aula aula)
        {
            Id = aula.ID;
            NomeAula = aula.NomeAula;
            DataAula = aula.DataAula;
            DuracaoAula = aula.DuracaoAula;
            DataCadastro = aula.DataCadastro;
            DataAlteracao = aula.DataAlteracao;
            Situacao_registro = aula.Situacao_registro;
        }

        public Aula GetEntidade()
        {
            return new Aula()
            {
                ID = Id,
                NomeAula = NomeAula,
                DataAula = DataAula,
                DuracaoAula = DuracaoAula,
                DataCadastro = DataCadastro,
                DataAlteracao = DataAlteracao,
                Situacao_registro = Situacao_registro.Value
            };
        }
    }
}
