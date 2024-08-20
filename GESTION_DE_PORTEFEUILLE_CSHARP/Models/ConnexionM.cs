using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace GESTION_DE_PORTEFEUILLE_CSHARP.Models
{
    class ConnexionM
    {
        public MySqlConnection si_connectionbdd()
        {
            String connexion = "server = localhost; user id = root; database = wallet";
            //user password = ..., tss filaharana fa atao mazava syntax ftsn;
            MySqlConnection conbdd = new MySqlConnection(connexion);
            return conbdd;
        }
    }
}
