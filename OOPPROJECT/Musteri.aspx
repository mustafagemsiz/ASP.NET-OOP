<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Musteri.aspx.cs" Inherits="OOPPROJECT.Musteri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<div class="container">
    <table class="table table-bordered">
    <thead>
     <tr>
         <th>MUSTERI ID</th>
         <th>MUSTERI AD</th>
         <th>MUSTERI SOYAD</th>
         <th><center>SİL</center></th>
         <th><center>GÜNCELLE</center></th>
     </tr>
  </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
               <ItemTemplate>
            <tr>
                <td><%#Eval("MUSTERIID") %></td>
                <td><%#Eval("MUSTERIAD") %></td>
                <td><%#Eval("MUSTERISOYAD") %></td>
                <td><center><asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/MusteriSil.aspx?MUSTERIID="+Eval("MUSTERIID") %>' runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></center></td>
                <td><center><asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/MusteriGuncelle.aspx?MUSTERIID="+Eval("MUSTERIID") %>' runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></center></td>
            </tr>
            </ItemTemplate>
              </asp:Repeater>
        </tbody>
    </table>

    <a href="MusteriEkle.aspx"> <button class="btn btn-primary">Yeni Müşteri</button> </a>
</div>
    
    

</asp:Content>
