namespace loft
{
    partial class FormProduct
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
            this.textBoxColour = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelColour = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.listViewProduct1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNameProduct = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxColour
            // 
            this.textBoxColour.Location = new System.Drawing.Point(12, 34);
            this.textBoxColour.Name = "textBoxColour";
            this.textBoxColour.Size = new System.Drawing.Size(145, 20);
            this.textBoxColour.TabIndex = 11;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(163, 34);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(145, 20);
            this.textBoxSize.TabIndex = 12;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(314, 34);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(145, 20);
            this.textBoxQuantity.TabIndex = 13;
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(163, 84);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(145, 20);
            this.textBoxMaterial.TabIndex = 14;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 84);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(145, 20);
            this.textBoxPrice.TabIndex = 15;
            // 
            // labelColour
            // 
            this.labelColour.AutoSize = true;
            this.labelColour.Location = new System.Drawing.Point(9, 18);
            this.labelColour.Name = "labelColour";
            this.labelColour.Size = new System.Drawing.Size(32, 13);
            this.labelColour.TabIndex = 17;
            this.labelColour.Text = "Цвет";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(160, 18);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(46, 13);
            this.labelSize.TabIndex = 18;
            this.labelSize.Text = "Размер";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(311, 18);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(66, 13);
            this.labelQuantity.TabIndex = 19;
            this.labelQuantity.Text = "Количество";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(160, 68);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(57, 13);
            this.labelMaterial.TabIndex = 20;
            this.labelMaterial.Text = "Материал";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(9, 68);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 21;
            this.labelPrice.Text = "Цена";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(311, 67);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(95, 13);
            this.labelType.TabIndex = 22;
            this.labelType.Text = "Название товара";
            // 
            // listViewProduct1
            // 
            this.listViewProduct1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewProduct1.FullRowSelect = true;
            this.listViewProduct1.GridLines = true;
            this.listViewProduct1.HideSelection = false;
            this.listViewProduct1.Location = new System.Drawing.Point(14, 135);
            this.listViewProduct1.MultiSelect = false;
            this.listViewProduct1.Name = "listViewProduct1";
            this.listViewProduct1.Size = new System.Drawing.Size(734, 171);
            this.listViewProduct1.TabIndex = 23;
            this.listViewProduct1.UseCompatibleStateImageBehavior = false;
            this.listViewProduct1.View = System.Windows.Forms.View.Details;
            this.listViewProduct1.SelectedIndexChanged += new System.EventHandler(this.listViewProduct_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Цвет";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Размер";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Количество";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Материал";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Цена";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Название товара";
            // 
            // buttonDel
            // 
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Location = new System.Drawing.Point(664, 312);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(84, 36);
            this.buttonDel.TabIndex = 26;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(574, 312);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 36);
            this.buttonEdit.TabIndex = 25;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(484, 312);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(84, 36);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNameProduct
            // 
            this.textBoxNameProduct.Location = new System.Drawing.Point(314, 84);
            this.textBoxNameProduct.Name = "textBoxNameProduct";
            this.textBoxNameProduct.Size = new System.Drawing.Size(145, 20);
            this.textBoxNameProduct.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::loft.Properties.Resources.Без_имени_21;
            this.pictureBox2.Location = new System.Drawing.Point(484, -89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 218);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 368);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxNameProduct);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewProduct1);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelColour);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxColour);
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxColour;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelColour;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ListView listViewProduct1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBoxNameProduct;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}