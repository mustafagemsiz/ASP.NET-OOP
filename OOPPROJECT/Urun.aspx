<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urun.aspx.cs" Inherits="OOPPROJECT.Urun" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
        <table class="table table-bordered">
            <thead>
                <tr>
                <th>ÜRÜN ID</th>
                <th>ÜRÜN AD</th>
                <th>ÜRÜN FİYAT</th>
                <th>ÜRÜN ADET</th>
                </tr>
            </thead>
            
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                <tr>
                    <td><%#Eval("URUNID") %></td>
                    <td><%#Eval("URUNAD") %></td>
                    <td><%#Eval("URUNFIYAT") %></td>
                    <td><%#Eval("URUNADET") %></td>
                </tr>
                        </ItemTemplate>
                </asp:Repeater>
            </tbody>           
        </table> 
        <a href="UrunEkle.aspx"> <button class="btn btn-primary">Yeni Ürün</button> </a>
    </div>
       
</asp:Content>
