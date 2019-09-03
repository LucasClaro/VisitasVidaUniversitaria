using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VisitasVidaUniversitaria
{
    class Visitante
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string cep { get; set; }
        public int idade { get; set; }
        public bool presente { get; set; }

        public void ProcurarRegistro()
        {
            SqlConnection cn = Conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "select id, nome, telefone, cpf, rg, CEP, idade from Participante where email = @email";
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = this.email;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.id = (int)dr["id"];
                this.nome = dr["nome"].ToString();
                this.telefone = dr["telefone"].ToString();
                this.cpf = dr["cpf"].ToString();
                this.rg = dr["rg"].ToString();
                this.cep = dr["CEP"].ToString();
                if(!dr.IsDBNull(6))
                    this.idade = (int)dr["idade"];
            }
        }
    }
}
