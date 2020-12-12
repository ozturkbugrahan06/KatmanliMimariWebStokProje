<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personel.aspx.cs" Inherits="KatmanlıMimariStok.Personel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

<table class="table table-bordered">
        <tr>
            <th>Personel Id</th>
            <th>Personel Adı</th>
            <th>Personel Soyadı</th>
            <th>Personel Departman</th>
            <th>Personel Maas</th>
            
        </tr>
        <tbody>
           <asp:Repeater ID="Repeater1" runat="server">
               <ItemTemplate>
            <tr>
                <td><%#Eval("PERSONELID") %></td>
                <td><%#Eval("PERSONELAD") %></td>
                <td><%#Eval("PERSONELSOYAD") %></td>
                <td><%#Eval("PERSONELDEP") %></td>
                <td><%#Eval("PERSONELMAAS") %></td>

            </tr>
            </ItemTemplate>
           </asp:Repeater>
        </tbody>
    </table>
    <a href="PersonelEkle.aspx" class="btn btn-info">Yeni Personel</a>
</asp:Content>
