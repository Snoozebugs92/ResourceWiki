using Dapper;
using ResourceWiki.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceWiki.UI.Actions
{
    public class ShowResults
    {
        internal List<TextMatter> DisplayStuff(string selectInput)
        {
            var connectionString = "Data Source=MSI;Initial Catalog=ResourcesWiki;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var sql = $"select Text from dbo.Wiki where Chapter like '%{selectInput}%'";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<TextMatter>(sql).ToList();
            }
        }
    }
}
