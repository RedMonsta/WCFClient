namespace WCFClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbUsers = new System.Windows.Forms.RichTextBox();
            this.rtbAddresses = new System.Windows.Forms.RichTextBox();
            this.rtbOrders = new System.Windows.Forms.RichTextBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnRemoveAddress = new System.Windows.Forms.Button();
            this.pnlEnterData = new System.Windows.Forms.Panel();
            this.tboxUserName = new System.Windows.Forms.TextBox();
            this.btnOkAddUser = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tboxCity = new System.Windows.Forms.TextBox();
            this.tboxStreet = new System.Windows.Forms.TextBox();
            this.tboxBuild = new System.Windows.Forms.TextBox();
            this.tboxFlat = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblBuild = new System.Windows.Forms.Label();
            this.lblFlat = new System.Windows.Forms.Label();
            this.btnOkAddAddress = new System.Windows.Forms.Button();
            this.pnlAddAddressData = new System.Windows.Forms.Panel();
            this.pnlAddUserData = new System.Windows.Forms.Panel();
            this.pnlAddOrderData = new System.Windows.Forms.Panel();
            this.tboxGoodName = new System.Windows.Forms.TextBox();
            this.lblGoodname = new System.Windows.Forms.Label();
            this.btnOkAddOrder = new System.Windows.Forms.Button();
            this.pnlRemoveUser = new System.Windows.Forms.Panel();
            this.btnRemUser = new System.Windows.Forms.Button();
            this.tboxDelUserId = new System.Windows.Forms.TextBox();
            this.lblDelUserId = new System.Windows.Forms.Label();
            this.pnlDelAddress = new System.Windows.Forms.Panel();
            this.lblDelAddress = new System.Windows.Forms.Label();
            this.tboxDelAddress = new System.Windows.Forms.TextBox();
            this.btnDelAddress = new System.Windows.Forms.Button();
            this.pnlDelOrder = new System.Windows.Forms.Panel();
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.lblDelOrder = new System.Windows.Forms.Label();
            this.tboxDelOrder = new System.Windows.Forms.TextBox();
            this.pnlEnterData.SuspendLayout();
            this.pnlAddAddressData.SuspendLayout();
            this.pnlAddUserData.SuspendLayout();
            this.pnlAddOrderData.SuspendLayout();
            this.pnlRemoveUser.SuspendLayout();
            this.pnlDelAddress.SuspendLayout();
            this.pnlDelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbUsers
            // 
            this.rtbUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbUsers.Location = new System.Drawing.Point(250, 40);
            this.rtbUsers.Name = "rtbUsers";
            this.rtbUsers.ReadOnly = true;
            this.rtbUsers.Size = new System.Drawing.Size(356, 266);
            this.rtbUsers.TabIndex = 0;
            this.rtbUsers.Text = "";
            // 
            // rtbAddresses
            // 
            this.rtbAddresses.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbAddresses.Location = new System.Drawing.Point(250, 354);
            this.rtbAddresses.Name = "rtbAddresses";
            this.rtbAddresses.ReadOnly = true;
            this.rtbAddresses.Size = new System.Drawing.Size(578, 256);
            this.rtbAddresses.TabIndex = 1;
            this.rtbAddresses.Text = "";
            // 
            // rtbOrders
            // 
            this.rtbOrders.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbOrders.Location = new System.Drawing.Point(643, 40);
            this.rtbOrders.Name = "rtbOrders";
            this.rtbOrders.ReadOnly = true;
            this.rtbOrders.Size = new System.Drawing.Size(314, 266);
            this.rtbOrders.TabIndex = 2;
            this.rtbOrders.Text = "";
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(0, 2);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(131, 40);
            this.btnGetData.TabIndex = 3;
            this.btnGetData.Text = "Load Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(0, 91);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(131, 42);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.Location = new System.Drawing.Point(0, 399);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(131, 37);
            this.btnRemoveOrder.TabIndex = 5;
            this.btnRemoveOrder.Text = "Remove Order";
            this.btnRemoveOrder.UseVisualStyleBackColor = true;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(0, 147);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(131, 39);
            this.btnAddAddress.TabIndex = 6;
            this.btnAddAddress.Text = "Add Address";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(0, 202);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(131, 38);
            this.btnAddOrder.TabIndex = 7;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(0, 289);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(131, 38);
            this.btnRemoveUser.TabIndex = 8;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnRemoveAddress
            // 
            this.btnRemoveAddress.Location = new System.Drawing.Point(0, 345);
            this.btnRemoveAddress.Name = "btnRemoveAddress";
            this.btnRemoveAddress.Size = new System.Drawing.Size(131, 37);
            this.btnRemoveAddress.TabIndex = 9;
            this.btnRemoveAddress.Text = "Remove Address";
            this.btnRemoveAddress.UseVisualStyleBackColor = true;
            this.btnRemoveAddress.Click += new System.EventHandler(this.btnRemoveAddress_Click);
            // 
            // pnlEnterData
            // 
            this.pnlEnterData.Controls.Add(this.pnlDelAddress);
            this.pnlEnterData.Controls.Add(this.pnlRemoveUser);
            this.pnlEnterData.Controls.Add(this.pnlAddOrderData);
            this.pnlEnterData.Controls.Add(this.pnlAddUserData);
            this.pnlEnterData.Controls.Add(this.pnlAddAddressData);
            this.pnlEnterData.Controls.Add(this.btnCancel);
            this.pnlEnterData.Controls.Add(this.lblMessage);
            this.pnlEnterData.Location = new System.Drawing.Point(737, 121);
            this.pnlEnterData.Name = "pnlEnterData";
            this.pnlEnterData.Size = new System.Drawing.Size(661, 377);
            this.pnlEnterData.TabIndex = 10;
            this.pnlEnterData.Visible = false;
            // 
            // tboxUserName
            // 
            this.tboxUserName.Location = new System.Drawing.Point(3, 38);
            this.tboxUserName.Name = "tboxUserName";
            this.tboxUserName.Size = new System.Drawing.Size(211, 20);
            this.tboxUserName.TabIndex = 0;
            // 
            // btnOkAddUser
            // 
            this.btnOkAddUser.Location = new System.Drawing.Point(21, 105);
            this.btnOkAddUser.Name = "btnOkAddUser";
            this.btnOkAddUser.Size = new System.Drawing.Size(136, 29);
            this.btnOkAddUser.TabIndex = 1;
            this.btnOkAddUser.Text = "Add User Confirm";
            this.btnOkAddUser.UseVisualStyleBackColor = true;
            this.btnOkAddUser.Click += new System.EventHandler(this.btnOkAddUser_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(134, 26);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "label1";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(3, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(532, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tboxCity
            // 
            this.tboxCity.Location = new System.Drawing.Point(16, 26);
            this.tboxCity.Name = "tboxCity";
            this.tboxCity.Size = new System.Drawing.Size(211, 20);
            this.tboxCity.TabIndex = 5;
            // 
            // tboxStreet
            // 
            this.tboxStreet.Location = new System.Drawing.Point(16, 67);
            this.tboxStreet.Name = "tboxStreet";
            this.tboxStreet.Size = new System.Drawing.Size(211, 20);
            this.tboxStreet.TabIndex = 6;
            // 
            // tboxBuild
            // 
            this.tboxBuild.Location = new System.Drawing.Point(16, 110);
            this.tboxBuild.Name = "tboxBuild";
            this.tboxBuild.Size = new System.Drawing.Size(211, 20);
            this.tboxBuild.TabIndex = 7;
            // 
            // tboxFlat
            // 
            this.tboxFlat.Location = new System.Drawing.Point(16, 152);
            this.tboxFlat.Name = "tboxFlat";
            this.tboxFlat.Size = new System.Drawing.Size(211, 20);
            this.tboxFlat.TabIndex = 8;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(13, 10);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(13, 51);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 10;
            this.lblStreet.Text = "Street";
            // 
            // lblBuild
            // 
            this.lblBuild.AutoSize = true;
            this.lblBuild.Location = new System.Drawing.Point(13, 94);
            this.lblBuild.Name = "lblBuild";
            this.lblBuild.Size = new System.Drawing.Size(30, 13);
            this.lblBuild.TabIndex = 11;
            this.lblBuild.Text = "Build";
            // 
            // lblFlat
            // 
            this.lblFlat.AutoSize = true;
            this.lblFlat.Location = new System.Drawing.Point(18, 138);
            this.lblFlat.Name = "lblFlat";
            this.lblFlat.Size = new System.Drawing.Size(24, 13);
            this.lblFlat.TabIndex = 12;
            this.lblFlat.Text = "Flat";
            // 
            // btnOkAddAddress
            // 
            this.btnOkAddAddress.Location = new System.Drawing.Point(16, 209);
            this.btnOkAddAddress.Name = "btnOkAddAddress";
            this.btnOkAddAddress.Size = new System.Drawing.Size(136, 29);
            this.btnOkAddAddress.TabIndex = 13;
            this.btnOkAddAddress.Text = "Add Address Confirm";
            this.btnOkAddAddress.UseVisualStyleBackColor = true;
            this.btnOkAddAddress.Click += new System.EventHandler(this.btnOkAddAddress_Click);
            // 
            // pnlAddAddressData
            // 
            this.pnlAddAddressData.Controls.Add(this.tboxCity);
            this.pnlAddAddressData.Controls.Add(this.btnOkAddAddress);
            this.pnlAddAddressData.Controls.Add(this.lblCity);
            this.pnlAddAddressData.Controls.Add(this.lblFlat);
            this.pnlAddAddressData.Controls.Add(this.tboxStreet);
            this.pnlAddAddressData.Controls.Add(this.tboxFlat);
            this.pnlAddAddressData.Controls.Add(this.lblBuild);
            this.pnlAddAddressData.Controls.Add(this.lblStreet);
            this.pnlAddAddressData.Controls.Add(this.tboxBuild);
            this.pnlAddAddressData.Location = new System.Drawing.Point(40, 55);
            this.pnlAddAddressData.Name = "pnlAddAddressData";
            this.pnlAddAddressData.Size = new System.Drawing.Size(251, 260);
            this.pnlAddAddressData.TabIndex = 14;
            this.pnlAddAddressData.Visible = false;
            // 
            // pnlAddUserData
            // 
            this.pnlAddUserData.Controls.Add(this.tboxUserName);
            this.pnlAddUserData.Controls.Add(this.lblUserName);
            this.pnlAddUserData.Controls.Add(this.btnOkAddUser);
            this.pnlAddUserData.Location = new System.Drawing.Point(40, 65);
            this.pnlAddUserData.Name = "pnlAddUserData";
            this.pnlAddUserData.Size = new System.Drawing.Size(235, 143);
            this.pnlAddUserData.TabIndex = 15;
            this.pnlAddUserData.Visible = false;
            // 
            // pnlAddOrderData
            // 
            this.pnlAddOrderData.Controls.Add(this.btnOkAddOrder);
            this.pnlAddOrderData.Controls.Add(this.lblGoodname);
            this.pnlAddOrderData.Controls.Add(this.tboxGoodName);
            this.pnlAddOrderData.Location = new System.Drawing.Point(40, 68);
            this.pnlAddOrderData.Name = "pnlAddOrderData";
            this.pnlAddOrderData.Size = new System.Drawing.Size(247, 238);
            this.pnlAddOrderData.TabIndex = 16;
            // 
            // tboxGoodName
            // 
            this.tboxGoodName.Location = new System.Drawing.Point(33, 47);
            this.tboxGoodName.Name = "tboxGoodName";
            this.tboxGoodName.Size = new System.Drawing.Size(172, 20);
            this.tboxGoodName.TabIndex = 0;
            // 
            // lblGoodname
            // 
            this.lblGoodname.AutoSize = true;
            this.lblGoodname.Location = new System.Drawing.Point(30, 26);
            this.lblGoodname.Name = "lblGoodname";
            this.lblGoodname.Size = new System.Drawing.Size(64, 13);
            this.lblGoodname.TabIndex = 1;
            this.lblGoodname.Text = "Good Name";
            // 
            // btnOkAddOrder
            // 
            this.btnOkAddOrder.Location = new System.Drawing.Point(61, 182);
            this.btnOkAddOrder.Name = "btnOkAddOrder";
            this.btnOkAddOrder.Size = new System.Drawing.Size(129, 32);
            this.btnOkAddOrder.TabIndex = 2;
            this.btnOkAddOrder.Text = "Add Order Confirm";
            this.btnOkAddOrder.UseVisualStyleBackColor = true;
            this.btnOkAddOrder.Click += new System.EventHandler(this.btnOkAddOrder_Click);
            // 
            // pnlRemoveUser
            // 
            this.pnlRemoveUser.Controls.Add(this.lblDelUserId);
            this.pnlRemoveUser.Controls.Add(this.tboxDelUserId);
            this.pnlRemoveUser.Controls.Add(this.btnRemUser);
            this.pnlRemoveUser.Location = new System.Drawing.Point(340, 55);
            this.pnlRemoveUser.Name = "pnlRemoveUser";
            this.pnlRemoveUser.Size = new System.Drawing.Size(225, 260);
            this.pnlRemoveUser.TabIndex = 17;
            // 
            // btnRemUser
            // 
            this.btnRemUser.Location = new System.Drawing.Point(41, 195);
            this.btnRemUser.Name = "btnRemUser";
            this.btnRemUser.Size = new System.Drawing.Size(138, 32);
            this.btnRemUser.TabIndex = 0;
            this.btnRemUser.Text = "Remove User Confirm";
            this.btnRemUser.UseVisualStyleBackColor = true;
            this.btnRemUser.Click += new System.EventHandler(this.btnRemUser_Click);
            // 
            // tboxDelUserId
            // 
            this.tboxDelUserId.Location = new System.Drawing.Point(50, 60);
            this.tboxDelUserId.Name = "tboxDelUserId";
            this.tboxDelUserId.Size = new System.Drawing.Size(146, 20);
            this.tboxDelUserId.TabIndex = 1;
            // 
            // lblDelUserId
            // 
            this.lblDelUserId.AutoSize = true;
            this.lblDelUserId.Location = new System.Drawing.Point(50, 32);
            this.lblDelUserId.Name = "lblDelUserId";
            this.lblDelUserId.Size = new System.Drawing.Size(41, 13);
            this.lblDelUserId.TabIndex = 2;
            this.lblDelUserId.Text = "User Id";
            // 
            // pnlDelAddress
            // 
            this.pnlDelAddress.Controls.Add(this.pnlDelOrder);
            this.pnlDelAddress.Controls.Add(this.btnDelAddress);
            this.pnlDelAddress.Controls.Add(this.tboxDelAddress);
            this.pnlDelAddress.Controls.Add(this.lblDelAddress);
            this.pnlDelAddress.Location = new System.Drawing.Point(336, 55);
            this.pnlDelAddress.Name = "pnlDelAddress";
            this.pnlDelAddress.Size = new System.Drawing.Size(229, 260);
            this.pnlDelAddress.TabIndex = 18;
            // 
            // lblDelAddress
            // 
            this.lblDelAddress.AutoSize = true;
            this.lblDelAddress.Location = new System.Drawing.Point(51, 39);
            this.lblDelAddress.Name = "lblDelAddress";
            this.lblDelAddress.Size = new System.Drawing.Size(57, 13);
            this.lblDelAddress.TabIndex = 0;
            this.lblDelAddress.Text = "Address Id";
            // 
            // tboxDelAddress
            // 
            this.tboxDelAddress.Location = new System.Drawing.Point(8, 60);
            this.tboxDelAddress.Name = "tboxDelAddress";
            this.tboxDelAddress.Size = new System.Drawing.Size(175, 20);
            this.tboxDelAddress.TabIndex = 1;
            // 
            // btnDelAddress
            // 
            this.btnDelAddress.Location = new System.Drawing.Point(45, 195);
            this.btnDelAddress.Name = "btnDelAddress";
            this.btnDelAddress.Size = new System.Drawing.Size(138, 32);
            this.btnDelAddress.TabIndex = 2;
            this.btnDelAddress.Text = "Remove Address Confirm";
            this.btnDelAddress.UseVisualStyleBackColor = true;
            this.btnDelAddress.Click += new System.EventHandler(this.btnDelAddress_Click);
            // 
            // pnlDelOrder
            // 
            this.pnlDelOrder.Controls.Add(this.tboxDelOrder);
            this.pnlDelOrder.Controls.Add(this.lblDelOrder);
            this.pnlDelOrder.Controls.Add(this.btnDelOrder);
            this.pnlDelOrder.Location = new System.Drawing.Point(4, 0);
            this.pnlDelOrder.Name = "pnlDelOrder";
            this.pnlDelOrder.Size = new System.Drawing.Size(222, 258);
            this.pnlDelOrder.TabIndex = 19;
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Location = new System.Drawing.Point(31, 195);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(148, 32);
            this.btnDelOrder.TabIndex = 0;
            this.btnDelOrder.Text = "button1";
            this.btnDelOrder.UseVisualStyleBackColor = true;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // lblDelOrder
            // 
            this.lblDelOrder.AutoSize = true;
            this.lblDelOrder.Location = new System.Drawing.Point(38, 39);
            this.lblDelOrder.Name = "lblDelOrder";
            this.lblDelOrder.Size = new System.Drawing.Size(45, 13);
            this.lblDelOrder.TabIndex = 1;
            this.lblDelOrder.Text = "Order Id";
            // 
            // tboxDelOrder
            // 
            this.tboxDelOrder.Location = new System.Drawing.Point(14, 60);
            this.tboxDelOrder.Name = "tboxDelOrder";
            this.tboxDelOrder.Size = new System.Drawing.Size(165, 20);
            this.tboxDelOrder.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 674);
            this.Controls.Add(this.pnlEnterData);
            this.Controls.Add(this.btnRemoveAddress);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.btnRemoveOrder);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.rtbOrders);
            this.Controls.Add(this.rtbAddresses);
            this.Controls.Add(this.rtbUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlEnterData.ResumeLayout(false);
            this.pnlEnterData.PerformLayout();
            this.pnlAddAddressData.ResumeLayout(false);
            this.pnlAddAddressData.PerformLayout();
            this.pnlAddUserData.ResumeLayout(false);
            this.pnlAddUserData.PerformLayout();
            this.pnlAddOrderData.ResumeLayout(false);
            this.pnlAddOrderData.PerformLayout();
            this.pnlRemoveUser.ResumeLayout(false);
            this.pnlRemoveUser.PerformLayout();
            this.pnlDelAddress.ResumeLayout(false);
            this.pnlDelAddress.PerformLayout();
            this.pnlDelOrder.ResumeLayout(false);
            this.pnlDelOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbUsers;
        private System.Windows.Forms.RichTextBox rtbAddresses;
        private System.Windows.Forms.RichTextBox rtbOrders;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnRemoveAddress;
        private System.Windows.Forms.Panel pnlEnterData;
        private System.Windows.Forms.Button btnOkAddUser;
        private System.Windows.Forms.TextBox tboxUserName;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkAddAddress;
        private System.Windows.Forms.Label lblFlat;
        private System.Windows.Forms.Label lblBuild;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tboxFlat;
        private System.Windows.Forms.TextBox tboxBuild;
        private System.Windows.Forms.TextBox tboxStreet;
        private System.Windows.Forms.TextBox tboxCity;
        private System.Windows.Forms.Panel pnlAddUserData;
        private System.Windows.Forms.Panel pnlAddAddressData;
        private System.Windows.Forms.Panel pnlAddOrderData;
        private System.Windows.Forms.Button btnOkAddOrder;
        private System.Windows.Forms.Label lblGoodname;
        private System.Windows.Forms.TextBox tboxGoodName;
        private System.Windows.Forms.Panel pnlRemoveUser;
        private System.Windows.Forms.Label lblDelUserId;
        private System.Windows.Forms.TextBox tboxDelUserId;
        private System.Windows.Forms.Button btnRemUser;
        private System.Windows.Forms.Panel pnlDelAddress;
        private System.Windows.Forms.Button btnDelAddress;
        private System.Windows.Forms.TextBox tboxDelAddress;
        private System.Windows.Forms.Label lblDelAddress;
        private System.Windows.Forms.Panel pnlDelOrder;
        private System.Windows.Forms.TextBox tboxDelOrder;
        private System.Windows.Forms.Label lblDelOrder;
        private System.Windows.Forms.Button btnDelOrder;
    }
}

