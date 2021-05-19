<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="DepartmanEkle.aspx.cs" Inherits="OOPPROJECT.DepartmanEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container" style="vertical-align:central">
        <form runat="server">
            <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Departman Ad" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="Departman adını giriniz."></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Button1_Click" />
            </div>
        </form>
    </div>
</asp:Content>
