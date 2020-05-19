using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace MySQLdataAdapterApp
{
    public partial class mainForm : Form
    {
        MySqlConnection myConnection;
        MySqlDataAdapter myDataAdapter;
        MySqlCommandBuilder myCommandBuidler;
        MySqlCommand mySqlComm;
        DataTable myTable;

        int rowProductID;

        public string productNaam;
        public int stock;
        public bool beschikbaar;

        string connectionString;
        string selectQuery = "SELECT productID, productNaam, productStock, beschikbaar FROM producten";
        public mainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            BtnRecordVerwijderen.Enabled = false;
            BtnRecordWijzigen.Enabled = false;
        }

        private void BtnExecuteSelectQuery_Click(object sender, EventArgs e)
        {
            using(myConnection = new MySqlConnection(connectionString))
                {
                    myConnection.Open();
                    myDataAdapter = new MySqlDataAdapter(selectQuery, myConnection);
                    myCommandBuidler = new MySqlCommandBuilder(myDataAdapter);
                using (myTable = new DataTable())
                    {
                        myDataAdapter.Fill(myTable);
                        DgvProducten.DataSource = myTable;
                        DgvProducten.ClearSelection();     
                    }
                }
        }
        private void PasDataTabelAan(DataTable tabel , int rij, int kol, string data)
        {
            tabel.Rows[rij][kol] = data;
        }
        private void PasDataGridViewAan(DataGridView grid, int rij, int kol, string data)
        {
            grid[rij, kol].Value = data;
        }
        private void BtnUpdateTabel_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlConn = myConnection)
            {
                mySqlConn.Open();

                if (mySqlConn.State == ConnectionState.Open)
                {
                    try
                    {
                        DataTable changes = myTable.GetChanges();

                        if (changes != null)
                        {
                            myDataAdapter.Update(changes);
                            myTable.AcceptChanges();
                        }
                        else
                            MessageBox.Show("Geen veranderingen zijn gemaakt", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(MySqlException ex) when (ex.Number ==  1451)
                    {
                        DeleteForeignkeysOfProduct();                  
                    }
                }
                else
                    MessageBox.Show("Connectie kan niet geopend worden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DeleteForeignkeysOfProduct()
        {
            // WANNEER ER FOREIGN KEY ERORRS ZIJN WORDEN DIE HIER VERWIJDERD
            using (myConnection = new MySqlConnection(connectionString))
            {
                myConnection.Open();

                if (myConnection.State == ConnectionState.Open)
                {
                    DialogResult dialogResult = MessageBox.Show("Er zijn foreign key constraints gevonden in de database bestelling wilt u deze verwijderen?", "Record verwijderen", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        using (mySqlComm = new MySqlCommand())
                        {
                            mySqlComm = new MySqlCommand();
                            mySqlComm.Connection = myConnection;
                            mySqlComm.CommandText = "DELETE FROM bestelling WHERE productID = @productID;";
                            mySqlComm.Parameters.AddWithValue("@productID", rowProductID);
                            mySqlComm.CommandType = CommandType.Text;
                            mySqlComm.ExecuteNonQuery();
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Product wordt niet verwijderd door een foreign key constraint", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Geen connectie met database ", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void DgvProducten_DoubleClick(object sender, EventArgs e)
        {
                DataGridViewSelectedRowCollection geselecteerdeRijen = DgvProducten.SelectedRows;

                StringBuilder sb = new StringBuilder();

                foreach (DataGridViewRow r in geselecteerdeRijen)
                {
                    sb.Append(r.Index.ToString());
                }

                MessageBox.Show("rij "+sb.ToString()+ " geselecteerd...");
        }
        private void BtnRecordVerwijderen_Click(object sender, EventArgs e)
        {
            rowProductID = (int)DgvProducten.SelectedRows[0].Cells[0].Value;
            DialogResult Dr = MessageBox.Show("Wilt u dit product verwijderen?", "Product verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Dr == DialogResult.Yes)
                DgvProducten.Rows.RemoveAt(DgvProducten.SelectedRows[0].Index);
        }
        private void BtnRecordWijzigen_Click(object sender, EventArgs e)
        {
            rowProductID = (int)DgvProducten.SelectedRows[0].Cells[0].Value;
            using (invulForm invulForm = new invulForm(this))
            { 
                if(invulForm.ShowDialog() == DialogResult.OK)
                {
                    myTable.Rows[rowProductID - 1]["productNaam"] = productNaam;
                    myTable.Rows[rowProductID - 1]["productStock"] = stock;
                    myTable.Rows[rowProductID - 1]["beschikbaar"] = beschikbaar;
                    DgvProducten.Refresh();

                    MessageBox.Show("Waarden in datagridview gezet, druk op update om de database te synchronyseren", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void BtnRecordToevoegen_Click(object sender, EventArgs e)
        {
            rowProductID = (int)DgvProducten.SelectedRows[0].Cells[0].Value;
            using (invulForm invulForm = new invulForm(this))
            {
                invulForm.Text = "MySQL Databasebeheer - record toevoegen";
                invulForm.RecordtitleLabel.Text = "record toevoegen";
                if (invulForm.ShowDialog() == DialogResult.OK)
                {
                    myTable.Rows.Add(new Object[]{ rowProductID + 1, productNaam, stock, beschikbaar });
                    DgvProducten.Refresh();
                    MessageBox.Show("Waarden in datagridview gezet, druk op update om de database te synchronyseren", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void BtnPasDataTabelAan_Click(object sender, EventArgs e)
        {
            PasDataTabelAan(myTable, 1, 0, "Hamburger");
        }
        private void BtnPasDataGridViewAan_Click(object sender, EventArgs e)
        {
            PasDataGridViewAan(DgvProducten, 0,1, "Pasta");
        }
        private void DgvProducten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnRecordVerwijderen.Enabled = true;
            BtnRecordWijzigen.Enabled = true;
        }
    }
}
