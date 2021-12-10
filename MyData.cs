using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helium_Rewards
{

    //This class is used to store the data you want that got returned from the web service
    public class MyData
    {
        public string ItemType { get; set; }
        public string Challengee { get; set; }
        public string ChallengeeLocation { get; set; }
        public float Frequency { get; set; }
        public int TxPower { get; set; }

    }
}
