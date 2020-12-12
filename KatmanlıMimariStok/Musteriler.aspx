﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Musteriler.aspx.cs" Inherits="KatmanlıMimariStok.Musteriler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    <table class="table table-bordered">
        <tr>
            <th>Müşteri Id</th>
            <th>Müşteri Adı</th>
            <th>Müşteri Soyadı</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>

        </tr>
        <tbody>
           <asp:Repeater ID="Repeater1" runat="server">
               <ItemTemplate>
            <tr>
                <td><%#Eval("MUSTERIID") %></td>
                <td><%#Eval("MUSTERIAD") %></td>
                <td><%#Eval("MUSTERISOYAD") %></td>
               
                <td><asp:HyperLink NavigateUrl='<%#"~/MusteriSil.Aspx?MUSTERIID=" + Eval("MUSTERIID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                <td><asp:HyperLink NavigateUrl='<%#"~/MusteriGuncelle.Aspx?MUSTERIID=" + Eval("MUSTERIID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
            </tr>
                   
            </ItemTemplate>
           </asp:Repeater>
        </tbody>
    </table>
    <a href="MusteriEkle.aspx" class="btn btn-info">Yeni Müşteri</a>
</asp:Content>
