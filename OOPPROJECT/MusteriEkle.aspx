<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MusteriEkle.aspx.cs" Inherits="OOPPROJECT.MusteriEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container" style="vertical-align:central">
        <form runat="server">
            <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Müşteri Ad" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="Müşteri adını giriniz."></asp:TextBox>
            </div>
             <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Müşteri Soyad" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="Müşteri soyadını giriniz."></asp:TextBox>
            </div>
            <div>
             <asp:Button ID="Button1" runat="server" Text="Kaydet"  CssClass="btn btn-success" OnClick="Button1_Click"/>
            </div>
        </form>
    </div>
</asp:Content>
