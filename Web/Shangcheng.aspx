<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="Shangcheng.aspx.cs" Inherits="Web.Shangcheng" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" Text="球服" NavigateUrl="#" />
        </div>
        <asp:ListView ID="ListView1" runat="server" GroupItemCount="4">
            <LayoutTemplate>
                <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                    <tr id="groupPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>
            <ItemTemplate>
                <td runat="server" style="padding: 30px; height: 100px">
                    <asp:ImageButton ID="photo" runat="server" Width="260px" Height="310px" ImageUrl='<%#Eval("c_photo") %>' PostBackUrl='<%#"~/shangpinzhanshi.aspx?id="+Eval("c_id") %>' />
                    <div>
                        <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="微软雅黑" ToolTip='<%#"点击查看："+ Eval("c_name") %>' Font-Size="12" NavigateUrl='<%#"~/shangpinzhanshi.aspx?id="+Eval("c_id") %>' ForeColor="#2b2b2b" Font-Underline="false" Text='<%#Eval("c_name") %>'></asp:HyperLink>
                    </div>
                    <div>
                        <span style="font-size: 9pt">¥ <%#DataBinder.Eval(Container.DataItem, "c_price")%></span>
                    </div>
                    </div>                    
                </td>
            </ItemTemplate>
        </asp:ListView>
    </div>
    <div>
        <div>
            <asp:HyperLink ID="HyperLink2" runat="server" Text="球鞋" NavigateUrl="#" />
        </div>
        <asp:ListView ID="ListView2" runat="server" GroupItemCount="4">
            <LayoutTemplate>
                <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                    <tr id="groupPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>
            <ItemTemplate>
                <td runat="server" style="padding: 30px; height: 100px">
                    <asp:ImageButton ID="photo" runat="server" Width="260px" Height="310px" ImageUrl='<%#Eval("c_photo") %>' PostBackUrl='<%#"~/shangpinzhanshi.aspx?id="+Eval("c_id") %>' />
                    <div>
                        <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="微软雅黑" ToolTip='<%#"点击查看："+ Eval("c_name") %>' Font-Size="12" NavigateUrl='<%#"~/shangpinzhanshi.aspx?id="+Eval("c_id") %>' ForeColor="#2b2b2b" Font-Underline="false" Text='<%#Eval("c_name") %>'></asp:HyperLink>
                    </div>
                    <div>
                        <span style="font-size: 9pt">¥ <%#DataBinder.Eval(Container.DataItem, "c_price")%></span>
                    </div>
                    </div>                    
                </td>
            </ItemTemplate>
        </asp:ListView>
    </div>
    <div>
        <div>
            <asp:HyperLink ID="HyperLink3" runat="server" Text="篮球" NavigateUrl="Lanqiu.aspx" />
        </div>
        <asp:ListView ID="ListView3" runat="server" GroupItemCount="4">
            <LayoutTemplate>
                <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                    <tr id="groupPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>
            <ItemTemplate>
                <td runat="server" style="padding: 30px; height: 100px">
                    <asp:ImageButton ID="photo" runat="server" Width="260px" Height="310px" ImageUrl='<%#Eval("c_photo") %>' PostBackUrl='<%#"~/shangpinzhanshi.aspx?id="+Eval("c_id") %>' />
                    <div>
                        <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="微软雅黑" ToolTip='<%#"点击查看："+ Eval("c_name") %>' Font-Size="12" NavigateUrl='<%#"~/shangpinzhanshi.aspx?id="+Eval("c_id") %>' ForeColor="#2b2b2b" Font-Underline="false" Text='<%#Eval("c_name") %>'></asp:HyperLink>
                    </div>
                    <div>
                        <span style="font-size: 9pt">¥ <%#DataBinder.Eval(Container.DataItem, "c_price")%></span>
                    </div>
                    </div>                    
                </td>
            </ItemTemplate>
        </asp:ListView>
    </div>
    <div>
        <div>
            <asp:HyperLink ID="HyperLink4" runat="server" Text="护具" NavigateUrl="#" />
        </div>
        <asp:ListView ID="ListView4" runat="server" GroupItemCount="4">
            <LayoutTemplate>
                <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                    <tr id="groupPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>
            <ItemTemplate>
                <td runat="server" style="padding: 30px; height: 100px">
                    <asp:ImageButton ID="photo" runat="server" Width="260px" Height="310px" ImageUrl='<%#Eval("c_photo") %>' PostBackUrl='<%#"~/shangpinzhanshi.aspx?id="+Eval("c_id") %>' />
                    <div>
                        <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="微软雅黑" ToolTip='<%#"点击查看："+ Eval("c_name") %>' Font-Size="12" NavigateUrl='<%#"~/shangpinzhanshi.aspx?id="+Eval("c_id") %>' ForeColor="#2b2b2b" Font-Underline="false" Text='<%#Eval("c_name") %>'></asp:HyperLink>
                    </div>
                    <div>
                        <span style="font-size: 9pt">¥ <%#DataBinder.Eval(Container.DataItem, "c_price")%></span>
                    </div>
                    </div>                    
                </td>
            </ItemTemplate>
        </asp:ListView>
    </div>
    <div>
        <div>
            <asp:HyperLink ID="HyperLink5" runat="server" Text="其他" NavigateUrl="#" />
        </div>
        <asp:ListView ID="ListView5" runat="server" GroupItemCount="4">
            <LayoutTemplate>
                <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                    <tr id="groupPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>
            <ItemTemplate>
                <td runat="server" style="padding: 30px; height: 100px">
                    <asp:ImageButton ID="photo" runat="server" Width="260px" Height="310px" ImageUrl='<%#Eval("c_photo") %>' PostBackUrl='<%#"~/shangpinzhanshi.aspx?id="+Eval("c_id") %>' />
                    <div>
                        <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="微软雅黑" ToolTip='<%#"点击查看："+ Eval("c_name") %>' Font-Size="12" NavigateUrl='<%#"~/shangpinzhanshi.aspx?id="+Eval("c_id") %>' ForeColor="#2b2b2b" Font-Underline="false" Text='<%#Eval("c_name") %>'></asp:HyperLink>
                    </div>
                    <div>
                        <span style="font-size: 9pt">¥ <%#DataBinder.Eval(Container.DataItem, "c_price")%></span>
                    </div>
                    </div>                    
                </td>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
