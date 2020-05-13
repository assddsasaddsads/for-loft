namespace loft
{
    partial class FormAuthorization
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(45, 50);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(196, 20);
            this.textBoxLogin.TabIndex = 13;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(45, 89);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(196, 20);
            this.textBoxPassword.TabIndex = 14;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(42, 35);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 15;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(42, 73);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Пароль";
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(146, 115);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(95, 25);
            this.buttonEdit.TabIndex = 35;
            this.buttonEdit.Text = "Отмена";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Location = new System.Drawing.Point(45, 115);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(95, 25);
            this.buttonOk.TabIndex = 34;
            this.buttonOk.Text = "Войти";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Войдите под своей учетной записью";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::loft.Properties.Resources.Без_имени_21;
            this.pictureBox1.Location = new System.Drawing.Point(12, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 342);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "FormAuthorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormAuthorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}