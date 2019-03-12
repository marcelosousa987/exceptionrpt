using CadMaterial.Business;
using System;
using System.Data;

namespace ExceptionRpt
{
    public partial class reportPOMS : MetroFramework.Forms.MetroForm
    {

        Connection con = new Connection();
        DataTable dbTable;

        

        public reportPOMS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbTable = con.loadDataTable("BAX_EXCEPTION_LOG", " * ", " ORDER BY BATCH_ID, ENTRY_TIMESTAMP ASC ");
            dtGrid.DataSource = dbTable;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void htmlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {

        }

        private void mgExceptList_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataRow[] rows = dbTable.Select("BATCH_ID = " + txtSearch.Text);

            if (rows.Length > 0)
            {
                dtGrid.DataSource = rows;
            }
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void htmlPanel1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            
        }

        private void txtSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick_1(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
        }
    }
}
