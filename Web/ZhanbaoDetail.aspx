<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="ZhanbaoDetail.aspx.cs" Inherits="Web.ZhanbaoDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div style="clear: both; margin-bottom: 30px; overflow: hidden;">
            <div style="width: 100%; margin-top: 15px; border-radius: 3px; padding-top: 10px; overflow: hidden;">
                <div style="padding: 5px; float: left; width: 12%; border-bottom: 2px solid steelblue; overflow: hidden;" onclick="titleClick(1)">
                    <asp:HyperLink ID="kcLink" runat="server" CssClass="ch" Text="战报阅读" NavigateUrl="#" Font-Names="微软雅黑" Font-Size="16" Font-Underline="false"></asp:HyperLink>
                </div>

                <div style="float: left; position: relative; width:100%; padding-top: 10px; height: 29px; border-bottom: 2px solid #e3e3e5; overflow: hidden; font-size: 15px; color: #555555; font-family: 'Microsoft YaHei'; text-align: right;">
                    <div style="position: absolute; right: 5px; bottom: 2px; font-size: 15px; color: #555555; font-family: 'Microsoft YaHei'; text-align: right;">
                        <span>当前位置：</span>
                        <asp:HyperLink ID="HyperLink1" runat="server" Text="首页/" NavigateUrl="~/index.aspx" Font-Underline="false" ForeColor="#555555"></asp:HyperLink>
                        <asp:HyperLink ID="HyperLink3" runat="server" Text="战报资讯/" NavigateUrl="~/Zhanbao.aspx" Font-Underline="false" ForeColor="#555555"></asp:HyperLink>
                        <asp:Label ID="Label2" runat="server" Text="战报阅读" ForeColor="SteelBlue"></asp:Label>
                    </div>
                </div>
            </div>
            <div>
                <div style="margin-top: 10px; font-family: 'Microsoft YaHei';">
                    <div id="left" style="width: 75%; border-right: 2px solid #e3e3e5; float: left; overflow: hidden; margin-right: 0px; margin-bottom: -3000px; padding-bottom: 3000px;">                  
                        <div style="text-align: center; color: #2b2b2b; font-size: 18px;">
                            <asp:Label ID="txtNTitle" runat="server" Text="" ForeColor="#2b2b2b" Font-Size="18"></asp:Label>
                        </div>
                        <div style="text-align: center; padding: 5px; margin-top:10px; font-size: 14px; font-family: 'Microsoft YaHei'; color: #555555;">
                            <span style="padding-right: 10px;">上传时间：
                                <asp:Label ID="txtCreateTime" runat="server" Text=""></asp:Label>
                            </span>                        
                        </div>
                        <div style="line-height:25px; margin-top: 15px; color: #555555; margin-left: 5px; margin-top: 5px;padding:15px; font-size:15px; ">
                            <asp:Literal ID="txtNContent" runat="server"></asp:Literal>
                        </div> 
                        <!--评论-->   
                        <div>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <h2 class="ctd_comments_title">
                                        评论                                       
                                    </h2>
                                    <div>
                                        <div>
                                            <div>                         
                                               <asp:TextBox ID="FCKeditor1" runat="server" TextMode="MultiLine" Height="68px" Width="736px"></asp:TextBox>
                                            </div>
                                            <asp:Button ID="pinglun" runat="server" Text="发布评论" OnClick="pinglun_Click"/>
                                            <span style="display: inline;">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FCKeditor1" ErrorMessage="评论不能为空"></asp:RequiredFieldValidator>
                                            </span>
                                        </div>                    
                                    </div>
                                    <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                                        <ItemTemplate>                        
                                            <div>                                               
                                                <div>
                                                    <a>
                                                        <%#Eval("UserName") %>
                                                    </a>
                                                    <%#Eval("Z_C_Content") %>
                                                </div>
                                                <div>
                                                    <div>
                                                        <div>
                                                            <%#string.Format("{0:yyyy-MM-dd HH:mm}",Eval("Z_C_time")) %>
                                                        </div>
                                                    </div>
                                                    <div>
                                                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="link_reply js_expand_reply" CausesValidation="false" OnClick="LinkButton1_Click">回复<span></span></asp:LinkButton>
                                                    </div>
                                                </div>
                                                <asp:Panel ID="Panel1" runat="server" Visible="false">
                                                    <div>
                                                        <div>
                                                            <div>
                                                                <div>
                                                                    <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("Z_C_Id") %>' />
                                                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("Z_C_Id") %>' Visible="false"></asp:Label>
                                                                    <asp:TextBox ID="Texthuifu" runat="server" TextMode="MultiLine" Width="590px" Height="44px"></asp:TextBox>
                                                                </div>
                                                                <div>                                                                          
                                                                    <asp:Button ID="Button1" runat="server" CssClass="btn_comment js_btn_reply" CausesValidation="false" OnClick="BttLogin_Click" Text="回复" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </asp:Panel> 
                                            </div>
                                            <asp:Repeater ID="Repeater2" runat="server">
                                                <ItemTemplate>
                                                    <div class="e_comment_list js_commentlist">
                                                        <dl class="e_comment_item js_item clrfix">
                                                            <dt class="e_ct_l"></dt>
                                                            <dd class="e_ct_r">
                                                                <div class="bodystr">
                                                                    <a class="author js_user"><%#Eval("aftername") %></a>
                                                                    回复 
                                                                    <a class="author js_user"><%#Eval("beforename") %></a>
                                                                    <%#Eval("Z_R_Content") %>
                                                                </div>
                                                                <div class="opts meta_bottom clrfix">
                                                                    <div class="opts_l clrfix">
                                                                        <div class="c_time">
                                                                            <%#string.Format("{0:yyyy-MM-dd HH:mm}",Eval("Z_R_Time")) %>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </dd>
                                                        </dl>
                                                    </div>
                                                </ItemTemplate>
                                            </asp:Repeater>                                        
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>  
                    </div>                  
                    <div id="right" style="float: left; margin-left: 10px; width: 23%; overflow: hidden; color: #555555; margin-bottom: -3000px; padding-bottom: 3000px;">
                        <div style="border-left: 3px solid #3366cc; padding-left: 5px; font-family: 'Microsoft YaHei'; color: #2b2b2b;">
                            <asp:HyperLink ID="HyperLink5" runat="server" Target="_blank" Text="最新" Font-Size="15" NavigateUrl="~/News.aspx" ForeColor="#2b2b2b" Font-Underline="false"></asp:HyperLink>
                        </div>
                        <div style="margin-top: 10px;">
                            <asp:ListView ID="ElseNewsListView" runat="server">
                                <LayoutTemplate>
                                    <div id="itemPlaceholderContainer" runat="server">
                                        <div id="itemPlaceholder" runat="server"></div>
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
