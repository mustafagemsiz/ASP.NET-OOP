<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satis.aspx.cs" Inherits="OOPPROJECT.Satis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <div class="container">
        <table class="table table-bordered">
            <thead>
            <tr>
                <th>SATIŞ ID</th>
                <th>ÜRÜN AD</th>
                <th>PERSONEL</th>
                <th>MÜŞTERİ</th>
                <th>TUTAR</th>
            </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                <tr>
                    <td><%#Eval("SATISID") %></td>
                    <td><%#Eval("URUNAD") %></td>
                    <td><%#Eval("PERSONELAD") %></td>
                    <td><%#Eval("MUSTERIAD") %></td>
                    <td><%#Eval("TUTAR") %></td>
                </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
            <a href="SatisEkle.aspx"><button class="btn btn-primary">Yeni Satış</button></a> 
    </div>
</asp:Content>
