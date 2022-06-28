using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BDDCLOUD.datos
{
    class clsDatos
    {
        #region Atributos
        SqlConnection atrConection;
        #endregion
        #region Metodos
        #region constructor
        public clsDatos()
        {
            SqlConnectionStringBuilder varCadena = new SqlConnectionStringBuilder
            {
                DataSource = "bddcloudserver.database.windows.net",
                UserID = "BDDCLOUDUSER",
                Password = "DUOLCddb1",
                InitialCatalog = "BDDVIDEOJUEGOS"
            };
            atrConection = new SqlConnection(varCadena.ConnectionString);
        }
        #endregion
        
       
        #endregion
    }
}