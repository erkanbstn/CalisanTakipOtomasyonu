using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FinalWeb
{
    public partial class CalisanListe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("Exec CalisanListele",Baglanti.bgl);
            DataTable t = new DataTable();
            ad.Fill(t);
            Repeater1.DataSource = t;
            Repeater1.DataBind();
        }
    }
}