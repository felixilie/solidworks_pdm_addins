using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ConnectToDB
{
    public class DataAccess
    {
        public List<Part> GetPart(string partNumber)
        {
            // When Connecting to SQL server you should use using so connection won't stay open.
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(@"Server=IPS-SQL1\ECLIPSE;Database=M1_IP;User Id=sa;Password=3c1tT;ApplicationIntent=ReadOnly;"))
            {
                var output = connection.Query<Part>($"select impPartID, imbPartRevisionID, impLongDescriptionText, imbQuantityOnHand from Parts " +
                    $"INNER JOIN PartRevisions on imrPartID = impPartID " +
                    $"INNER JOIN PartBins on imbPartID = impPartID " +
                    $"where impPartID = '{ partNumber }'  ; ").ToList();
                return output;
            }
        }
    }
}
