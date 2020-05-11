﻿namespace loft
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenEmployee = new System.Windows.Forms.Button();
            this.buttonOpenManager = new System.Windows.Forms.Button();
            this.buttonOpenProvider = new System.Windows.Forms.Button();
            this.buttonOpenProducts = new System.Windows.Forms.Button();
            this.buttonOpenOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenClients.Location = new System.Drawing.Point(12, 144);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenClients.TabIndex = 0;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenEmployee
            // 
            this.buttonOpenEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenEmployee.Location = new System.Drawing.Point(12, 198);
            this.buttonOpenEmployee.Name = "buttonOpenEmployee";
            this.buttonOpenEmployee.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenEmployee.TabIndex = 1;
            this.buttonOpenEmployee.Text = "Персонал";
            this.buttonOpenEmployee.UseVisualStyleBackColor = false;
            // 
            // buttonOpenManager
            // 
            this.buttonOpenManager.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenManager.Location = new System.Drawing.Point(12, 252);
            this.buttonOpenManager.Name = "buttonOpenManager";
            this.buttonOpenManager.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenManager.TabIndex = 2;
            this.buttonOpenManager.Text = "Менеджеры по закупкам";
            this.buttonOpenManager.UseVisualStyleBackColor = false;
            // 
            // buttonOpenProvider
            // 
            this.buttonOpenProvider.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenProvider.Location = new System.Drawing.Point(12, 306);
            this.buttonOpenProvider.Name = "buttonOpenProvider";
            this.buttonOpenProvider.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenProvider.TabIndex = 3;
            this.buttonOpenProvider.Text = "Поставщики";
            this.buttonOpenProvider.UseVisualStyleBackColor = false;
            // 
            // buttonOpenProducts
            // 
            this.buttonOpenProducts.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenProducts.Location = new System.Drawing.Point(12, 360);
            this.buttonOpenProducts.Name = "buttonOpenProducts";
            this.buttonOpenProducts.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenProducts.TabIndex = 4;
            this.buttonOpenProducts.Text = "Товары";
            this.buttonOpenProducts.UseVisualStyleBackColor = false;
            // 
            // buttonOpenOrder
            // 
            this.buttonOpenOrder.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenOrder.Location = new System.Drawing.Point(12, 414);
            this.buttonOpenOrder.Name = "buttonOpenOrder";
            this.buttonOpenOrder.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenOrder.TabIndex = 5;
            this.buttonOpenOrder.Text = "Заказы";
            this.buttonOpenOrder.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::loft.Properties.Resources.Без_имени_2;
            this.pictureBox1.Location = new System.Drawing.Point(-8, -84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 222);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOpenOrder);
            this.Controls.Add(this.buttonOpenProducts);
            this.Controls.Add(this.buttonOpenProvider);
            this.Controls.Add(this.buttonOpenManager);
            this.Controls.Add(this.buttonOpenEmployee);
            this.Controls.Add(this.buttonOpenClients);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenEmployee;
        private System.Windows.Forms.Button buttonOpenManager;
        private System.Windows.Forms.Button buttonOpenProvider;
        private System.Windows.Forms.Button buttonOpenProducts;
        private System.Windows.Forms.Button buttonOpenOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

