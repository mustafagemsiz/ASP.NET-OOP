<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelEkle.aspx.cs" Inherits="OOPPROJECT.PersonelEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <div class="container" style="vertical-align:central">
        <form runat="server">
            <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Personel Ad" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="Personel adını giriniz."></asp:TextBox>
            </div>

             <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Personel Soyad" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="Personel soyadını giriniz."></asp:TextBox>
            </div>

            <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Personel Maaşı" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" class="form-control" placeholder="Personel maaşı giriniz."></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>

            <div>
                <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Button1_Click"/>
            </div>
        </form>
    </div>
</asp:Content>
