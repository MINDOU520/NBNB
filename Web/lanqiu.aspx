<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="lanqiu.aspx.cs" Inherits="Web.lanqiu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" 
            RepeatDirection="Horizontal" >
              <ItemTemplate>
                <table style="padding:20px ;width:100%">
                
                    <tr >
                        <td >
                   
                           <asp:ImageButton ID="photo" runat="server" Width="260px" Height="310px" ImageUrl='<%#Eval("c_photo") %>'  />
                   
                        </td>
                    </tr>
                    <tr>
                        <td  style="text-align:center">
                           <span style="font-size: 9pt"> <%#Eval("c_name")%></span>
                        </td>
                    </tr>
                   <tr>
                        <td style="text-align:center">
                           <span style="font-size: 9pt">¥ <%#DataBinder.Eval(Container.DataItem, "c_price")%></span>
                        </td>
                    </tr>
            
                </table>
                </ItemTemplate>
        </asp:DataList>
   </div> 
   <div class="container">
        <table>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label5" runat="server" Font-Size="9pt" Text="当前页为 [ ">
                </asp:Label><asp:Label ID="Label7" runat="server" Text="1" Font-Size="9pt"></asp:Label>
                <asp:Label ID="Label3" runat="server" Font-Size="9pt" Text=" ]"></asp:Label></td>
            <td style="width: 40px">
                <asp:LinkButton ID="LinkButton2" runat="server" Font-Size="9pt" Font-Underline="False"
                    ForeColor="Red" OnClick="LinkButton2_Click">首页</asp:LinkButton></td>
            <td style="width: 30px">
                <asp:LinkButton ID="LinkButton3" runat="server" Font-Size="9pt" Font-Underline="False"
                    ForeColor="Red" OnClick="LinkButton3_Click" Width="42px">上一页</asp:LinkButton></td>
            <td style="width: 48px">
                <asp:LinkButton ID="LinkButton4" runat="server" Font-Size="9pt" Font-Underline="False"
                    ForeColor="Red" OnClick="LinkButton4_Click" Width="48px">下一页</asp:LinkButton></td>
            <td style="width: 49px">
                <asp:LinkButton ID="LinkButton5" runat="server" Font-Size="9pt" Font-Underline="False"
                    ForeColor="Red" OnClick="LinkButton5_Click" Width="29px">尾页</asp:LinkButton></td>
            <td align="center" style="width: 118px">
                <asp:Label ID="Label10" runat="server" Text="总页为 [ " Font-Size="9pt" Width="52px"></asp:Label>
                <asp:Label ID="Label2" runat="server" Font-Size="9pt"></asp:Label>
                <asp:Label ID="Label4" runat="server" Font-Size="9pt" Text=" ]"></asp:Label></td>
        </tr>
    </table>
    </div>

 
</asp:Content>
