<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Departman.aspx.cs" Inherits="OOPPROJECT.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="container">
      <table class="table table-bordered">
            <thead>
                <tr>
                   <th>DEPARTMAN ID</th>
                   <th>DEPARTMAN AD</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                     <ItemTemplate>
                         <tr>
                             <td>
                                 <%#Eval("DEPARTMANID")%>
                             </td>
                             <td>
                                 <%#Eval("DEPARTMANAD") %>
                             </td>
                         </tr>
                     </ItemTemplate>
                </asp:Repeater>
            </tbody>
    </table>
        <a href="DepartmanEkle.aspx"> <button class="btn btn-primary">Yeni Departman</button> </a>
        </div>
</asp:Content>
