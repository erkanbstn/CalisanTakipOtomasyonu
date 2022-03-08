<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalisanListe.aspx.cs" Inherits="FinalWeb.CalisanListe" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Çalışan Listesi</title>
    <link href="Tasarim/Dosyalar/css/styles.css" rel="stylesheet" />
</head>
<body style="margin: 15px">
    <br />
    <h3>Çalışan Listesi</h3>
    <br />
    <br />
    <div class="d-flex" id="wrapper">
        <table class="table table-bordered">
            <tr>
                <th>Adı</th>
                <th>Soyadı</th>
                <th>TC Kimlik No</th>
                <th>Cinsiyet</th>
                <th>Doğum Yılı</th>
                <th>Bölüm</th>
                <th>Ünvan</th>
                <th>Başlangıç Tarihi</th>
                <th>Bitiş Tarihi</th>
                <th></th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Adi")%></td>
                        <td><%#Eval("Soyadi")%></td>
                        <td><%#Eval("TCKimlikNo")%></td>
                        <td><%#Eval("Cinsiyet")%></td>
                        <td><%#Eval("DogumYili")%></td>
                        <td><%#Eval("Bolum")%></td>
                        <td><%#Eval("Unvan")%></td>
                        <td><%#Eval("BasTarih")%></td>
                        <td><%#Eval("BitTarih")%></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"CalisanGuncelle.aspx?ID="+Eval("ID")%>' runat="server" CssClass="btn btn-primary">Detay</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <hr />
    </div>
    <a href="CalisanEkle.aspx" class="btn btn-danger">Yeni Çalışan Ekle</a>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js"></script>
    <script src="Tasarim/Dosyalar/js/scripts.js"></script>
</body>
</html>
