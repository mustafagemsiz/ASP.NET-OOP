<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personel.aspx.cs" Inherits="OOPPROJECT.Personel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  
        <div class="container">
        <table class="table table-bordered">
            <thead>
                <tr>
                <th>PERSONEL ID</th>
                <th>PERSONEL AD</th>
                <th>PERSONEL SOYAD</th>

                <th>PERSONEL DEPARTMAN</th>
                <th>PERSONEL MAAŞ</th>
                </tr>
            </thead>
             <tbody>
                 <asp:Repeater ID="Repeater1" runat="server">
                     <ItemTemplate>
                 <tr>
                     <td><%#Eval("PERSONELID") %></td>
                     <td><%#Eval("PERSONELAD") %></td>
                     <td><%#Eval("PERSONELSOYAD") %></td>
                     <td><%#Eval("DEPARTMAN") %></td>
                     <td><%#Eval("PERSONELMAAS") %></td>
                 </tr>
                         </ItemTemplate>
                 </asp:Repeater>
             </tbody>
        </table>
            <a href="PersonelEkle.aspx"><button class="btn btn-primary">Yeni Personel</button></a>
    </div>
        
</asp:Content>
