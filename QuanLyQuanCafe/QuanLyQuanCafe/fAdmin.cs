using QuanLyQuanCafe.DAO;
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

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            //LoadAccountList();
        }

        //void LoadAccountList()
        //{
        //    string query = "USP_GetAccountByUserName @userName";
            
        //    dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "staff"});
        //}
    }
}
