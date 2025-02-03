namespace DropGunAcademy.Models.Estudante
{
    public class EstudanteModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public int status { get; set; }
    }
}
