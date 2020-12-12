<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satislar.aspx.cs" Inherits="KatmanlıMimariStok.Satislar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>Satış Id</th>
            <th>Ürün Adı</th>
            <th>Personel</th>
            <th>Müşteri</th>
            <th>Tutar</th>

            
        </tr>
        <tbody>
           <asp:Repeater ID="Repeater1" runat="server">
               <ItemTemplate>
            <tr>
                <td><%#Eval("SATISID") %></td>
                <td><%#Eval("URUNAD") %></td>
                <td><%#Eval("PERSONELAD") %></td>
                <td><%#Eval("MUSTERIAD") %></td>
                <td><%#Eval("fiyat") %></td>                
            </tr>
            </ItemTemplate>
           </asp:Repeater>
        </tbody>
    </table>
     <a href="SatisEkle.aspx" class="btn btn-info">Yeni Satış Ekle</a>
</asp:Content>
