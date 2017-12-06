<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="ZhanbaoDetail.aspx.cs" Inherits="Web.ZhanbaoDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div style="clear: both; margin-bottom: 30px; overflow: hidden;">
        <div style="width: 1080px; margin-top: 15px; border-radius: 3px; padding-top: 10px; overflow: hidden;">
            <div style="padding: 5px; float: left; width: 12%; border-bottom: 2px solid steelblue; overflow: hidden;" onclick="titleClick(1)">
                <asp:HyperLink ID="kcLink" runat="server" CssClass="ch" Text="战报阅读" NavigateUrl="#" Font-Names="微软雅黑" Font-Size="16" Font-Underline="false"></asp:HyperLink>
            </div>

            <div style="float: left; position: relative; width: 91%; padding-top: 10px; height: 29px; border-bottom: 2px solid #e3e3e5; overflow: hidden; font-size: 15px; color: #555555; font-family: 'Microsoft YaHei'; text-align: right;">
                <div style="position: absolute; right: 5px; bottom: 2px; font-size: 15px; color: #555555; font-family: 'Microsoft YaHei'; text-align: right;">
                    当前位置：
                            <asp:HyperLink ID="HyperLink1" runat="server" Text="首页/" NavigateUrl="~/index.aspx" Font-Underline="false" ForeColor="#555555"></asp:HyperLink>
                    <asp:HyperLink ID="HyperLink3" runat="server" Text="战报资讯/" NavigateUrl="~/Zhanbao.aspx" Font-Underline="false" ForeColor="#555555"></asp:HyperLink>
                    <asp:Label ID="Label2" runat="server" Text="战报阅读" ForeColor="SteelBlue"></asp:Label>
                </div>
            </div>
        </div>
        <div>
            <div style="margin-top: 10px; font-family: 'Microsoft YaHei';">
                 <div id="left" style="width: 68%; border-right: 2px solid #e3e3e5; float: left; overflow: hidden; margin-right: 0px; margin-bottom: -3000px; padding-bottom: 3000px;">
                  
                    <div style="text-align: center; color: #2b2b2b; font-size: 18px;">
                        <asp:Label ID="txtNTitle" runat="server" Text="" ForeColor="#2b2b2b" Font-Size="18"></asp:Label>
                    </div>
                    <div style="text-align: center; padding: 5px; margin-top:10px; font-size: 14px; font-family: 'Microsoft YaHei'; color: #555555;">
                        <span style="padding-right: 10px;">上传时间：<asp:Label ID="txtCreateTime" runat="server" Text=""></asp:Label>
                        </span>
                        
                    </div>
                    <div style="  line-height:25px; margin-top: 15px; color: #555555; margin-left: 5px; margin-top: 5px;padding:15px; font-size:15px; ">
                        <asp:Literal ID="txtNContent" runat="server"></asp:Literal>
                    </div>
                
                   </div>
                  

                <div id="right" style="float: left; margin-left: 10px; width: 30%; overflow: hidden; color: #555555; margin-bottom: -3000px; padding-bottom: 3000px;">
                    <div style="border-left: 3px solid #3366cc; padding-left: 5px; font-family: 'Microsoft YaHei'; color: #2b2b2b;">
                        <asp:HyperLink ID="HyperLink5" runat="server" Target="_blank" Text="最新" Font-Size="15" NavigateUrl="~/News.aspx" ForeColor="#2b2b2b" Font-Underline="false">
                        </asp:HyperLink>
                    </div>
                    <div style="margin-top: 10px;">
                        <asp:ListView ID="ElseNewsListView" runat="server">
                            <LayoutTemplate>
                                <div id="itemPlaceholderContainer" runat="server">
                                    <div id="itemPlaceholder" runat="server">
                                    </div>
                                </div>

                            </LayoutTemplate>
                            <ItemTemplate>
                                <div id="elseDiv" runat="server"  style="border-radius: 3px; padding: 10px; clear: both; overflow: hidden;">          
                                    
                                        <asp:HyperLink ID="HyperLink2" runat="server" Text='<%#Eval("z_title") %>' ToolTip='<%#String.Format("{0:yyyy-MM-dd hh:mm}",Eval("z_time"))+"："+Eval("z_title") %>' Font-Names="微软雅黑" ForeColor="#555555" Font-Size="12" Font-Underline="false" NavigateUrl='<%#"~/ZhanbaoDetail.aspx?id="+Eval("z_id") %>' onmouseover="this.style.color='steelblue';this.style.textDecoration='underline';" onmouseout="this.style.color='#555555';this.style.textDecoration='none';"></asp:HyperLink>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>

                </div>

            </div>
        </div>

    </div>

    </div>
 </asp:Content>
