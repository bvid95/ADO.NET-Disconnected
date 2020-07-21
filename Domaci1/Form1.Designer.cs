namespace Domaci1
{
    partial class Form1
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
            this.btnCreateDataSet = new System.Windows.Forms.Button();
            this.GridKupci = new System.Windows.Forms.DataGridView();
            this.GridFakture = new System.Windows.Forms.DataGridView();
            this.GridFaktureStavke = new System.Windows.Forms.DataGridView();
            this.txtKupac = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtKupacID = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtNazivStavke = new System.Windows.Forms.TextBox();
            this.txtCenaStavke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodajKupca = new System.Windows.Forms.Button();
            this.btnDodajFakturu = new System.Windows.Forms.Button();
            this.btnDodajFakturuStavku = new System.Windows.Forms.Button();
            this.btnSave2XML = new System.Windows.Forms.Button();
            this.btnReadXML = new System.Windows.Forms.Button();
            this.txtFakturaID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridKupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFakture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFaktureStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateDataSet
            // 
            this.btnCreateDataSet.Location = new System.Drawing.Point(9, 10);
            this.btnCreateDataSet.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateDataSet.Name = "btnCreateDataSet";
            this.btnCreateDataSet.Size = new System.Drawing.Size(88, 32);
            this.btnCreateDataSet.TabIndex = 0;
            this.btnCreateDataSet.Text = "DataSet ";
            this.btnCreateDataSet.UseVisualStyleBackColor = true;
            this.btnCreateDataSet.Click += new System.EventHandler(this.btnCreateDataSet_Click);
            // 
            // GridKupci
            // 
            this.GridKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridKupci.Location = new System.Drawing.Point(9, 56);
            this.GridKupci.Margin = new System.Windows.Forms.Padding(2);
            this.GridKupci.Name = "GridKupci";
            this.GridKupci.RowHeadersWidth = 51;
            this.GridKupci.RowTemplate.Height = 24;
            this.GridKupci.Size = new System.Drawing.Size(248, 122);
            this.GridKupci.TabIndex = 1;
            // 
            // GridFakture
            // 
            this.GridFakture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFakture.Location = new System.Drawing.Point(284, 56);
            this.GridFakture.Margin = new System.Windows.Forms.Padding(2);
            this.GridFakture.Name = "GridFakture";
            this.GridFakture.RowHeadersWidth = 51;
            this.GridFakture.RowTemplate.Height = 24;
            this.GridFakture.Size = new System.Drawing.Size(248, 122);
            this.GridFakture.TabIndex = 2;
            // 
            // GridFaktureStavke
            // 
            this.GridFaktureStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFaktureStavke.Location = new System.Drawing.Point(556, 56);
            this.GridFaktureStavke.Margin = new System.Windows.Forms.Padding(2);
            this.GridFaktureStavke.Name = "GridFaktureStavke";
            this.GridFaktureStavke.RowHeadersWidth = 51;
            this.GridFaktureStavke.RowTemplate.Height = 24;
            this.GridFaktureStavke.Size = new System.Drawing.Size(248, 122);
            this.GridFaktureStavke.TabIndex = 3;
            // 
            // txtKupac
            // 
            this.txtKupac.Location = new System.Drawing.Point(53, 205);
            this.txtKupac.Margin = new System.Windows.Forms.Padding(2);
            this.txtKupac.Name = "txtKupac";
            this.txtKupac.Size = new System.Drawing.Size(76, 20);
            this.txtKupac.TabIndex = 4;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(53, 235);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(76, 20);
            this.txtAdresa.TabIndex = 5;
            // 
            // txtKupacID
            // 
            this.txtKupacID.Location = new System.Drawing.Point(332, 202);
            this.txtKupacID.Margin = new System.Windows.Forms.Padding(2);
            this.txtKupacID.Name = "txtKupacID";
            this.txtKupacID.Size = new System.Drawing.Size(76, 20);
            this.txtKupacID.TabIndex = 6;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(332, 235);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(76, 20);
            this.txtDatum.TabIndex = 7;
            // 
            // txtNazivStavke
            // 
            this.txtNazivStavke.Location = new System.Drawing.Point(625, 232);
            this.txtNazivStavke.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazivStavke.Name = "txtNazivStavke";
            this.txtNazivStavke.Size = new System.Drawing.Size(76, 20);
            this.txtNazivStavke.TabIndex = 8;
            // 
            // txtCenaStavke
            // 
            this.txtCenaStavke.Location = new System.Drawing.Point(625, 264);
            this.txtCenaStavke.Margin = new System.Windows.Forms.Padding(2);
            this.txtCenaStavke.Name = "txtCenaStavke";
            this.txtCenaStavke.Size = new System.Drawing.Size(76, 20);
            this.txtCenaStavke.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kupac";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "KupacID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cena stavke";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Naziv stavke";
            // 
            // btnDodajKupca
            // 
            this.btnDodajKupca.Location = new System.Drawing.Point(53, 295);
            this.btnDodajKupca.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajKupca.Name = "btnDodajKupca";
            this.btnDodajKupca.Size = new System.Drawing.Size(76, 40);
            this.btnDodajKupca.TabIndex = 16;
            this.btnDodajKupca.Text = "Dodaj";
            this.btnDodajKupca.UseVisualStyleBackColor = true;
            this.btnDodajKupca.Click += new System.EventHandler(this.btnDodajKupca_Click);
            // 
            // btnDodajFakturu
            // 
            this.btnDodajFakturu.Location = new System.Drawing.Point(332, 295);
            this.btnDodajFakturu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajFakturu.Name = "btnDodajFakturu";
            this.btnDodajFakturu.Size = new System.Drawing.Size(76, 40);
            this.btnDodajFakturu.TabIndex = 17;
            this.btnDodajFakturu.Text = "Dodaj";
            this.btnDodajFakturu.UseVisualStyleBackColor = true;
            this.btnDodajFakturu.Click += new System.EventHandler(this.btnDodajFakturu_Click);
            // 
            // btnDodajFakturuStavku
            // 
            this.btnDodajFakturuStavku.Location = new System.Drawing.Point(625, 295);
            this.btnDodajFakturuStavku.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajFakturuStavku.Name = "btnDodajFakturuStavku";
            this.btnDodajFakturuStavku.Size = new System.Drawing.Size(76, 40);
            this.btnDodajFakturuStavku.TabIndex = 18;
            this.btnDodajFakturuStavku.Text = "Dodaj";
            this.btnDodajFakturuStavku.UseVisualStyleBackColor = true;
            this.btnDodajFakturuStavku.Click += new System.EventHandler(this.btnDodajFakturuStavku_Click);
            // 
            // btnSave2XML
            // 
            this.btnSave2XML.Location = new System.Drawing.Point(605, 17);
            this.btnSave2XML.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave2XML.Name = "btnSave2XML";
            this.btnSave2XML.Size = new System.Drawing.Size(79, 25);
            this.btnSave2XML.TabIndex = 19;
            this.btnSave2XML.Text = "Save XML";
            this.btnSave2XML.UseVisualStyleBackColor = true;
            this.btnSave2XML.Click += new System.EventHandler(this.btnSave2XML_Click);
            // 
            // btnReadXML
            // 
            this.btnReadXML.Location = new System.Drawing.Point(725, 17);
            this.btnReadXML.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadXML.Name = "btnReadXML";
            this.btnReadXML.Size = new System.Drawing.Size(78, 25);
            this.btnReadXML.TabIndex = 20;
            this.btnReadXML.Text = "Read XML";
            this.btnReadXML.UseVisualStyleBackColor = true;
            this.btnReadXML.Click += new System.EventHandler(this.btnReadXML_Click);
            // 
            // txtFakturaID
            // 
            this.txtFakturaID.Location = new System.Drawing.Point(625, 202);
            this.txtFakturaID.Margin = new System.Windows.Forms.Padding(2);
            this.txtFakturaID.Name = "txtFakturaID";
            this.txtFakturaID.Size = new System.Drawing.Size(76, 20);
            this.txtFakturaID.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "FakturaID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 366);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFakturaID);
            this.Controls.Add(this.btnReadXML);
            this.Controls.Add(this.btnSave2XML);
            this.Controls.Add(this.btnDodajFakturuStavku);
            this.Controls.Add(this.btnDodajFakturu);
            this.Controls.Add(this.btnDodajKupca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCenaStavke);
            this.Controls.Add(this.txtNazivStavke);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtKupacID);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtKupac);
            this.Controls.Add(this.GridFaktureStavke);
            this.Controls.Add(this.GridFakture);
            this.Controls.Add(this.GridKupci);
            this.Controls.Add(this.btnCreateDataSet);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridKupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFakture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFaktureStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDataSet;
        private System.Windows.Forms.DataGridView GridKupci;
        private System.Windows.Forms.DataGridView GridFakture;
        private System.Windows.Forms.DataGridView GridFaktureStavke;
        private System.Windows.Forms.TextBox txtKupac;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtKupacID;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtNazivStavke;
        private System.Windows.Forms.TextBox txtCenaStavke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodajKupca;
        private System.Windows.Forms.Button btnDodajFakturu;
        private System.Windows.Forms.Button btnDodajFakturuStavku;
        private System.Windows.Forms.Button btnSave2XML;
        private System.Windows.Forms.Button btnReadXML;
        private System.Windows.Forms.TextBox txtFakturaID;
        private System.Windows.Forms.Label label7;
    }
}

