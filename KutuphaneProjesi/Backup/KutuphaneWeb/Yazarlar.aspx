<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Yazarlar.aspx.cs" Inherits="KutuphaneWeb.Yazarlar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        yazarlar sayfası<br />
        <asp:TextBox ID="textBox_Yazar" runat="server"></asp:TextBox>
        <asp:CheckBox ID="checkBox_Yazar" runat="server" />
        <br />
        <asp:Button ID="btnEkleGuncelle" runat="server" Text="EKLE" OnClick="btnEkleGuncelle_Click" />
        <asp:Button ID="Button_Temizle" runat="server" onclick="Button_Temizle_Click" 
            Text="Temizle" />
        <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Duzenle" CommandArgument='<%#Eval("YazarID")%>' Text="Düzenle"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
