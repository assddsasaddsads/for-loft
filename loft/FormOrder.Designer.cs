namespace loft
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxNameClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNameProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNameEmployee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxNameClient
            // 
            this.comboBoxNameClient.FormattingEnabled = true;
            this.comboBoxNameClient.Location = new System.Drawing.Point(11, 34);
            this.comboBoxNameClient.Name = "comboBoxNameClient";
            this.comboBoxNameClient.Size = new System.Drawing.Size(145, 21);
            this.comboBoxNameClient.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Клиент";
            // 
            // comboBoxNameProduct
            // 
            this.comboBoxNameProduct.FormattingEnabled = true;
            this.comboBoxNameProduct.Location = new System.Drawing.Point(162, 75);
            this.comboBoxNameProduct.Name = "comboBoxNameProduct";
            this.comboBoxNameProduct.Size = new System.Drawing.Size(145, 21);
            this.comboBoxNameProduct.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Товар";
            // 
            // comboBoxNameEmployee
            // 
            this.comboBoxNameEmployee.FormattingEnabled = true;
            this.comboBoxNameEmployee.Location = new System.Drawing.Point(162, 34);
            this.comboBoxNameEmployee.Name = "comboBoxNameEmployee";
            this.comboBoxNameEmployee.Size = new System.Drawing.Size(145, 21);
            this.comboBoxNameEmployee.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Персонал";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(11, 59);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 39;
            this.labelDate.Text = "Дата";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(11, 75);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(145, 20);
            this.textBoxDate.TabIndex = 38;
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewEmployee.FullRowSelect = true;
            this.listViewEmployee.GridLines = true;
            this.listViewEmployee.HideSelection = false;
            this.listViewEmployee.Location = new System.Drawing.Point(12, 144);
            this.listViewEmployee.MultiSelect = false;
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.Size = new System.Drawing.Size(602, 170);
            this.listViewEmployee.TabIndex = 40;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
            this.listViewEmployee.SelectedIndexChanged += new System.EventHandler(this.listViewEmployee_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ФИО Клиента";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО Сотрудника";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Наименование товара";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата оформления";
            // 
            // buttonDel
            // 
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Location = new System.Drawing.Point(530, 318);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(84, 36);
            this.buttonDel.TabIndex = 43;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(440, 318);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 36);
            this.buttonEdit.TabIndex = 42;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(350, 318);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(84, 36);
            this.buttonAdd.TabIndex = 41;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::loft.Properties.Resources.Без_имени_21;
            this.pictureBox1.Location = new System.Drawing.Point(350, -80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 218);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewEmployee);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.comboBoxNameEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxNameProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxNameClient);
            this.Controls.Add(this.label1);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNameClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNameProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNameEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}