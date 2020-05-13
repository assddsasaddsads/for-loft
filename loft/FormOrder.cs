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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
            ShowClietn();
            ShowProduct();
            ShowEmployee();
            ShowOrders();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OrderSet orderSet = new OrderSet();
            orderSet.IdProduct = Convert.ToInt32(comboBoxNameProduct.SelectedItem.ToString().Split('.')[0]);
            orderSet.IdEmployee = Convert.ToInt32(comboBoxNameEmployee.SelectedItem.ToString().Split('.')[0]);
            orderSet.IdClient = Convert.ToInt32(comboBoxNameClient.SelectedItem.ToString().Split('.')[0]);
            orderSet.Date = textBoxDate.Text;
            Program.wFShop.OrderSet.Add(orderSet);
            Program.wFShop.SaveChanges();
            ShowOrders();
        }
        void ShowClietn()
        {
            comboBoxNameClient.Items.Clear();
            foreach (ClientSet clientSet in Program.wFShop.ClientSet)
            {
                string[] item = { clientSet.Id.ToString() + ".", clientSet.LastName, clientSet.FirstName, clientSet.MiddleName, clientSet.Phone };
                comboBoxNameClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowProduct()
        {
            comboBoxNameProduct.Items.Clear();
            foreach (ProductSet productSet in Program.wFShop.ProductSet)
            {
                string[] item = { productSet.Id.ToString() + ".", productSet.NameProduct, productSet.Colour, productSet.Material, productSet.Price.ToString() };
                comboBoxNameProduct.Items.Add(string.Join(" ", item));
            }
        }
        void ShowEmployee()
        {
            comboBoxNameEmployee.Items.Clear();
            foreach (EmployeeSet employeeSet in Program.wFShop.EmployeeSet)
            {
                string[] item = { employeeSet.Id.ToString() + ".", employeeSet.LastName, employeeSet.FirstName, employeeSet.MiddleName, employeeSet.Phone };
                comboBoxNameEmployee.Items.Add(string.Join(" ", item));
            }
        }
        void ShowOrders()
        {
            listViewEmployee.Items.Clear();
            foreach (OrderSet orderSet in Program.wFShop.OrderSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    orderSet.ClientSet.LastName+" "+orderSet.ClientSet.FirstName+" "+orderSet.ClientSet.MiddleName,
                    orderSet.EmployeeSet.LastName+" "+orderSet.EmployeeSet.FirstName+" "+orderSet.EmployeeSet.MiddleName,
                    orderSet.ProductSet.NameProduct,
                    orderSet.Date
                });
                item.Tag = orderSet;
                listViewEmployee.Items.Add(item);
            }
            listViewEmployee.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (listViewEmployee.SelectedItems.Count == 1)
                {
                    OrderSet orderSet = listViewEmployee.SelectedItems[0].Tag as OrderSet;

                    comboBoxNameClient.SelectedIndex = comboBoxNameClient.FindString(orderSet.IdClient.ToString());
                    comboBoxNameEmployee.SelectedIndex = comboBoxNameEmployee.FindString(orderSet.IdEmployee.ToString());
                    comboBoxNameProduct.SelectedIndex = comboBoxNameProduct.FindString(orderSet.IdProduct.ToString());
                    textBoxDate.Text = orderSet.Date;
                }
                else
                {
                    comboBoxNameClient.SelectedItem = null;
                    comboBoxNameEmployee.SelectedItem = null;
                    comboBoxNameProduct.SelectedItem = null;
                    textBoxDate.Text = "";
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewEmployee.SelectedItems.Count == 1)
            {
                OrderSet orderSet = listViewEmployee.SelectedItems[0].Tag as OrderSet;
                orderSet.IdProduct = Convert.ToInt32(comboBoxNameProduct.SelectedItem.ToString().Split('.')[0]);
                orderSet.IdEmployee = Convert.ToInt32(comboBoxNameEmployee.SelectedItem.ToString().Split('.')[0]);
                orderSet.IdClient = Convert.ToInt32(comboBoxNameClient.SelectedItem.ToString().Split('.')[0]);
                orderSet.Date = textBoxDate.Text;
                Program.wFShop.SaveChanges();
                ShowOrders();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewEmployee.SelectedItems.Count == 1)
                {
                    OrderSet orderSet = listViewEmployee.SelectedItems[0].Tag as OrderSet;
                    Program.wFShop.OrderSet.Remove(orderSet);
                    Program.wFShop.SaveChanges();
                    ShowOrders();
                }
                comboBoxNameProduct.SelectedItem = null;
                comboBoxNameClient.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}