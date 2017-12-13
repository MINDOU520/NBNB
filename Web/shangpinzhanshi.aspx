<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="Shangpinzhanshi.aspx.cs" Inherits="Web.Shangpinzhanshi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 86%
        }
        .auto-style2 {
            width: 19px;
        }
        .auto-style3 {
            width: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">


        <asp:DataList ID="DataList1" runat="server" Width="1209px" BorderColor="#FF6600">
            <ItemTemplate>
               

                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3" rowspan="6">
                            <asp:image ID="Image1" runat="server" Height="429px" Width="440px"  ImageUrl='<%# Eval("c_photo") %>' NavigateUrl='<%# Eval("c_id") %>' />
                        </td>
                        <td class="auto-style2" rowspan="6">&nbsp;</td>
                        <td>
                             <asp:Label ID="Label1" runat="server" Font-Names="微软雅黑" Font-Size="10pt" Text='<%# Eval("c_name") %>' ForeColor="Gray" NavigateUrl='<%# Eval("c_id") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                           ¥ ：<asp:Label ID="Label2" runat="server" Font-Names="微软雅黑" Font-Size="10pt" Text='<%# Eval("c_price") %>' ForeColor="Gray" NavigateUrl='<%# Eval("c_id") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                             尺寸：<asp:Label ID="Label3" runat="server" Font-Names="微软雅黑" Font-Size="10" Text='<%#Eval("c_size") %>' ForeColor="gray" NavigateUrl='<%# Eval("c_id") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            颜色： <asp:Label ID="Label4" runat="server" Font-Names="微软雅黑" Font-Size="10" Text='<%#Eval("c_color") %>' ForeColor="gray" NavigateUrl='<%# Eval("c_id") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td> 
                          颜色： <asp:Label ID="Label5" runat="server" Font-Names="微软雅黑" Font-Size="10pt" Text='<%# Eval("c_kucun") %>' ForeColor="Gray" NavigateUrl='<%# Eval("c_id") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ImageButton ID="gouwuche" runat="server" Height="60px" Width="160px" ImageUrl="~/img/shangpin/gouwuche.png"/>
                            <asp:ImageButton ID="goumai" runat="server" Height="60px" Width="160px" ImageUrl="~/img/shangpin/goumai.png"/>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NBNBConnectionString %>" SelectCommand="SELECT * FROM [Commodity]"></asp:SqlDataSource>

    </div>
     <div class="container">
         <br />
        
         </div>
</asp:Content>
