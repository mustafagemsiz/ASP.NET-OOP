<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SatisEkle.aspx.cs" Inherits="OOPPROJECT.SatisEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
            <div class="container" style="vertical-align:central">
        <form runat="server">
           

             <div class="form-group">
                 <asp:Label ID="Label1" runat="server" Text="Personel Seçiniz." Font-Bold="True"></asp:Label>
            <asp:DropDownList ID="DropDownListPersonel" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Müşteri Seçiniz." Font-Bold="True"></asp:Label>
                <asp:DropDownList ID="DropDownListMusteri" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
             <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Ürün Seçiniz." Font-Bold="True"></asp:Label>
            <asp:DropDownList ID="DropDownListUrun" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Ürün Tutar" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" class="form-control" placeholder="Ürün tutarı giriniz."></asp:TextBox>
            </div>


            <div>
                <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Button1_Click"/>
            </div>
        </form>
    </div>
</asp:Content>
