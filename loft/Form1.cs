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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "Client") 
            {
                buttonOpenEmployee.Enabled = false;
                buttonOpenProvider.Enabled = false;
            }
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formclient = new FormClient();
            formclient.Show();
        }

        private void buttonOpenEmployee_Click(object sender, EventArgs e)
        {
            Form formemployee = new FormEmployee();
            formemployee.Show();
        }

        private void buttonOpenProvider_Click(object sender, EventArgs e)
        {
            Form formprovider = new FormProvider();
            formprovider.Show();
        }

        private void buttonOpenProducts_Click(object sender, EventArgs e)
        {
            Form formproduct = new FormProduct();
            formproduct.Show();
        }

        private void buttonOpenStockRoom_Click(object sender, EventArgs e)
        {
            Form formstockroom = new FormStockRoom();
            formstockroom.Show();
        }

        private void buttonOpenOrder_Click(object sender, EventArgs e)
        {
            Form formorder =new FormOrder();
            formorder.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}