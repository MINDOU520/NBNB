<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="Video.aspx.cs" Inherits="Web.Video" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>最新视频资讯，完美篮球教学</h2>
        <asp:ListView ID="VideoTopListView" runat="server"  GroupItemCount="4">
            <LayoutTemplate>
                <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                    <tr id="groupPlaceholder" runat="server"></tr>
                </table>                          
            </LayoutTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>              
            <ItemTemplate>
                <td runat="server" style="padding:30px;height:100px">
                    <div style="border-radius: 3px; padding: 10px; clear: both; overflow: hidden;">
                        <div style="text-align: center; background-image: url(~/Img/视频.png); width: 200px; height: 150px;">
                            <asp:HyperLink ID="HyperLink1" Visible='<%#System.IO.File.Exists(Server.MapPath(Eval("v_screenImg").ToString())) %>' runat="server" ToolTip='<%#"点击播放："+Eval("v_name") %>' ImageUrl='<%#Eval("v_screenImg")%>' ImageWidth="250" ImageHeight="150" NavigateUrl='<%#"PlayVideo.aspx?id="+Eval("V_Id") %>'></asp:HyperLink>
                            <asp:HyperLink ID="HyperLink3" Visible='<%#!System.IO.File.Exists(Server.MapPath(Eval("v_screenImg").ToString())) %>' runat="server" ToolTip='<%#"点击播放："+Eval("v_name") %>' ImageUrl="~/Img/视频.png" ImageWidth="250" ImageHeight="150" NavigateUrl='<%#"PlayVideo.aspx?id="+Eval("V_Id") %>'></asp:HyperLink>
                        </div>
                        <div style="text-align: center;">
                            <asp:HyperLink ID="HyperLink2" runat="server" Text='<%# Eval("v_name") %>' ToolTip='<%#Eval("v_name")+"上传时间："+string.Format("{0:yyyy-MM-dd hh:mm}",Eval("v_time")) %>' Font-Names="微软雅黑" ForeColor="#555555" Font-Size="12" Font-Underline="false" NavigateUrl='<%#"PlayVideo.aspx?id="+Eval("V_Id") %>'></asp:HyperLink>
                        </div>
                    </div>                    
                </td>
            </ItemTemplate>
        </asp:ListView>       
    </div>
</asp:Content>
