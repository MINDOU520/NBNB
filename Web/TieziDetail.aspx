<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="TieziDetail.aspx.cs" Inherits="Web.TieziDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
      <div><a href="Luntan.aspx">返回</a></div>
        <div>
                <table>
                    <tr>
                        <td colspan="6" >
                            <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("t_content") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="2">
                            <asp:ImageButton ID="ImageButton2" runat="server" />
                        </td>
                        <td colspan="2">
                            <asp:ImageButton ID="ImageButton3" runat="server" />
                        </td>
                    </tr>
                </table>
         </div>
    </div>
</asp:Content>
