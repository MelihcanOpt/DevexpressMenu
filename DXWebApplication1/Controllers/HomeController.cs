using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        string connectionString = ("Data Source=77.245.159.10\\MSSQLSERVER2019; Initial Catalog=OPTMTS;User ID=OptMtsDB156;Password=k$w9M?Qr7!e2C9z; MultipleActiveResultSets=True");

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GridViewPartial()
        {
            DataTable dataTable = GetDataFromDatabase(); // Verileri veritabanýndan alýn
            return PartialView("_GridViewPartial", dataTable);
        }

        private DataTable GetDataFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT FIRMA_ID, FIRMA_AD, FIYAT_KOD, TICARI_UNVAN, KAYIT_TARIH FROM FIRMA WITH(NOLOCK)"; // SQL sorgunuzu burada belirtin
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

    }
}