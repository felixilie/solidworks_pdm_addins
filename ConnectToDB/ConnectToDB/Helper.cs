using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConnectToDB
{

    static public class Helper
    {

        static public string CnnVal(string name)
        {

            /// FSAFSfaf
            /// 

            return    ConfigurationManager.ConnectionStrings[name].ConnectionString;

            //dsasgadsag 

        }
    }
}
