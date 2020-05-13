﻿using System;
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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            ShowEmployee();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EmployeeSet employeeSet = new EmployeeSet();
            employeeSet.LastName = textBoxLastName.Text;
            employeeSet.FirstName = textBoxFirstName.Text;
            employeeSet.MiddleName = textBoxMiddleName.Text;
            employeeSet.Address = textBoxAddress.Text;
            employeeSet.Phone = Convert.ToString(textBoxPhone.Text);
            Program.wFShop.EmployeeSet.Add(employeeSet);
            Program.wFShop.SaveChanges();
            ShowEmployee();
        }
        void ShowEmployee()
        {
            listViewEmployee.Items.Clear();
            foreach(EmployeeSet employeeSet in Program.wFShop.EmployeeSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    employeeSet.Id.ToString(), employeeSet.LastName, employeeSet.FirstName, employeeSet.MiddleName,
                    employeeSet.Address, employeeSet.Phone, 
                });
                item.Tag = employeeSet;
                listViewEmployee.Items.Add(item);
            }
            listViewEmployee.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmployee.SelectedItems.Count == 1)
            {
                EmployeeSet employeeSet = listViewEmployee.SelectedItems[0].Tag as EmployeeSet;
                textBoxLastName.Text = employeeSet.LastName;
                textBoxFirstName.Text = employeeSet.FirstName;
                textBoxMiddleName.Text = employeeSet.MiddleName;
                textBoxAddress.Text = employeeSet.Address;
                textBoxPhone.Text = employeeSet.Phone;
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listViewEmployee.SelectedItems.Count ==1)
            {
                EmployeeSet employeeSet = listViewEmployee.SelectedItems[0].Tag as EmployeeSet;
                employeeSet.LastName = textBoxLastName.Text;
                employeeSet.FirstName = textBoxFirstName.Text;
                employeeSet.MiddleName = textBoxMiddleName.Text;
                employeeSet.Address = textBoxAddress.Text;
                employeeSet.Phone = textBoxPhone.Text;
                Program.wFShop.SaveChanges();
                ShowEmployee();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewEmployee.SelectedItems.Count ==1)
                {
                    EmployeeSet employeeSet = listViewEmployee.SelectedItems[0].Tag as EmployeeSet;
                    Program.wFShop.EmployeeSet.Remove(employeeSet);
                    Program.wFShop.SaveChanges();
                    ShowEmployee();
                }
                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxAddress.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
