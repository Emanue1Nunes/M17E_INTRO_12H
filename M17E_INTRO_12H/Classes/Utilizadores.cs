using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;

namespace M17E_INTRO_12H.Classes
{

    public class Utilizadores
    {
        public int id;
        public string email;
        public string nome;
        public string palavra_passe;
        public int sal;
        public int perfil;
        BaseDados bd;

        public Utilizadores()
        {
            bd = new BaseDados();
        }

        public bool Verifica_login()
        {
            DataTable dados;
            string sql = @"SELECT * FROM Utilizadores 
                            WHERE email = @email AND palavra_passe = HASHBYTES('SHA2_512',CONCAT(@palavra_passe,sal))";

            List<SqlParameter> parametros = new List<SqlParameter>();
            {
                new SqlParameter()
                {
                    ParameterName = "@email",
                    SqlDbType = SqlDbType.VarChar,
                    Value = email
                },
                new SqlParameter()
                {
                    ParameterName = "@palavra_passe",
                    SqlDbType = SqlDbType.VarChar,
                    Value = palavra_passe
                };
            }

            dados = bd.devolveSQL(sql, parametros);

            if(dados == null|| dados.Rows.Count == 0)
                return false;
            id = Convert.ToInt32(dados.Rows[0]["id"]);
            nome = dados.Rows[0]["nome"].ToString();
            email = dados.Rows[0]["email"].ToString();
            perfil = int.Parse(dados.Rows[0]["perfil"].ToString());
            return true;
        }
    }
}