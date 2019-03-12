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
            mgExceptList.DataSource = dbTable;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataRow[] rows = dbTable.Select("BATCH_ID = " + txtSearch.Text);
            
            if(rows.Length > 0)
            {
                mgExceptList.DataSource = rows;
            }
        }
    }
}
