using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helium_Rewards
{
    class ReadJSON
    {

        public class Rootobject
        {
            public Datum[] data { get; set; }
            public string cursor { get; set; }
        }

        //public class Root
        //{
        //    public List<Datum> data { get; set; }
        //    public string cursor { get; set; }
        //}

        public class Datum
        {
            public string type { get; set; }
            public int time { get; set; }
            public string secret { get; set; }
            public string request_block_hash { get; set; }
            public Path[] path { get; set; }
            public string onion_key_hash { get; set; }
            public int height { get; set; }
            public string hash { get; set; }
            public int fee { get; set; }
            public string challenger_owner { get; set; }
            public float challenger_lon { get; set; }
            public string challenger_location { get; set; }
            public float challenger_lat { get; set; }
            public string challenger { get; set; }
        }

        public class Path
        {
            public Witness[] witnesses { get; set; }
            public Receipt receipt { get; set; }
            public Geocode geocode { get; set; }
            public string challengee_owner { get; set; }
            public float challengee_lon { get; set; }
            public string challengee_location_hex { get; set; }
            public string challengee_location { get; set; }
            public float challengee_lat { get; set; }
            public string challengee { get; set; }
        }

        public class Receipt
        {
            public int tx_power { get; set; }
            public long timestamp { get; set; }
            public float snr { get; set; }
            public int signal { get; set; }
            public string origin { get; set; }
            public string gateway { get; set; }
            public float frequency { get; set; }
            public object datarate { get; set; }
            public string data { get; set; }
            public int channel { get; set; }
        }

        public class Geocode
        {
            public string short_street { get; set; }
            public string short_state { get; set; }
            public string short_country { get; set; }
            public string short_city { get; set; }
            public string long_street { get; set; }
            public string long_state { get; set; }
            public string long_country { get; set; }
            public string long_city { get; set; }
            public string city_id { get; set; }
        }

        public class Witness
        {
            public long timestamp { get; set; }
            public float snr { get; set; }
            public int signal { get; set; }
            public string packet_hash { get; set; }
            public string owner { get; set; }
            public string location_hex { get; set; }
            public string location { get; set; }
            public bool is_valid { get; set; }
            public string gateway { get; set; }
            public float frequency { get; set; }
            public string datarate { get; set; }
            public int channel { get; set; }
            public string invalid_reason { get; set; }
        }

    }
}
