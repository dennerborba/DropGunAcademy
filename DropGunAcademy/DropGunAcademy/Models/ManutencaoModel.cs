namespace DropGunAcademy.Models
{
    public class ManutencaoModel
    {
        public int Id { get; set; }
        public int IdAeronave { get; set; }
        public DateOnly DataInicio { get; set; }
        public DateOnly DataConclusao { get; set; }
        public string Descricao { get; set; }
        public string TecResp { get; set; }
    }
}
