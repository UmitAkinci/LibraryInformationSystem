<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Odunc.aspx.cs" Inherits="KutuphaneWeb.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Odunc sayfası <br/>
    
        <asp:Label ID="Label1" runat="server" Text="Adı Soyadı :"></asp:Label>
&nbsp;&nbsp;<asp:DropDownList ID="DropDownList_adsoyad" runat="server">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Verilme Tarihi :"></asp:Label>
        <asp:TextBox ID="txtVerilmeTarihi" runat="server"></asp:TextBox>
    </div>
    <asp:Label ID="Label2" runat="server" Text="Verilen Kitap :"></asp:Label>
&nbsp;&nbsp;<asp:DropDownList ID="DropDownList_Verilenkitap" runat="server">
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="İade Tarihi :"></asp:Label>
    <asp:TextBox ID="txtIadeTarihi" runat="server"></asp:TextBox>
    <p>
        <asp:Button ID="ButtonOdunc_EKLE" runat="server" Text="EKLE" 
            onclick="ButtonOdunc_EKLE_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonOdunc_Temizle" runat="server" Text="Temizle" 
            onclick="ButtonOdunc_Temizle_Click" />
        <asp:CheckBox ID="CheckBox_Odunc" runat="server" />
    </p>
    <asp:GridView ID="GridView1" runat="server">
          <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton5" runat="server" CommandName="Duzenle" CommandArgument='<%#Eval("OduncID")%>' Text="Düzenle"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
    </asp:GridView>
    </form>
</body>
</html>
