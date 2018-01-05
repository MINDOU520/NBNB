<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="Luntan.aspx.cs" Inherits="Web.Luntan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h3 >
            <span>帖子</span>   
            <asp:HyperLink    runat="server"  Text="更多..." NavigateUrl="#" ></asp:HyperLink>
            <asp:Button ID="Button1" runat="server" Text="刷新" />
        </h3>       
    </div>
    <div class="container">
        <asp:ListView ID="TieziListView" runat="server"  GroupItemCount="4">
            <LayoutTemplate>
                <div>
                <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                    <tr id="groupPlaceholder" runat="server"></tr>
                </table>  
                </div>
                <div style="width: 100%; margin-top: 20px; text-align:center; background-color: #ececec;">
                            <asp:DataPager ID="DataPager1"  runat="server" PageSize="8">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="true" ShowNextPageButton="false" ShowPreviousPageButton="true" FirstPageText="首页" NextPageText="下一页" PreviousPageText="上一页" LastPageText="尾页" />
                                    <asp:NumericPagerField ButtonCount="5" CurrentPageLabelCssClass="current" />
                                    <asp:NextPreviousPagerField ButtonType="Link" ShowLastPageButton="True" ShowNextPageButton="true" NextPageText="下一页" PreviousPageText="上一页"  ShowPreviousPageButton="false" FirstPageText="首页" LastPageText="尾页" />
                                </Fields>
                            </asp:DataPager>
                        </div>                      
            </LayoutTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>              
            <ItemTemplate>
                <table>
                    <tr>
                        <td rowspan="2">
                            <asp:Image ID="Image1" runat="server" Height="57px" Width="58px" ImageUrl='<%# Eval("usertouxiang") %>'/>
                        </td>
                        <td colspan="2">
                            <asp:HyperLink ID="HyperLink4" runat="server" Text='<%# Eval("username") %>'></asp:HyperLink>
                        </td>
                        <td colspan="2"></td>
                        <td style="text-align: right"></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="Label1" runat="server" Text='<%# string.Format("{0:yyyy-MM-dd hh:mm}",Eval("t_time")) %>'></asp:Label>
                        </td>
                        <td colspan="2"></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td colspan="6" >
                            <asp:HyperLink ID="HyperLink1" runat="server" Height="57px" Width="58px" NavigateUrl='<%#"~/TieziDetail.aspx?id="+Eval("t_id") %>' Text='<%# Eval("t_content") %>'></asp:HyperLink>
                            
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
            </ItemTemplate>
        </asp:ListView>       
    </div>
</asp:Content>
