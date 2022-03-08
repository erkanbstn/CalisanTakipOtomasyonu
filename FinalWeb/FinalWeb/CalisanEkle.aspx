<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalisanEkle.aspx.cs" Inherits="FinalWeb.CalisanEkle" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Tasarim/Dosyalar/css/styles.css" rel="stylesheet" />
</head>
<body>
    <br />
    <br />
    <br />
    <h2 style="margin:15px">Çalışan Ekle</h2>
    <br />

    <form runat="server" style="margin:15px" class="form-group">
        <div>
            <asp:Label for="TxtAd" runat="server" Text="Ad"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TxtAd" required="" runat="server" CssClass="form-control" placeholder="Adı Giriniz"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="TxtSoyad" runat="server" Text="Soyad"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TxtSoyad" required="" runat="server" CssClass="form-control" placeholder="Soyadı Giriniz"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="TxtTC" runat="server" Text="TC Kimlik No"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TxtTC" required="" runat="server" CssClass="form-control" placeholder="TC Kimlik No Giriniz"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:RadioButtonList CssClass="btn btn-primary" ID="RadioList" runat="server">
                <asp:ListItem Value="E">Erkek</asp:ListItem>
                <asp:ListItem Value="K">Kadın</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <br />
        <div>
            <asp:Label for="TxtDogumYili" runat="server" Text="Doğum Yılı"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TxtDogumYili" required="" type="number" runat="server" CssClass="form-control" placeholder="Doğum Yılı Giriniz"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="DropBolum" runat="server" Text="Bölüm"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropBolum" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label for="DropUnvan" runat="server" Text="Ünvan"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropUnvan" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>
        <br />
        <div>

            <asp:Label for="TxtBasTarihi" runat="server" Text="Başlangıç Tarihi"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TxtBasTarihi" required="" type="date" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="TxtBitTarihi" runat="server" Text="Bitiş Tarihi"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TxtBitTarihi" required="" type="date" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <br />
        <asp:Button ID="BtnEkle" runat="server" Text="Yeni Çalışan Ekle" CssClass="btn btn-success" OnClick="BtnEkle_Click" />
    </form>
    <br />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js"></script>
    <script src="Tasarim/Dosyalar/js/scripts.js"></script>
</body>
</html>
