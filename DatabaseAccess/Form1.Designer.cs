namespace DatabaseAccess
{
    partial class ContactList
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.m_sVornameTxtbx = new System.Windows.Forms.TextBox();
            this.m_sNameTxtbx = new System.Windows.Forms.TextBox();
            this.m_nHausnummerTxtbx = new System.Windows.Forms.TextBox();
            this.m_sOrtTxtbx = new System.Windows.Forms.TextBox();
            this.m_sStrasseTxtbx = new System.Windows.Forms.TextBox();
            this.m_nPostleitzahlTxtbx = new System.Windows.Forms.TextBox();
            this._SubmitBtn = new System.Windows.Forms.Button();
            this._deleteBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_sVornameTxtbx
            // 
            this.m_sVornameTxtbx.Location = new System.Drawing.Point(67, 38);
            this.m_sVornameTxtbx.Name = "m_sVornameTxtbx";
            this.m_sVornameTxtbx.Size = new System.Drawing.Size(121, 20);
            this.m_sVornameTxtbx.TabIndex = 1;
            // 
            // m_sNameTxtbx
            // 
            this.m_sNameTxtbx.Location = new System.Drawing.Point(67, 12);
            this.m_sNameTxtbx.Name = "m_sNameTxtbx";
            this.m_sNameTxtbx.Size = new System.Drawing.Size(121, 20);
            this.m_sNameTxtbx.TabIndex = 0;
            // 
            // m_nHausnummerTxtbx
            // 
            this.m_nHausnummerTxtbx.Location = new System.Drawing.Point(273, 17);
            this.m_nHausnummerTxtbx.Name = "m_nHausnummerTxtbx";
            this.m_nHausnummerTxtbx.Size = new System.Drawing.Size(47, 20);
            this.m_nHausnummerTxtbx.TabIndex = 3;
            // 
            // m_sOrtTxtbx
            // 
            this.m_sOrtTxtbx.Location = new System.Drawing.Point(184, 43);
            this.m_sOrtTxtbx.Name = "m_sOrtTxtbx";
            this.m_sOrtTxtbx.Size = new System.Drawing.Size(136, 20);
            this.m_sOrtTxtbx.TabIndex = 5;
            // 
            // m_sStrasseTxtbx
            // 
            this.m_sStrasseTxtbx.Location = new System.Drawing.Point(119, 17);
            this.m_sStrasseTxtbx.Name = "m_sStrasseTxtbx";
            this.m_sStrasseTxtbx.Size = new System.Drawing.Size(148, 20);
            this.m_sStrasseTxtbx.TabIndex = 2;
            // 
            // m_nPostleitzahlTxtbx
            // 
            this.m_nPostleitzahlTxtbx.Location = new System.Drawing.Point(119, 43);
            this.m_nPostleitzahlTxtbx.Name = "m_nPostleitzahlTxtbx";
            this.m_nPostleitzahlTxtbx.Size = new System.Drawing.Size(59, 20);
            this.m_nPostleitzahlTxtbx.TabIndex = 4;
            // 
            // _SubmitBtn
            // 
            this._SubmitBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this._SubmitBtn.Location = new System.Drawing.Point(430, 208);
            this._SubmitBtn.Name = "_SubmitBtn";
            this._SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this._SubmitBtn.TabIndex = 10;
            this._SubmitBtn.Text = "Save";
            this._SubmitBtn.UseVisualStyleBackColor = true;
            this._SubmitBtn.Click += new System.EventHandler(this._SubmitBtn_Click);
            // 
            // _deleteBtn
            // 
            this._deleteBtn.Location = new System.Drawing.Point(511, 208);
            this._deleteBtn.Name = "_deleteBtn";
            this._deleteBtn.Size = new System.Drawing.Size(75, 23);
            this._deleteBtn.TabIndex = 11;
            this._deleteBtn.Text = "Delete";
            this._deleteBtn.UseVisualStyleBackColor = true;
            this._deleteBtn.Click += new System.EventHandler(this._deleteBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 237);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(574, 458);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(592, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(593, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.Location = new System.Drawing.Point(592, 237);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(593, 458);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.m_nHausnummerTxtbx);
            this.panel1.Controls.Add(this.m_sStrasseTxtbx);
            this.panel1.Controls.Add(this.m_nPostleitzahlTxtbx);
            this.panel1.Controls.Add(this.m_sOrtTxtbx);
            this.panel1.Location = new System.Drawing.Point(261, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 174);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "PLZ, Ort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Strasse, Hausnummer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vorname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adresse";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.m_sNameTxtbx);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.m_sVornameTxtbx);
            this.panel2.Location = new System.Drawing.Point(12, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 174);
            this.panel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Personlich Informationen";
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 707);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this._deleteBtn);
            this.Controls.Add(this._SubmitBtn);
            this.Controls.Add(this.panel2);
            this.Name = "ContactList";
            this.Text = "Contact List";
            this.Load += new System.EventHandler(this.ContactList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_sVornameTxtbx;
        private System.Windows.Forms.TextBox m_sNameTxtbx;
        private System.Windows.Forms.TextBox m_nHausnummerTxtbx;
        private System.Windows.Forms.TextBox m_sOrtTxtbx;
        private System.Windows.Forms.TextBox m_sStrasseTxtbx;
        private System.Windows.Forms.TextBox m_nPostleitzahlTxtbx;
        private System.Windows.Forms.Button _SubmitBtn;
        private System.Windows.Forms.Button _deleteBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}

