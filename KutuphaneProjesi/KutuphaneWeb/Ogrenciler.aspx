<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ogrenciler.aspx.cs" Inherits="KutuphaneWeb.Ogrenciler" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Ogrenciler sayfası <br/>
    
        <asp:Button ID="ButtonOgrenci_EKLE" runat="server" 
            onclick="ButtonOgrenci_EKLE_Click" Text="EKLE" />
        <asp:Button ID="ButtonOgrenci_Temizle" runat="server" 
            onclick="ButtonOgrenci_Temizle_Click" Text="Temizle" />
        <asp:CheckBox ID="CheckBox_Ogrenci" runat="server" />
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Öğrenci Adı:"></asp:Label>
    <asp:TextBox ID="textBox_ogrenci" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Bölüm:"></asp:Label>
    <asp:DropDownList ID="DropDownList_Bolum" runat="server" Width="137px">
    </asp:DropDownList>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
        <asp:TextBox ID="textBox_ogrencisoyadi" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="T.C Kimlik Numarası:"></asp:Label>
        <asp:TextBox ID="textBox_tckimlikno" runat="server"></asp:TextBox>
    </p>
    <asp:Label ID="Label3" runat="server" Text="Öğrenci Numarası"></asp:Label>
    <asp:TextBox ID="textBox_ogrencino" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Telefon Numarası:"></asp:Label>
    <asp:TextBox ID="textBox_telefonno" runat="server"></asp:TextBox>
    <asp:GridView ID="GridView1" runat="server" onrowcommand="GridView1_RowCommand" 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
        <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton5" runat="server" CommandName="Duzenle" CommandArgument='<%#Eval("OgrenciID")%>' Text="Düzenle"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
    </asp:GridView>
    <asp:Button ID="Button_Resim" runat="server" onclick="Button_Resim_Click" 
        Text="Yükle" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:FileUpload ID="FileUpload1" 
        runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Image ID="Image1" runat="server" Height="250px" style="margin-left: 0px" 
        Width="250px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
