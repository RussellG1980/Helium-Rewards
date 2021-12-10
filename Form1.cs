using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    webClient.Headers["User-Agent"] = "PostmanRuntime/7.28.4";
                    var json = webClient.DownloadString(textBox1.Text);
                    //var json = webClient.DownloadData(textBox1.Text);
                    // Now parse with JSON.Net
                    // http://jsonviewer.stack.hu/
                    Console.WriteLine(json);                 
                    var ObjResponse = JsonConvert.DeserializeObject<ResponseObj.Rootobject>(json);

                    if (ObjResponse != null)
                    {
                        Console.WriteLine($"Found {ObjResponse.data.Count()} items");
                        Console.WriteLine($"Cursor {ObjResponse.cursor}");

                        //newly created class to store the data i want
                        var myDataList = new List<MyData>();

                        foreach (var item in ObjResponse.data)
                        {
                            Console.Write($"Item {item.type}");
                         
                            //seems path only return a single object, if it does just whip the values out into a new object
                            if (item.path.Length == 1)
                            {
                                var newDataItem = new MyData {
                                    ItemType = item.type,
                                    Challengee = item.path.FirstOrDefault().challengee,
                                    ChallengeeLocation = item.path.FirstOrDefault().challengee_location,
                                    TxPower = item.path.FirstOrDefault().receipt.tx_power,
                                    Frequency = item.path.FirstOrDefault().receipt.frequency

                                };
                                myDataList.Add(newDataItem);
                            }
                            else
                            {
                                var paths = item.path.ToList();

                                foreach (var pathItem in paths)
                                {
                                    //Console.Write($"Item {pathItem.challengee}");
                                    //Console.Write($"Item {pathItem.challengee_location}");

                                    ////get receipt info from pathItem
                                    //Console.Write($"Item {pathItem.receipt.frequency}");
                                    //Console.Write($"Item {pathItem.receipt.snr}");
                                    //Console.Write($"Item {pathItem.receipt.tx_power}");

                                    var newDataItem = new MyData
                                    {
                                        ItemType = item.type,
                                        Challengee = pathItem.challengee,
                                        ChallengeeLocation = pathItem.challengee_location,
                                        TxPower = pathItem.receipt.tx_power,
                                        Frequency = pathItem.receipt.frequency

                                    };
                                    myDataList.Add(newDataItem);
                                }
                            }

                        }
                            dataGridView1.DataSource = myDataList;
              
                    }
                    else
                    {
                        Console.WriteLine("No items returned");
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
