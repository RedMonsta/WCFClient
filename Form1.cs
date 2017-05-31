using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;
using Newtonsoft.Json;

namespace WCFClient
{
    public partial class Form1 : Form
    {
        DataModel.Data data { get; set; }
        WCFServiceLib.WCFServiceClient client { get; set; }

        public Form1()
        {
            InitializeComponent();
            client = new WCFServiceLib.WCFServiceClient("BasicHttpBinding_IWCFService");

            string json = client.GetData();
            data = JsonConvert.DeserializeObject<Data>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });

            foreach (var item in data.UserList)
            {
                richTextBox1.Text += "Id: " + item.Id + " | Name: " + item.Name + "\n";
            }

            //client.AddUser("Vlad");
        }
    }
}
