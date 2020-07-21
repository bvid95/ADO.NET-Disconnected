using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domaci1
{
    public partial class Form1 : Form
    {
        DataTable kupci, fakture, faktureStavke;
        DataSet Fakturisanje;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateDataSet_Click(object sender, EventArgs e)
        {
            try
            {
                kupci = new DataTable("Kupci");

                DataColumn kupacId = new DataColumn("KupacID", typeof(int));
                kupacId.AllowDBNull = false;
                kupacId.AutoIncrement = true;
                kupacId.AutoIncrementSeed = 1;
                kupacId.AutoIncrementStep = 1;
                kupci.Columns.Add(kupacId);

                DataColumn nazivKupca = new DataColumn("NazivKupca", typeof(string));
                nazivKupca.AllowDBNull = false;
                nazivKupca.MaxLength = 50;
                kupci.Columns.Add(nazivKupca);

                DataColumn adresa = new DataColumn("Adresa", typeof(string));
                adresa.AllowDBNull = true;
                adresa.MaxLength = 200;
                kupci.Columns.Add(adresa);

                kupci.PrimaryKey = new DataColumn[] { kupci.Columns["KupacID"] };



                fakture = new DataTable("Fakture");

                DataColumn fakturaId = new DataColumn("FakturaID", typeof(int));
                fakturaId.AllowDBNull = false;
                fakturaId.AutoIncrement = true;
                fakturaId.AutoIncrementSeed = 1;
                fakturaId.AutoIncrementStep = 1;
                fakture.Columns.Add(fakturaId);

                DataColumn kupacIdF = new DataColumn("KupacID", typeof(int));
                fakturaId.AllowDBNull = false;
                fakture.Columns.Add(kupacIdF);

                DataColumn datum = new DataColumn("Datum", typeof(DateTime));
                datum.AllowDBNull = false;
                datum.DefaultValue = DateTime.Now;
                fakture.Columns.Add(datum);


                fakture.PrimaryKey = new DataColumn[] { fakture.Columns["FakturaID"] };





                faktureStavke = new DataTable("FaktureStavke");

                DataColumn fakturaStavkaId = new DataColumn("FakturaID", typeof(int));
                fakturaStavkaId.AllowDBNull = false;
                faktureStavke.Columns.Add(fakturaStavkaId);

                DataColumn nazivStavke = new DataColumn("NazivStavke", typeof(string));
                nazivStavke.AllowDBNull = false;
                nazivStavke.MaxLength = 40;
                faktureStavke.Columns.Add(nazivStavke);

                DataColumn cenaStavke = new DataColumn("CenaStavke", typeof(decimal));
                cenaStavke.AllowDBNull = false;
                faktureStavke.Columns.Add(cenaStavke);

                faktureStavke.PrimaryKey = new DataColumn[] { faktureStavke.Columns["FakturaID"], faktureStavke.Columns["NazivStavke"] };






                Fakturisanje = new DataSet("Fakture");
                Fakturisanje.Tables.Add(kupci);
                Fakturisanje.Tables.Add(fakture);
                Fakturisanje.Tables.Add(faktureStavke);

                DataRelation dataRelation1 = new DataRelation("RelacijeKupciFakture", kupci.Columns["KupacID"], fakture.Columns["KupacID"], true);

                Fakturisanje.Relations.Add(dataRelation1);

                ForeignKeyConstraint fk1 = (ForeignKeyConstraint)fakture.Constraints["RelacijeKupciFakture"];
                fk1.DeleteRule = Rule.None;
                fk1.UpdateRule = Rule.None;



                DataRelation dataRelation2 = new DataRelation("RelacijeFaktureFaktureStavke", fakture.Columns["FakturaID"], faktureStavke.Columns["FakturaID"], true);

                Fakturisanje.Relations.Add(dataRelation2);

                ForeignKeyConstraint fk2 = (ForeignKeyConstraint)faktureStavke.Constraints["RelacijeFaktureFaktureStavke"];
                fk2.DeleteRule = Rule.None;
                fk2.UpdateRule = Rule.None;



                GridKupci.DataSource = kupci;
                GridFakture.DataSource = fakture;
                GridFaktureStavke.DataSource = faktureStavke;
                txtDatum.Text = DateTime.Now.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void btnSave2XML_Click(object sender, EventArgs e)
        {
            try
            {
                Fakturisanje.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MTZPP\\solDomaci1\\Fakture.xml", XmlWriteMode.WriteSchema);
                MessageBox.Show("Sacuvano!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnReadXML_Click(object sender, EventArgs e)
        {
            try
            {
                if(Fakturisanje is null)
                {
                    MessageBox.Show("Prvo napravite dataset!");
                }
                else
                {

                    Fakturisanje.ReadXml(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MTZPP\\solDomaci1\\Fakture.xml", XmlReadMode.IgnoreSchema);
                    MessageBox.Show("Ucitano!");
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            try
            {
                kupci.Rows.Add(null, txtKupac.Text, txtAdresa.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDodajFakturu_Click(object sender, EventArgs e)
        {
            try
            {
                fakture.Rows.Add(null, txtKupacID.Text, DateTime.Parse(txtDatum.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDodajFakturuStavku_Click(object sender, EventArgs e)
        {
            try
            {
                faktureStavke.Rows.Add(txtFakturaID.Text, txtNazivStavke.Text, txtCenaStavke.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        

      

        
        
    }
}
