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
    public partial class CalisanEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Bolum", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropBolum.Items.Add(dr["BolumAdi"].ToString());
            }
            dr.Close();
            Baglanti.bgl.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Unvan", Baglanti.bgl);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                DropUnvan.Items.Add(dr2["Unvan"].ToString());
            }
            dr2.Close();
            Baglanti.bgl.Close();
        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Insert into Calisan values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtTC.Text);
            komut.Parameters.AddWithValue("@p4", RadioList.SelectedValue.ToString());
            komut.Parameters.AddWithValue("@p5", TxtDogumYili.Text);
            komut.Parameters.AddWithValue("@p6", DropBolum.SelectedIndex + 1);
            komut.Parameters.AddWithValue("@p7", DropUnvan.SelectedIndex + 1);
            komut.Parameters.AddWithValue("@p8", TxtBasTarihi.Text);
            komut.Parameters.AddWithValue("@p9", TxtBitTarihi.Text);
            int yil = Convert.ToInt32(TxtDogumYili.Text);
            if (yil > 1950 && yil < 2004)
            {

                komut.ExecuteNonQuery();
                Baglanti.bgl.Close();
                Response.Write("<script>alert('Çalışan Eklendi')</script>");
            }
            else
            {
                Response.Write("<script>alert('Yıl Değeri 1950 - 2004 Arasında Olmalıdır.')</script>");
            }

        }
    }
}