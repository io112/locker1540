﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testapp.UsersPage
{
    public interface IUsersForm
    {
        string name { set; }
        string surname { set; }
        string secName { set; }
        string pos { set; }
        string num { set; }
        event EventHandler addUser;
        event EventHandler changeUser;
    }
    public partial class UsersForm : Form, IUsersForm
    {
        private IAddUser UserOk;
        private addUserForm addUserForm1;
        public UsersForm()
        {
            InitializeComponent();
            AddUserBtn.Click += AddUserBtn_Click;
            ChangeBtn.Click += ChangeBtn_Click;
            listView1.ColumnClick += ListView1_ColumnClick;
        }
        private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            throw new NotImplementedException();
        }
        #region allneed
        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            addUserForm1 = new addUserForm();
            string name = listView1.SelectedItems[0].SubItems[0].Text;
            string surname = listView1.SelectedItems[0].SubItems[1].Text;
            string SecName = listView1.SelectedItems[0].SubItems[2].Text;
            string pos = listView1.SelectedItems[0].SubItems[3].Text;
            addUserForm1.init(name,surname,SecName,pos);
            addUserForm1.OK += AddUserForm1_OK1;
            addUserForm1.Show();
            listView1.SelectedItems[0].Remove();
            UserOk = addUserForm1;
        }
        
        private void AddUserForm1_OK(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(UserOk.name);
            lvi.SubItems.Add(UserOk.surname);
            lvi.SubItems.Add(UserOk.secName);
            lvi.SubItems.Add(UserOk.pos);
            lvi.SubItems.Add(UserOk.num);
            addUserForm1.Close();
            listView1.Items.Add(lvi);
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            addUserForm1 = new addUserForm();
            /*string name = listView1.SelectedItems[0].SubItems[0].Text;
            string surname = listView1.SelectedItems[0].SubItems[1].Text;
            string SecName = listView1.SelectedItems[0].SubItems[2].Text;
            string pos = listView1.SelectedItems[0].SubItems[3].Text;
            addUserForm1.init(name, surname, SecName, pos);*/
            UserOk = addUserForm1;
            addUserForm1.OK += AddUserForm1_OK;
            addUserForm1.Show();
            
        }

        private void AddUserForm1_OK1(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(UserOk.name);
            lvi.SubItems.Add(UserOk.surname);
            lvi.SubItems.Add(UserOk.secName);
            lvi.SubItems.Add(UserOk.pos);
            lvi.SubItems.Add(UserOk.num);
            listView1.Items.Add(lvi);
            addUserForm1.Close();

        }

        public string name
        {
            set { NameT.Text = value; }
        }
        public string surname
        {
            set { SurnT.Text = value; }
        }
        public string secName
        {
            set { SecNameT.Text = value; }
        }
        public string pos
        {
            set { PosT.Text = value; }
        }
        public string num
        {
            set { NumT.Text = value; }
        }
        public event EventHandler addUser;
        public event EventHandler changeUser;
        #endregion
        #region notNeed
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
#endregion
}
