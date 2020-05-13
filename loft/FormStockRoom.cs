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
    public partial class FormStockRoom : Form
    {
        public FormStockRoom()
        {
            InitializeComponent();
            ShowProduct();
            ShowStockRoom();
            ShowProvider();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StockroomSet stockroomSet = new StockroomSet();
            stockroomSet.IdProduct = Convert.ToInt32(comboBoxNameProduct.SelectedItem.ToString().Split('.')[0]);
            stockroomSet.IdProvider = Convert.ToInt32(comboBoxNameProvider.SelectedItem.ToString().Split('.')[0]);
            Program.wFShop.StockroomSet.Add(stockroomSet);
            Program.wFShop.SaveChanges();
            ShowStockRoom();
        }
        void ShowProduct()
        {
            comboBoxNameProduct.Items.Clear();
            foreach(ProductSet productSet in Program.wFShop.ProductSet)
            {
                string[] item = { productSet.Id.ToString() + ".", productSet.NameProduct };
                comboBoxNameProduct.Items.Add(string.Join(" ", item));
            }
        }
        void ShowProvider()
        {
            comboBoxNameProvider.Items.Clear();
            foreach(ProviderSet providerSet in Program.wFShop.ProviderSet)
            {
                string[] item = { providerSet.Id.ToString() + ".", providerSet.Company };
                comboBoxNameProvider.Items.Add(string.Join(" ", item));
            }
        }
        void ShowStockRoom()
        {
            listViewStockRoom.Items.Clear();
            foreach(StockroomSet stockroomSet in Program.wFShop.StockroomSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    stockroomSet.ProductSet.NameProduct, stockroomSet.ProviderSet.Company,stockroomSet.ProductSet.Quantity
                });
                item.Tag = stockroomSet;
                listViewStockRoom.Items.Add(item);
            }
            listViewStockRoom.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewStockRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStockRoom.SelectedItems.Count == 1)
            {
                StockroomSet stockroomSet = listViewStockRoom.SelectedItems[0].Tag as StockroomSet;
                comboBoxNameProduct.SelectedIndex = comboBoxNameProduct.FindString(stockroomSet.IdProduct.ToString());
                comboBoxNameProvider.SelectedIndex = comboBoxNameProvider.FindString(stockroomSet.IdProvider.ToString());

            }
            else
            {
                comboBoxNameProduct = null;
                comboBoxNameProvider = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStockRoom.SelectedItems.Count ==1)
            {
                StockroomSet stockroomSet = listViewStockRoom.SelectedItems[0].Tag as StockroomSet;
                stockroomSet.IdProduct = Convert.ToInt32(comboBoxNameProduct.SelectedItem.ToString().Split('.')[0]);
                stockroomSet.IdProvider = Convert.ToInt32(comboBoxNameProvider.SelectedItem.ToString().Split('.')[0]);
            }
            Program.wFShop.SaveChanges();
            ShowStockRoom();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStockRoom.SelectedItems.Count == 1)
                {
                    StockroomSet stockroomSet = listViewStockRoom.SelectedItems[0].Tag as StockroomSet;
                    Program.wFShop.StockroomSet.Remove(stockroomSet);
                    Program.wFShop.SaveChanges();
                    ShowStockRoom();
                }
                comboBoxNameProduct.SelectedItem = null;
                comboBoxNameProvider.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
