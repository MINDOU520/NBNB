<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Web.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/index.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <!--首页轮播开始-->
        <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
            <!-- 轮播指标 -->
            <ol class="carousel-indicators">
                <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                <li data-target="#carousel-example-generic" data-slide-to="3"></li>
            </ol>
            <!-- 轮播项目 -->
            <div class="carousel-inner" role="listbox">
                <div class="item active">
                    <img src="img/1.jpg" alt="First slide"/>
                    <div class="carousel-caption">
                        <h3>韦德</h3>
                        <p>闪电侠</p>
                    </div>
                </div>
                <div class="item">
                    <img src="img/2.jpg" alt="Second slide"/>
                    <div class="carousel-caption">
                        <h3>詹姆斯</h3>
                        <p>小皇帝</p>
                    </div>
                </div>
                <div class="item">
                    <img src="img/3.jpg" alt="Third slide"/>
                    <div class="carousel-caption">
                        <h3>科比</h3>
                        <p>小飞侠</p>
                    </div>
                </div>
                <div class="item">
                    <img src="img/4.jpg" alt="fourth slide"/>
                    <div class="carousel-caption">
                        <h3>加内特</h3>
                        <p>狼王</p>
                    </div>
                </div>
            </div>
            <!-- 轮播导航 -->
            <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev"><span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span><span class="sr-only">Previous</span></a>
            <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next"><span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span><span class="sr-only">Next</span></a>
        </div>
        <!--首页轮播结束-->
    </div>

    <!--首页实时战报开始-->
    <div class="container">
        <h3 >
              <span>战报资讯
              </span>   <asp:HyperLink    runat="server"  Text="更多..." NavigateUrl="#" ></asp:HyperLink>
          </h3> 
        
        <div id="zhaobao">
        <asp:Repeater ID="Repeater1" runat="server">
          <ItemTemplate>
                  <table style="width:580px">
                    <tr >
                        <td  style="text-align:left;font-size:14px;line-height:130px;">
                            <asp:HyperLink ID="hp1"  runat="server"  Text='<%#Eval("z_title") %> ' NavigateUrl='<%# "ZhanbaoDetail.aspx?id="+Eval("z_id") %>' ></asp:HyperLink>
                        </td>
                        <td  style="text-align:right;font-size:14px">
                             <span><%# string.Format("{0:yyyy-MM-dd}",Eval("z_time"))%></span>
                        </td>
                    </tr>                              
                </table>
              </ItemTemplate>
              </asp:Repeater>
        </div>
    </div>
    <!--首页实时战报结束-->
    <!--官方消息-->

    <div class="container">
        <div class="xian"></div>
    </div>

    <!--jiaoxue-->
 <%--   视频--%>
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
    <!--jiaoxue-->
</asp:Content>
