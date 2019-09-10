using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VisitasVidaUniversitaria
{
    class Conexao
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=10.135.0.53\\sqledutsi;Database=VidaUniversitaria;User Id=Lucas; password=supermario;Connection Timeout = 5";
            cn.Open();
            return (cn);
        } 
    }
}
