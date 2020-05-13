namespace loft
{
    partial class FormStockRoom
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
            this.listViewStockRoom = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxNameProduct = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNameProvider = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewStockRoom
            // 
            this.listViewStockRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewStockRoom.FullRowSelect = true;
            this.listViewStockRoom.GridLines = true;
            this.listViewStockRoom.HideSelection = false;
            this.listViewStockRoom.Location = new System.Drawing.Point(12, 135);
            this.listViewStockRoom.MultiSelect = false;
            this.listViewStockRoom.Name = "listViewStockRoom";
            this.listViewStockRoom.Size = new System.Drawing.Size(592, 171);
            this.listViewStockRoom.TabIndex = 24;
            this.listViewStockRoom.UseCompatibleStateImageBehavior = false;
            this.listViewStockRoom.View = System.Windows.Forms.View.Details;
            this.listViewStockRoom.SelectedIndexChanged += new System.EventHandler(this.listViewStockRoom_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Цвет товара";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Наименование товара";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Количество товара";
            // 
            // comboBoxNameProduct
            // 
            this.comboBoxNameProduct.FormattingEnabled = true;
            this.comboBoxNameProduct.Location = new System.Drawing.Point(10, 58);
            this.comboBoxNameProduct.Name = "comboBoxNameProduct";
            this.comboBoxNameProduct.Size = new System.Drawing.Size(145, 21);
            this.comboBoxNameProduct.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Продукт";
            // 
            // comboBoxNameProvider
            // 
            this.comboBoxNameProvider.FormattingEnabled = true;
            this.comboBoxNameProvider.Location = new System.Drawing.Point(161, 58);
            this.comboBoxNameProvider.Name = "comboBoxNameProvider";
            this.comboBoxNameProvider.Size = new System.Drawing.Size(145, 21);
            this.comboBoxNameProvider.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Поставщик";
            // 
            // buttonDel
            // 
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Location = new System.Drawing.Point(520, 312);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(84, 36);
            this.buttonDel.TabIndex = 34;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(430, 312);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 36);
            this.buttonEdit.TabIndex = 33;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(340, 312);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(84, 36);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::loft.Properties.Resources.Без_имени_21;
            this.pictureBox1.Location = new System.Drawing.Point(331, -89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 218);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // FormStockRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxNameProvider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNameProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewStockRoom);
            this.Name = "FormStockRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад товаров";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStockRoom;
        private System.Windows.Forms.ComboBox comboBoxNameProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNameProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}