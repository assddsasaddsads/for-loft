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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            ShowProduct();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProductSet productSet = new ProductSet();
            productSet.Colour = textBoxColour.Text;
            productSet.Size = textBoxSize.Text;
            productSet.Quantity = textBoxQuantity.Text;
            productSet.Material = textBoxMaterial.Text;
            productSet.Price = Convert.ToInt64(textBoxPrice.Text);
            productSet.NameProduct = textBoxNameProduct.Text;
            
            Program.wFShop.ProductSet.Add(productSet);
            Program.wFShop.SaveChanges();
            ShowProduct();
        }
        void ShowProduct()
        {
            listViewProduct1.Items.Clear();
            foreach (ProductSet productSet in Program.wFShop.ProductSet)
            {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    productSet.Colour, productSet.Size, productSet.Quantity, productSet.Material,
                    productSet.Price.ToString(), productSet.NameProduct
                    });
                    item.Tag = productSet;
                    listViewProduct1.Items.Add(item);
            }
            listViewProduct1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
                if (listViewProduct1.SelectedItems.Count == 1)
                {
                    ProductSet productSet = listViewProduct1.SelectedItems[0].Tag as ProductSet;
                    productSet.Colour = textBoxColour.Text;
                    productSet.Size = textBoxSize.Text;
                    productSet.Quantity = textBoxQuantity.Text;
                    productSet.Material = textBoxMaterial.Text;
                    productSet.Price = Convert.ToInt64(textBoxPrice.Text);
                    productSet.NameProduct = textBoxNameProduct.Text;
                    Program.wFShop.SaveChanges();
                    ShowProduct();
                }
        }

        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProduct1.SelectedItems.Count == 1)
            {
                ProductSet productSet = listViewProduct1.SelectedItems[0].Tag as ProductSet;
                textBoxColour.Text = productSet.Colour;
                textBoxSize.Text = productSet.Size;
                textBoxQuantity.Text = productSet.Quantity;
                textBoxMaterial.Text = productSet.Material;
                textBoxPrice.Text = Convert.ToString(productSet.Price);
                textBoxNameProduct.Text = productSet.NameProduct;
                
            }
            else
            {
                textBoxColour.Text = "";
                textBoxSize.Text = "";
                textBoxQuantity.Text = "";
                textBoxMaterial.Text = "";
                textBoxPrice.Text = "";
                textBoxNameProduct.Text = "";
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                   if (listViewProduct1.SelectedItems.Count == 1)
                   {
                        ProductSet productSet = listViewProduct1.SelectedItems[0].Tag as ProductSet;
                        Program.wFShop.ProductSet.Remove(productSet);
                        Program.wFShop.SaveChanges();
                        ShowProduct();
                   }
                    textBoxColour.Text = "";
                    textBoxSize.Text = "";
                    textBoxQuantity.Text = "";
                    textBoxMaterial.Text = "";
                    textBoxPrice.Text = "";
                    textBoxNameProduct.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

    }
}
