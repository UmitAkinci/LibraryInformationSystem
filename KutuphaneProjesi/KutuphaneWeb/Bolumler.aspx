<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bolumler.aspx.cs" Inherits="KutuphaneWeb.FrmBolum" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Bölümler sayfası <br />
    
        <asp:TextBox ID="TextBox_Bolum" runat="server"></asp:TextBox>
    
    </div>
    <asp:CheckBox ID="CheckBox_Bolum" runat="server" />
    <br />
    <asp:Button ID="ButtonBolum_Ekle" runat="server" onclick="ButtonBolum_Ekle_Click" Text="EKLE" />
    <asp:Button ID="ButtonBolum_Temizle" runat="server" onclick="ButtonBolum_Temizle_Click" Text="Temizle" />
    <asp:GridView ID="GridView1" runat="server" onrowcommand="GridView1_RowCommand">
        <Columns>
            <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Duzenle" CommandArgument='<%#Eval("BolumID")%>' Text="Düzenle"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </form>
</body>
</html>
