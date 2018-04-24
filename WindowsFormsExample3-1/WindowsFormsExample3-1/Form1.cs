using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsExample3_1
{
    public partial class frmSales : Form
    {
        SqlConnection SalesConnection;
        SqlCommand myCommand;
        CurrencyManager titlesManager;
        public frmSales()
        {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {            
            // connect to books database
            //SalesConnection = new SqlConnection("Data Source =MI-PC;databse=AdventureWorks2016CTP3;Integrated Security = True; Connect Timeout = 30; User Instance = True");
            SalesConnection = new SqlConnection("server=MI-PC;database=AdventureWorks2016CTP3;User Id=SA; Password=adrian9110");
            //open the connection

            SalesConnection.Open();

            //display state
            lblState.Text = SalesConnection.State.ToString();

            string MyQuery = "SELECT top 10 * FROM Sales.SalesOrder_json";
            myCommand = new SqlCommand(MyQuery, SalesConnection);
            SqlDataAdapter myAdapter;
            myAdapter = new SqlDataAdapter();

            myAdapter.SelectCommand = myCommand;

            //SqlCommandBuilder myCommandBuilder = new SqlCommandBuilder(myAdapter);
            DataTable titlesTable;
            titlesTable = new DataTable();
            myAdapter.Fill(titlesTable);

            txtSalesOrderID.DataBindings.Add("Text", titlesTable, "SalesOrderID");
            txtOrderDate.DataBindings.Add("Text", titlesTable, "OrderDate");
            txtSalesOrderNumber.DataBindings.Add("Text", titlesTable, "SalesOrderNumber");
            txtRowguid.DataBindings.Add("Text", titlesTable, "rowguid");

            //establish currency manager
            titlesManager = (CurrencyManager)BindingContext[titlesTable];

            //close the connection
            SalesConnection.Close();
            //display state
            lblState.Text += SalesConnection.State.ToString();
            //dispose of the connection object
            SalesConnection.Dispose();
            myAdapter.Dispose();
            titlesTable.Dispose();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            titlesManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            titlesManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            titlesManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            titlesManager.Position = titlesManager.Count - 1;
        }
    }
}
