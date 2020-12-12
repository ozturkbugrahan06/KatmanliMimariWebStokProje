<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelEkle.aspx.cs" Inherits="KatmanlıMimariStok.PersonelEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  
    <form runat="server" class="form-group">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Personel Adı:" Font-Bold="true"></asp:Label>
        
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Personel Adını Giriniz..."></asp:TextBox>
    </div>
    <br />
        <div>
             <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Personel Soyadını Giriniz..."></asp:TextBox>
        </div>
        <br />
                <div>
             <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Personel Maaşını Giriniz..."></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Müşteri Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click"/>
    </div>
</form>


</asp:Content>
