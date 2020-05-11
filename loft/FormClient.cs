using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loft
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientSet clientSet = new ClientSet();
            clientSet.LastName = textBoxLastName.Text;
            clientSet.FirstName = textBoxFirstName.Text;
            clientSet.MiddleName = textBoxMiddleName.Text;
            clientSet.Address = textBoxAddress.Text;
            clientSet.Phone = Convert.ToString(textBoxPhone.Text);
            Program.wFShop.ClientSet.Add(clientSet);
            Program.wFShop.SaveChanges();
            ShowClient();
        }
        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach(ClientSet clientSet in Program.wFShop.ClientSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientSet.Id.ToString(), clientSet.LastName, clientSet.FirstName, clientSet.MiddleName,
                    clientSet.Address, clientSet.Phone
                });
                item.Tag = clientSet;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listViewClient.SelectedItems.Count ==1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.Address = textBoxAddress.Text;
                clientSet.Phone = textBoxPhone.Text;
                Program.wFShop.SaveChanges();
                ShowClient();
            }
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count ==1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                textBoxLastName.Text = clientSet.LastName;
                textBoxFirstName.Text = clientSet.FirstName;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxAddress.Text = clientSet.Address;
                textBoxPhone.Text = clientSet.Phone;
            }
            else
            {
                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxAddress.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count ==1)
                {
                    ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                    Program.wFShop.ClientSet.Remove(clientSet);
                    Program.wFShop.SaveChanges();
                    ShowClient();
                }
                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxAddress.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
