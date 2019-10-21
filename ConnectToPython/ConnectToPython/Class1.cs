using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EPDM.Interop.epdm;
using Microsoft.VisualBasic;

namespace ConnectToPython
{
    public static class Class1
    {
        public static List<string> GetUserNames()
        {

                IEdmVault5 vault1 = new EdmVault5();
                IEdmVault8 vault = (IEdmVault8)vault1;

                // Connect to vault
                vault.LoginAuto("ACME_LAB_SF", 0); //I think second arg is used when not already logged-in

                // Traverse Users
                IEdmUserMgr7 UsrMgr;
                IEdmUser10 user;
                UsrMgr = (IEdmUserMgr7)vault;
                List<string> UserNames = new List<string>();

                //string Users = "";
                IEdmPos5 UserPos = default(IEdmPos5);
                UserPos = UsrMgr.GetFirstUserPosition();
                while (!UserPos.IsNull)
                {
                    user = (IEdmUser10)UsrMgr.GetNextUser(UserPos);
                    //Users = Users + user.Name + " " + user.IsLoggedIn + "\n";
                    UserNames.Add(user.Name);
                }

                return UserNames;

        }
    }
}
