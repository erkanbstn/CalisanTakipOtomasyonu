using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinalWeb
{
    public static class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Geo\Desktop\Any Projects\BionlukSatis\FinalWeb\FinalWeb\App_Data\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=30");
    }
}