using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {

        public DBConnect dbc;

        public Form1()
        {
            InitializeComponent();
            
        }

        void SwitchComponents()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            textBoxDB.Visible = false;
            tbTable.Visible = false;
            textBoxUID.Visible = false;
            textBoxPassword.Visible = false;

            buttonConnect.Visible = false;

            lName.Visible = true;
            lAge.Visible = true;
            bInsert.Visible = true;
            bDelete.Visible = true;
            bSelect.Visible = true;
            tbAge.Visible = true;
            cbDelete.Visible = true;
        }

        #region TextBoxes Check 

        void ClearBoxes()
        {
            textBoxServer.Clear();
            textBoxDB.Clear();
            textBoxUID.Clear();
            textBoxPassword.Clear();
            tbAge.Clear();
        }

        private void textBoxServer_TextChanged(object sender, EventArgs e)
        {
            if (textBoxServer.TextLength > 0 && tbTable.TextLength > 0 && textBoxDB.TextLength > 0 && textBoxUID.TextLength > 0 && textBoxPassword.TextLength > 0)
                buttonConnect.Enabled = true;
            else
                buttonConnect.Enabled = false;
            if (textBoxServer.TextLength > 0)
                bInsert.Enabled = true;
            else
                bInsert.Enabled = false;
        }

        private void textBoxDB_TextChanged(object sender, EventArgs e)
        {
            if (textBoxServer.TextLength > 0 && tbTable.TextLength > 0 && textBoxDB.TextLength > 0 && textBoxUID.TextLength > 0 && textBoxPassword.TextLength > 0)
                buttonConnect.Enabled = true;
            else
                buttonConnect.Enabled = false;
        }

        private void textBoxUID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxServer.TextLength > 0 && tbTable.TextLength > 0 && textBoxDB.TextLength > 0 && textBoxUID.TextLength > 0 && textBoxPassword.TextLength > 0)
                buttonConnect.Enabled = true;
            else
                buttonConnect.Enabled = false;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxServer.TextLength > 0 && tbTable.TextLength > 0 && textBoxDB.TextLength > 0 && textBoxUID.TextLength > 0 && textBoxPassword.TextLength > 0)
                buttonConnect.Enabled = true;
            else
                buttonConnect.Enabled = false;
        }

        private void tbTable_TextChanged(object sender, EventArgs e)
        {
            if (textBoxServer.TextLength > 0 && tbTable.TextLength > 0 && textBoxDB.TextLength > 0 && textBoxUID.TextLength > 0 && textBoxPassword.TextLength > 0)
                buttonConnect.Enabled = true;
            else
                buttonConnect.Enabled = false;
        }


        #endregion


        private void buttonConnect_Click(object sender, EventArgs e)
        {
            
                dbc = new DBConnect(textBoxServer.Text, textBoxDB.Text, textBoxUID.Text, textBoxPassword.Text, tbTable.Text);
                if (dbc.OpenConnection())
                {
                    this.Width = 367;
                    SwitchComponents();
                }

            ClearBoxes();
        }

        #region Keys Down
        private void textBoxServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(dbc.sqlConnect.State == ConnectionState.Closed)
                {
                    dbc = new DBConnect(textBoxServer.Text, textBoxDB.Text, textBoxUID.Text, textBoxPassword.Text, tbTable.Text);
                    if (dbc.OpenConnection())
                    {
                        this.Width = 367;
                        SwitchComponents();
                    }
                }
                else if (dbc.sqlConnect.State == ConnectionState.Open)
                {
                    if (tbAge.TextLength > 0)
                        dbc.Insert(textBoxServer.Text, Int32.Parse(tbAge.Text));
                    else
                        dbc.Insert(textBoxServer.Text, 0);
                }


                ClearBoxes();
            }
                
        }

        private void textBoxDB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbc = new DBConnect(textBoxServer.Text, textBoxDB.Text, textBoxUID.Text, textBoxPassword.Text, tbTable.Text);
                if (dbc.OpenConnection())
                {
                    this.Width = 367;
                    SwitchComponents();
                }

                ClearBoxes();
            }

        }

        private void textBoxUID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbc = new DBConnect(textBoxServer.Text, textBoxDB.Text, textBoxUID.Text, textBoxPassword.Text, tbTable.Text);
                if (dbc.OpenConnection())
                {
                    this.Width = 367;
                    SwitchComponents();
                }

                ClearBoxes();
            }

        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbc = new DBConnect(textBoxServer.Text, textBoxDB.Text, textBoxUID.Text, textBoxPassword.Text, tbTable.Text);
                if (dbc.OpenConnection())
                {
                    this.Width = 367;
                    SwitchComponents();
                }

                ClearBoxes();
            }

        }

        private void tbAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbAge.TextLength > 0)
                    dbc.Insert(textBoxServer.Text, Int32.Parse(tbAge.Text));
                else
                    dbc.Insert(textBoxServer.Text, 0);

                ClearBoxes();
            }
        }
        #endregion

        private void RefreshcbDelete()
        {
            List<String>[] lists = new List<string>[3];

            lists = dbc.Select();

            cbDelete.Items.Clear();
            for (int i = 0; i < lists[1].Count; i++)
            {
                cbDelete.Items.Add(lists[1][i]);
            }
            bDelete.Enabled = false;
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            if (tbAge.TextLength > 0)
                dbc.Insert(textBoxServer.Text, Int32.Parse(tbAge.Text));
            else
                dbc.Insert(textBoxServer.Text, 0);
            ClearBoxes();
            RefreshcbDelete();
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            RefreshcbDelete();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            dbc.Delete(cbDelete.SelectedItem.ToString());
            RefreshcbDelete();
        }

        private void cbDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDelete.SelectedItem.ToString().Length > 0)
                bDelete.Enabled = true;
            else
                bDelete.Enabled = false;
        }

        
    }
}
