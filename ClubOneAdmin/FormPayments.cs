using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubOneAdmin
{
    public partial class FormPayments : Form
    {
        public FormPayments()
        {
            InitializeComponent();

        }

        private void FormPayments_Load(object sender, EventArgs e)
        {
            gridView_LoadData();
        }

        private void gridView_LoadData()
        {
            SqlConnection sqlConnection =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; Database=clubone;");
            sqlConnection.Open();

            SqlCommand cmd 
                = new SqlCommand("select pdID, userID, username, trainingclassName, pd.amount " +
                "from Payment pt " +
                "join PaymentDetail pd on pt.pID = pd.paymentID ", sqlConnection);

            IDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            sqlConnection.Close();

            grdviewPayment.DataSource = ds.Tables[0].DefaultView;

            grdviewPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdviewPayment.Columns[0].Width = 60;
            

            //set header text
            grdviewPayment.Columns[0].HeaderText = "ID";
            grdviewPayment.Columns[1].HeaderText = "UserID";
            grdviewPayment.Columns[2].HeaderText = "USERNAME";
            grdviewPayment.Columns[3].HeaderText = "TRAINING CLASS";
            grdviewPayment.Columns[4].HeaderText = "AMOUNT";

        }

        
    }
}
