namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDB = new System.Windows.Forms.TextBox();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lAge = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.cbDelete = new System.Windows.Forms.ComboBox();
            this.bSelect = new System.Windows.Forms.Button();
            this.tbTable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(70, 37);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(100, 20);
            this.textBoxServer.TabIndex = 0;
            this.textBoxServer.TextChanged += new System.EventHandler(this.textBoxServer_TextChanged);
            this.textBoxServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxServer_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DataBase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // textBoxDB
            // 
            this.textBoxDB.Location = new System.Drawing.Point(70, 63);
            this.textBoxDB.Name = "textBoxDB";
            this.textBoxDB.Size = new System.Drawing.Size(100, 20);
            this.textBoxDB.TabIndex = 5;
            this.textBoxDB.TextChanged += new System.EventHandler(this.textBoxDB_TextChanged);
            this.textBoxDB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDB_KeyDown);
            // 
            // textBoxUID
            // 
            this.textBoxUID.Location = new System.Drawing.Point(70, 116);
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(100, 20);
            this.textBoxUID.TabIndex = 6;
            this.textBoxUID.TextChanged += new System.EventHandler(this.textBoxUID_TextChanged);
            this.textBoxUID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUID_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(70, 143);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Enabled = false;
            this.buttonConnect.Location = new System.Drawing.Point(12, 188);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(158, 36);
            this.buttonConnect.TabIndex = 8;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(266, 37);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(75, 23);
            this.bInsert.TabIndex = 9;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Visible = false;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(177, 37);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(40, 20);
            this.tbAge.TabIndex = 10;
            this.tbAge.Visible = false;
            this.tbAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAge_KeyDown);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(70, 13);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 11;
            this.lName.Text = "Name";
            this.lName.Visible = false;
            // 
            // lAge
            // 
            this.lAge.AutoSize = true;
            this.lAge.Location = new System.Drawing.Point(177, 13);
            this.lAge.Name = "lAge";
            this.lAge.Size = new System.Drawing.Size(26, 13);
            this.lAge.TabIndex = 12;
            this.lAge.Text = "Age";
            this.lAge.Visible = false;
            // 
            // bDelete
            // 
            this.bDelete.Enabled = false;
            this.bDelete.Location = new System.Drawing.Point(266, 67);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 13;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Visible = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // cbDelete
            // 
            this.cbDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelete.FormattingEnabled = true;
            this.cbDelete.Location = new System.Drawing.Point(69, 67);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(121, 21);
            this.cbDelete.TabIndex = 14;
            this.cbDelete.Visible = false;
            this.cbDelete.SelectedIndexChanged += new System.EventHandler(this.cbDelete_SelectedIndexChanged);
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(266, 93);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(75, 23);
            this.bSelect.TabIndex = 15;
            this.bSelect.Text = "Select";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Visible = false;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // tbTable
            // 
            this.tbTable.Location = new System.Drawing.Point(70, 90);
            this.tbTable.Name = "tbTable";
            this.tbTable.Size = new System.Drawing.Size(100, 20);
            this.tbTable.TabIndex = 16;
            this.tbTable.TextChanged += new System.EventHandler(this.tbTable_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Table";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 293);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTable);
            this.Controls.Add(this.bSelect);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.lAge);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUID);
            this.Controls.Add(this.textBoxDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDB;
        private System.Windows.Forms.TextBox textBoxUID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lAge;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.ComboBox cbDelete;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.TextBox tbTable;
        private System.Windows.Forms.Label label5;
    }
}

