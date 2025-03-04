using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ANDISI_Entidades.CONFIGURACION;
using Dapper;

namespace ANDISI_Datos
{
    public class DUsuario
    {
        private readonly DConnectionFactory dConnectionFactory = null;

        public DUsuario()
        {
            dConnectionFactory = new DConnectionFactory();
        }

        public IList<EUsuario> RecuperaUsuario(string pUserName,string pUsuarioPwd)
        {
            using (var connection = dConnectionFactory.GetConnectionMenuDinamico)
            {
                const string ConsultaSQL = @"SELECT id_usuario,nombre,apaterno,amaterno
                                             FROM cat_usuario
                                             WHERE username=@pUserName
                                             AND  pwduser=@pUsuarioPwd";

                var parameters = new DynamicParameters();

                parameters.Add("@pUserName", pUserName,  DbType.String);
                parameters.Add("@pUsuarioPwd", pUsuarioPwd,DbType.String);

                var response = connection.Query<EUsuario>(ConsultaSQL, parameters, commandType: CommandType.Text).ToList()  ;

                return response;
            }
        }


    }
}
