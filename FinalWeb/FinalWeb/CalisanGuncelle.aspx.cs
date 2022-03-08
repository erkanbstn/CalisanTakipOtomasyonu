using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace FinalWeb
{
    public partial class CalisanGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropBolum.Items.Insert(0, "Seçiniz");
            DropUnvan.Items.Insert(0, "Seçiniz");
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

            if (!Page.IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["ID"]);
                SqlCommand komut = new SqlCommand("Select * from Calisan Where ID=@p1", Baglanti.bgl);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("@p1", id);
                SqlDataReader dr3 = komut.ExecuteReader();
                while (dr3.Read())
                {
                    TxtAd.Text = dr3[1].ToString();
                    TxtSoyad.Text = dr3[2].ToString();
                    TxtTC.Text = dr3[3].ToString();
                    RadioList.SelectedValue = dr3[4].ToString();
                    TxtDogumYili.Text = dr3[5].ToString();
                    DropBolum.SelectedIndex = Convert.ToInt32(dr3[6]);
                    DropUnvan.SelectedIndex = Convert.ToInt32(dr3[7]);
                }
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            SqlCommand komut = new SqlCommand("Update Calisan set Adi=@p1,Soyadi=@p2,TCKimlikNo=@p3,Cinsiyet=@p4,DogumYili=@p5,BolumID=@p6,UnvanID=@p7,BasTarih=@p8,BitTarih=@p9 Where ID=@p10", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtTC.Text);
            komut.Parameters.AddWithValue("@p4", RadioList.SelectedValue.ToString());
            komut.Parameters.AddWithValue("@p5", TxtDogumYili.Text);
            komut.Parameters.AddWithValue("@p6", DropBolum.SelectedIndex - 1);
            komut.Parameters.AddWithValue("@p7", DropUnvan.SelectedIndex - 1);
            komut.Parameters.AddWithValue("@p8", TxtBasTarihi.Text);
            komut.Parameters.AddWithValue("@p9", TxtBitTarihi.Text);
            komut.Parameters.AddWithValue("@p10", id);
            int yil = Convert.ToInt32(TxtDogumYili.Text);
            if (yil > 1950 && yil < 2004)
            {
                komut.ExecuteNonQuery();
                Baglanti.bgl.Close();
                Response.Write("<script>alert('Çalışan Güncellendi')</script>");
            }
            else
            {
                Response.Write("<script>alert('Yıl Değeri 1950 - 2004 Arasında Olmalıdır.')</script>");
            }

        }

        protected void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            SqlCommand komut = new SqlCommand("Delete Calisan Where ID=@p1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", id);
            komut.ExecuteNonQuery();
            Baglanti.bgl.Close();
            Response.Write("<script>alert('Çalışan Silindi')</script>");
        }
    }
}