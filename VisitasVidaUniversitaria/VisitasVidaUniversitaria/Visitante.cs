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
            cmd.CommandTimeout = 3;

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
                if (!dr.IsDBNull(6))
                    this.idade = (int)dr["idade"];
                else
                    this.idade = 0;

                cn.Close();
                cn.Dispose();
            }
        }

        public void Salvar()
        {
            SqlConnection cn = Conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandTimeout = 3;

            bool inserindo = this.id == 0;

            if (inserindo)
            {
                cmd.CommandText = "insert into Participante(nome, email, telefone, cpf, rg, CEP, idade, checkin) values (@nome, @email, @telefone, @cpf, @rg, @cep, @idade, 1);";
            }
            else
            {
                cmd.CommandText = "update Participante set nome=@nome, email=@email, telefone=@telefone, cpf=@cpf, rg=@rg, CEP=@cep, idade=@idade, checkin=1 where id=@id;";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = this.id;
            }

            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 100).Value = this.nome;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = this.email;
            cmd.Parameters.Add("@telefone", SqlDbType.VarChar, 50).Value = this.telefone;
            cmd.Parameters.Add("@cpf", SqlDbType.Char, 11).Value = this.cpf;
            cmd.Parameters.Add("@rg", SqlDbType.VarChar, 11).Value = this.rg;
            cmd.Parameters.Add("@cep", SqlDbType.Char, 8).Value = this.cep;
            cmd.Parameters.Add("@idade", SqlDbType.Int).Value = this.idade;

            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
        }
    }
}
