using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helium_Rewards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var webClient = new System.Net.WebClient())
            //using (var webClient = new System.Net.WebClient { Encoding = System.Text.Encoding.UTF8 })
            {
                webClient.Headers["User-Agent"] = "PostmanRuntime/7.28.4";
                var json = webClient.DownloadString(textBox1.Text);
                //var json = webClient.DownloadData(textBox1.Text);
                // Now parse with JSON.Net
                // http://jsonviewer.stack.hu/
                //Console.WriteLine(json); - confirmed the above returns json

                //ReadJSON.Rootobject record = JsonConvert.DeserializeObject<ReadJSON.Rootobject>(json);

                //ReadJSON.Receipt recordReceipt = JsonConvert.DeserializeObject<ReadJSON.Receipt>(json);

                //dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(json);
                //string results = obj.results;
                //foreach (string result in results.Split())
                //{
                //    Console.WriteLine(result);
                //}



                //Console.WriteLine("JSON details");
                ////Console.WriteLine(recordReceipt.origin);
                //Console.WriteLine(recordReceipt.signal);
                //Console.WriteLine(recordReceipt.snr);
                //Console.WriteLine(recordReceipt.tx_power);
                //Console.WriteLine();


            }
        }


        //internal static bool IsValidJson(string data)
        //{
        //    data = data.Trim();
        //    try
        //    {
        //        if (data.StartsWith("{") && data.EndsWith("}"))
        //        {
        //            Newtonsoft.Json.Linq.JToken.Parse(data);
        //            Console.WriteLine("jToken - Parsing");
   


        //            Console.WriteLine();

        //        }
        //        else if (data.StartsWith("[") && data.EndsWith("]"))
        //        {
        //            Newtonsoft.Json.Linq.JArray.Parse(data);
        //            Console.WriteLine("jArray - Parsing");
        //            Console.WriteLine();
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}



        //static async Task Main(string[] args)
        //{
        //    using (var httpClient = new HttpClient())
        //    {
        //        var json = await httpClient.GetStringAsync(textBox1.Text);
        //        // Now parse with JSON.Net
        //    }
        //}
    }
}
