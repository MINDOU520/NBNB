<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="Luntan.aspx.cs" Inherits="Web.Luntan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 82px;
        }
        .auto-style2 {
            height: 25px;
        }
        .auto-style3 {
            width: 25px
        }
        .auto-style4 {
            height: 25px;
            width: 100px;
        }
        .auto-style5 {
            width: 100px;
            height: 27px;
        }
        .auto-style6 {
            height: 27px;
        }
        .auto-style7 {
            margin-left: 2px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div></div>
     <div class="container">
        <h3 >
              <span>帖子
              </span>   <asp:HyperLink    runat="server"  Text="更多..." NavigateUrl="#" ></asp:HyperLink>
              <asp:Button ID="Button1" runat="server" Text="刷新" />
          </h3> 
        <div id="tiezi">
        
            <asp:DataList ID="DataList1" runat="server" Width="1194px" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3" rowspan="2">
                                <asp:ImageButton ID="ImageButton1" runat="server" Height="57px" Width="58px" ImageUrl='<%#"Userhome?id="+ Eval("UserId") %>'/>
                            </td>
                            <td class="auto-style4" colspan="2">
                                <asp:HyperLink ID="HyperLink4" runat="server" Text='<%#"Userhome?id="+Eval("UserId") %>'></asp:HyperLink>
                            </td>
                            <td class="auto-style2" colspan="2"></td>
                            <td class="auto-style2" style="text-align: right">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5" colspan="2">
                                <asp:Label ID="Label1" runat="server" Text='<%# string.Format("{0:yyyy-MM-dd hh:mm}",Eval("t_time")) %>'></asp:Label>
                            </td>
                            <td class="auto-style6" colspan="2"></td>
                            <td class="auto-style6"></td>
                        </tr>
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
                </ItemTemplate>
            </asp:DataList>
        
         
        
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NBNBConnectionString %>" SelectCommand="SELECT [T_Id], [UserId], [T_Time], [T_Content] FROM [Tiezi]"></asp:SqlDataSource>
        
         
        
        </div>
   </div>
     
   <div class="container">
        <h3 >
            <span>视频信息</span>
            <asp:HyperLink  CssClass="more" ID="videomore"  runat="server"  Text="更多..." NavigateUrl="Videos.aspx" ></asp:HyperLink>
           
        </h3>
            <asp:ListView ID="VideoTopListView" runat="server"  GroupItemCount="4">
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
                  <td runat="server" style="padding:30px;height:100px">
                      <div style="border-radius: 3px; padding: 10px; clear: both; overflow: hidden;">
                            <div style="text-align: center; background-image: url(~/Img/视频.png); width: 200px; height: 150px;">
                                <asp:HyperLink ID="HyperLink1" Visible='<%#System.IO.File.Exists(Server.MapPath(Eval("v_screenImg").ToString())) %>' runat="server" ToolTip='<%#"点击播放："+Eval("v_name") %>' ImageUrl='<%#Eval("v_screenImg")%>' ImageWidth="250" ImageHeight="150" NavigateUrl='<%#"~/PlayVideo.aspx?id="+Eval("V_Id") %>'></asp:HyperLink>
                                 <asp:HyperLink ID="HyperLink3" Visible='<%#!System.IO.File.Exists(Server.MapPath(Eval("v_screenImg").ToString())) %>' runat="server" ToolTip='<%#"点击播放："+Eval("v_name") %>' ImageUrl="~/Img/视频.png" ImageWidth="250" ImageHeight="150" NavigateUrl='<%#"~/PlayVideo.aspx?id="+Eval("V_Id") %>'></asp:HyperLink>
                            </div>
                            <div style="text-align: center;">
                              <asp:HyperLink ID="HyperLink2" runat="server" Text='<%# Eval("v_name") %>' ToolTip='<%#Eval("v_name")+"上传时间："+string.Format("{0:yyyy-MM-dd hh:mm}",Eval("v_time")) %>' Font-Names="微软雅黑" ForeColor="#555555" Font-Size="12" Font-Underline="false" NavigateUrl='<%#"~/PlayVideo.aspx?id="+Eval("V_Id") %>'></asp:HyperLink>
                            </div>
                        </div>                    
                  </td>
              </ItemTemplate>
            </asp:ListView>       
        </div>
</asp:Content>
