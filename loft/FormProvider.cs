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
    public partial class FormProvider : Form
    {
        public FormProvider()
        {
            InitializeComponent();
            Showprovider();
            ShowProduct();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProviderSet providerSet = new ProviderSet();
            providerSet.IdProduct = Convert.ToInt32(comboBoxNameProduct.SelectedItem.ToString().Split('.')[0]);
            providerSet.NameProduct = comboBoxNameProduct.Text;
            providerSet.Company = textBoxCompany.Text;
            providerSet.Phone = textBoxPhone.Text;
            providerSet.Email = textBoxEmail.Text;
            Program.wFShop.ProviderSet.Add(providerSet);
            Program.wFShop.SaveChanges();
            Showprovider();
        }
        void Showprovider()
        {
            listViewProvider.Items.Clear();
            foreach(ProviderSet providerSet in Program.wFShop.ProviderSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    providerSet.Company, providerSet.Phone, providerSet.Email,
                    providerSet.IdProduct.ToString(), providerSet.NameProduct
                });
                item.Tag = providerSet;
                listViewProvider.Items.Add(item);
            }
            listViewProvider.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewProvider.SelectedItems.Count==1)
            {
                ProviderSet providerSet = listViewProvider.SelectedItems[0].Tag as ProviderSet;
                comboBoxNameProduct.Text = providerSet.NameProduct;
                textBoxCompany.Text = providerSet.Company;
                textBoxPhone.Text = providerSet.Phone;
                textBoxEmail.Text = providerSet.Email;
                

            }
            else
            {
                comboBoxNameProduct.Text = "";
                textBoxCompany.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }
        void ShowProduct()
        {
            comboBoxNameProduct.Items.Clear();
            foreach (ProductSet productSet in Program.wFShop.ProductSet)
            {
                string[] item = { productSet.Id.ToString() + ".", productSet.NameProduct };
                comboBoxNameProduct.Items.Add(string.Join(" ", item));
                
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewProvider.SelectedItems.Count ==1)
            {
                ProviderSet providerSet = listViewProvider.SelectedItems[0].Tag as ProviderSet;
                providerSet.IdProduct = Convert.ToInt32(comboBoxNameProduct.SelectedItem.ToString().Split('.')[0]);
                providerSet.NameProduct = comboBoxNameProduct.Text;
                providerSet.Company = textBoxCompany.Text;
                providerSet.Phone = textBoxPhone.Text;
                providerSet.Email = textBoxEmail.Text;
                Program.wFShop.SaveChanges();
                Showprovider();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if(listViewProvider.SelectedItems.Count ==1)
                {
                    ProviderSet providerSet = listViewProvider.SelectedItems[0].Tag as ProviderSet;
                    Program.wFShop.ProviderSet.Remove(providerSet);
                    Program.wFShop.SaveChanges();
                    Showprovider();
                }
                comboBoxNameProduct.Text = "";
                textBoxCompany.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxNameProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
