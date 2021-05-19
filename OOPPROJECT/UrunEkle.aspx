<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunEkle.aspx.cs" Inherits="OOPPROJECT.UrunEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container" style="vertical-align:central">
        <form runat="server">
            <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Ürün Ad" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="Ürün adını giriniz."></asp:TextBox>
            </div>
             <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Ürün Fiyat" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="Ürün fiyatı giriniz."></asp:TextBox>
            </div>
            <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Ürün Adet" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" class="form-control" placeholder="Ürün adeti giriniz."></asp:TextBox>
            </div>
            <div>
                <asp:Button runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Unnamed1_Click"/>
            </div>
        </form>
    </div>
</asp:Content>
