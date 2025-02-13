using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropGunAcademy.Utils.Entities
{
    public class Aula : EntidadeBase<Aula>
    {
        public string NomeAula { get; set; }
        public DateTime DataAula { get; set; }
        public int DuracaoAula { get; set; }
        public int StatusAula { get; set; } 
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public byte situacao_registro { get; set; }

        protected override string TableName => throw new NotImplementedException();

        protected override List<string> Fields => throw new NotImplementedException();

        protected override Aula Fill(MySqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        protected override void FillParameters(MySqlParameterCollection parameters)
        {
            throw new NotImplementedException();
        }
    }
}
