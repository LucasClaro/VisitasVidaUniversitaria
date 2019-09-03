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
        public string cpf { get; set; }
        public string rg { get; set; }
        public string cep { get; set; }
        public int idade { get; set; }
        public bool presente { get; set; }

        public Visitante ProcurarRegistro()
        {
            SqlConnection cn = Conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "select "
        }
    }
}
