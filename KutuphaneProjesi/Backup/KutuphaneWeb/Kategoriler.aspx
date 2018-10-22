<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="KutuphaneWeb.Kategoriler" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Kategoriler sayfası <br />
        <asp:TextBox ID="TextBox_Kategori" runat="server"></asp:TextBox>
    
    </div>
    <asp:CheckBox ID="CheckBox_Kategori" runat="server" />
    <br />
    <asp:Button ID="ButtonKategori_Ekle" runat="server" 
        onclick="ButtonKategori_Ekle_Click" Text="EKLE" />
    <asp:Button ID="ButtonKategori_Temizle" runat="server" 
        onclick="ButtonKategori_Temizle_Click" Text="Temizle" />
    <asp:GridView ID="GridView1" runat="server" onrowcommand="GridView1_RowCommand">
     <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton3" runat="server" CommandName="Duzenle" CommandArgument='<%#Eval("KategoriID")%>' Text="Düzenle"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
    </asp:GridView>
    </form>
</body>
</html>
