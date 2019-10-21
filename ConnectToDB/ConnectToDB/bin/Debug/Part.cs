using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToDB
{
    public class Part
    {
        public string impPartID { get; set; }

        public string imbPartRevisionID { get; set; }

        public string impShortDescription { get; set; }

        public int imbQuantityOnHand { get; set; }

        public string fullInfo
        {
            get
            {
                return $"Desc: { impShortDescription }  Rev: { imbPartRevisionID } Quantity on hand: { imbQuantityOnHand } ";
            }

        }


    }
}
