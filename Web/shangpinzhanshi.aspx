<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="Shangpinzhanshi.aspx.cs" Inherits="Web.Shangpinzhanshi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:DataList ID="DataList1" runat="server" Width="1209px" BorderColor="#FF6600">
            <ItemTemplate>              
                <table>
                    <tr>
                        <td rowspan="6">
                            <asp:image ID="Image1" runat="server" Height="429px" Width="440px"  ImageUrl='<%# Eval("c_photo") %>' NavigateUrl='<%# Eval("c_id") %>' />
                        </td>
                        <td rowspan="6">&nbsp;</td>
                        <td>
                             <asp:Label ID="Label1" runat="server" Font-Names="微软雅黑" Font-Size="10pt" Text='<%# Eval("c_name") %>' ForeColor="Gray" NavigateUrl='<%# Eval("c_id") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span>¥ ：</span>
                            <asp:Label ID="Label2" runat="server" Font-Names="微软雅黑" Font-Size="10pt" Text='<%# Eval("c_price") %>' ForeColor="Gray" NavigateUrl='<%# Eval("c_id") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span>尺寸：</span>
                            <asp:Label ID="Label3" runat="server" Font-Names="微软雅黑" Font-Size="10" Text='<%#Eval("c_size") %>' ForeColor="gray" NavigateUrl='<%# Eval("c_id") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span>颜色：</span> 
                            <asp:Label ID="Label4" runat="server" Font-Names="微软雅黑" Font-Size="10" Text='<%#Eval("c_color") %>' ForeColor="gray" NavigateUrl='<%# Eval("c_id") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td> 
                            <span>库存：</span> 
                            <asp:Label ID="Label5" runat="server" Font-Names="微软雅黑" Font-Size="10pt" Text='<%# Eval("c_kucun") %>' ForeColor="Gray" NavigateUrl='<%# Eval("c_id") %>'></asp:Label>
                        </td>
                        <td> 
                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ImageButton ID="gouwuche" runat="server" Height="60px" Width="160px" ImageUrl="~/img/shangpin/gouwuche.png"/>
                            <asp:ImageButton ID="goumai" runat="server" Height="60px" Width="160px" ImageUrl="~/img/shangpin/goumai.png"/>
                        </td>
                    </tr>
                </table>
                <span>商品详情：</span> 
                              <asp:Label ID="Label6" runat="server" Font-Names="微软雅黑" Font-Size="10pt" Text='<%# Eval("c_content") %>' ForeColor="Gray" NavigateUrl='<%# Eval("c_id") %>'></asp:Label>
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NBNBConnectionString %>" SelectCommand="SELECT * FROM [Commodity]"></asp:SqlDataSource>
    </div>
    <div class="container">
        <br />
         
        </div>
</asp:Content>
