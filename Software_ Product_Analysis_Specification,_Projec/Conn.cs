using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software__Product_Analysis_Specification__Projec
{
    public class Conn
    {
        public static readonly string Server = "mongodb://localhost:27017";
        public static readonly string Db = "CertifiqueSe";
        public static readonly string collectionListas = "listas";

        public static IMongoCollection<Lista> AbrirColecaoListas()
        {
            var cli = new MongoClient(Server);
            var db = cli.GetDatabase(Db);
            return db.GetCollection<Lista>(collectionListas);
        }
    }
}
