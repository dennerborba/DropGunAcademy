namespace DropGunAcademy.Models.Estudante
{
    public class EstudanteModel
    {
        public int id_aluno { get; set; }
        public int id_cidade_naturalidade { get; set; }
        public int id_cidade_end { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string cpf { get; set; }
        public DateTime data_nascimento { get; set; }
        public string end_cep { get; set; }
        public string end_logradouro { get; set; }
        public string end_complemento { get; set; }
        public int end_numero { get; set; }
        public string end_bairro { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public DateTime data_cadastro { get; set; }
        public DateTime data_alteracao { get; set; }
        public int situacao_registro { get; set; }
    }
}
