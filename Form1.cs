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
        public WCFServiceLib.WCFServiceClient client { get; set; }

        public Form1()
        {
            InitializeComponent();
            client = new WCFServiceLib.WCFServiceClient("BasicHttpBinding_IWCFService");
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //AddUser();
            pnlEnterData.Visible = true;
            pnlAddUserData.Visible = true;
            foreach (var panel in pnlEnterData.Controls)
            {
                if (panel is Panel) if ((panel as Panel) != pnlAddUserData) (panel as Panel).Visible = false;
            }
            lblMessage.Text = "Fill all empty fields";
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            //AddAddress();
            pnlEnterData.Visible = true;
            pnlAddAddressData.Visible = true;
            foreach (var panel in pnlEnterData.Controls)
            {
                if (panel is Panel) if ((panel as Panel) != pnlAddAddressData) (panel as Panel).Visible = false;
            }
            lblMessage.Text = "Fill all empty fields";
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            //AddOrder();
            pnlEnterData.Visible = true;
            pnlAddOrderData.Visible = true;
            foreach (var panel in pnlEnterData.Controls)
            {
                if (panel is Panel) if ((panel as Panel) != pnlAddOrderData) (panel as Panel).Visible = false;
            }
            lblMessage.Text = "Fill all empty fields";
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            //RemoveUser();
            pnlEnterData.Visible = true;
            pnlRemoveUser.Visible = true;
            foreach (var panel in pnlEnterData.Controls)
            {
                if (panel is Panel) if ((panel as Panel) != pnlRemoveUser) (panel as Panel).Visible = false;
            }
            lblMessage.Text = "Fill all empty fields";
        }

        private void btnRemoveAddress_Click(object sender, EventArgs e)
        {
            //RemoveAddress();
            pnlEnterData.Visible = true;
            pnlDelAddress.Visible = true;
            foreach (var panel in pnlEnterData.Controls)
            {
                if (panel is Panel) if ((panel as Panel) != pnlDelAddress) (panel as Panel).Visible = false;
            }
            lblMessage.Text = "Fill all empty fields";
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            //RemoveOrder();
            pnlEnterData.Visible = true;
            pnlDelOrder.Visible = true;
            foreach (var panel in pnlEnterData.Controls)
            {
                if (panel is Panel) if ((panel as Panel) != pnlDelOrder) (panel as Panel).Visible = false;
            }
            lblMessage.Text = "Fill all empty fields";
        }

        private void GetData()
        {
            string jsondata = client.GetData();
            data = JsonConvert.DeserializeObject<Data>(jsondata, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            rtbUsers.Clear();
            rtbAddresses.Clear();
            rtbOrders.Clear();

            foreach (var user in data.UserList)
            {
                rtbUsers.Text += "Id: " + user.Id + " | Name: " + user.Name + "\n";
                rtbUsers.Text += "Addresses: ";
                foreach (var addr in user.AddressList)
                {
                    rtbUsers.Text += addr + "; ";
                }
                rtbUsers.Text += "\nOrders: ";
                foreach (var ord in user.OrderList)
                {
                    rtbUsers.Text += ord + "; ";
                }
                rtbUsers.Text += "\n\n";
            }

            foreach (var addr in data.AddressList)
            {
                rtbAddresses.Text += "Id: " + addr.Id + " | City: " + addr.City + " | Street: " + addr.Street
                    + " | Build: " + addr.Build + " | Flat: " + addr.Flat + "\n";
                rtbAddresses.Text += "Users: ";
                foreach (var user in addr.UserList)
                {
                    rtbAddresses.Text += user + "; ";
                }
                rtbAddresses.Text += "\nOrders: ";
                foreach (var ord in addr.OrderList)
                {
                    rtbUsers.Text += ord + "; ";
                }
                rtbAddresses.Text += "\n\n";
            }

            foreach (var ord in data.OrderList)
            {
                rtbOrders.Text += "Id: " + ord.Id + " | GoodName: " + ord.GoodName
                    + " | UserId: " + ord.UserID + " | AddressId: " + ord.AddressID;
                rtbOrders.Text += "\n\n";
            }
        }    

        private void AddUser()
        {
            if (tboxUserName.Text != "")
            {
                pnlEnterData.Visible = false;
                //pnlAddUserData.Visible = false;

                MessageBox.Show("User added. Returned Id: " + client.AddUser(tboxUserName.Text));
                GetData();
            }
            else lblMessage.Text = "Some fields are empty!";
        }

        private void AddAddress()
        {
            if (tboxBuild.Text != "" && tboxCity.Text != "" && tboxFlat.Text != "" && tboxStreet.Text != "")
            {
                pnlEnterData.Visible = false;
                //pnlAddAddressData.Visible = false;

                MessageBox.Show("Address added. Returned Id: " + client.AddAddress(tboxCity.Text, tboxStreet.Text, 
                    Convert.ToInt32(tboxBuild.Text), Convert.ToInt32(tboxFlat.Text)));
                GetData();
            }
            else lblMessage.Text = "Some fields are empty!";
        }

        private void AddOrder()
        {
            
            if (tboxGoodName.Text != "")
            {
                pnlEnterData.Visible = false;
                //pnlAddAddressData.Visible = false;

                MessageBox.Show("Address added. Returned Id: " + client.AddOrder(tboxGoodName.Text));
                GetData();
            }
            else lblMessage.Text = "Some fields are empty!";
        }

        private void RemoveUser()
        {
            try
            {
                if (tboxDelUserId.Text != "")
                {
                    int UserId = Convert.ToInt32(tboxDelUserId.Text);
                    pnlEnterData.Visible = false;
                    if (client.RemoveUser(UserId))
                    {
                        MessageBox.Show("User with id " + UserId + " deleted succesfully.");
                    }
                    else
                    {
                        MessageBox.Show("User with id " + UserId + " doesn't exist.");
                    }
                    GetData();
                }
                else lblMessage.Text = "Some fields are empty!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RemoveAddress()
        {
            try
            {
                if (tboxDelAddress.Text != "")
                {
                    int AddrId = Convert.ToInt32(tboxDelAddress.Text);
                    pnlEnterData.Visible = false;
                    if (client.RemoveAddress(AddrId))
                    {
                        MessageBox.Show("User with id " + AddrId + " deleted succesfully.");
                    }
                    else
                    {
                        MessageBox.Show("User with id " + AddrId + " doesn't exist.");
                    }
                    GetData();
                }
                else lblMessage.Text = "Some fields are empty!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RemoveOrder()
        {
            try
            {
                if (tboxDelOrder.Text != "")
                {
                    int OrdId = Convert.ToInt32(tboxDelOrder.Text);
                    pnlEnterData.Visible = false;
                    if (client.RemoveOrder(OrdId))
                    {
                        MessageBox.Show("User with id " + OrdId + " deleted succesfully.");
                    }
                    else
                    {
                        MessageBox.Show("User with id " + OrdId + " doesn't exist.");
                    }
                    GetData();
                }
                else lblMessage.Text = "Some fields are empty!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlEnterData.Visible = false;
        }

        private void btnOkAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void btnOkAddAddress_Click(object sender, EventArgs e)
        {
            AddAddress();
        }

        private void btnOkAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder();
        }

        private void btnRemUser_Click(object sender, EventArgs e)
        {
            RemoveUser();
        }

        private void btnDelAddress_Click(object sender, EventArgs e)
        {
            RemoveAddress();
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            RemoveOrder();
        }
    }
}
