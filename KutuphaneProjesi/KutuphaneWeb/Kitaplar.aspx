<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kitaplar.aspx.cs" Inherits="KutuphaneWeb.Kitaplar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Kitaplar sayfası <br />
        <asp:Label ID="Label1" runat="server" Text="KitapAdi:"></asp:Label>
        <asp:TextBox ID="TextBox_Kitap" runat="server" Height="22px" 
            style="margin-left: 43px" Width="107px"></asp:TextBox>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="YazarAdı :"></asp:Label>
        <asp:DropDownList ID="DropDownList_Yazar" runat="server">
        </asp:DropDownList>
    
    </div>
    <br />
    <asp:Label ID="Label2" runat="server" Text="KategoriAdi :"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList_Kategori" 
        runat="server">
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="ISBN:"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxISBN" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Button ID="ButtonKitaplar_EKLE" runat="server" 
        onclick="ButtonKitaplar_EKLE_Click" Text="EKLE" />
    <asp:Button ID="ButtonKategori_Temizle" runat="server" Height="26px" 
        onclick="ButtonKategori_Temizle_Click" Text="Temizle" />
    <asp:CheckBox ID="CheckBox_Kitap" runat="server" />
    <br />
    <asp:GridView ID="GridView1" runat="server" onrowcommand="GridView1_RowCommand">
    <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton4" runat="server" CommandName="Duzenle" CommandArgument='<%#Eval("KitapID")%>' Text="Düzenle"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
    </asp:GridView>
    </form>
</body>
</html>
