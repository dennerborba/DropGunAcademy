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
        public byte situacao_registro { get; set; }


        public AulaModel()
        {
            
        }


    }
}
