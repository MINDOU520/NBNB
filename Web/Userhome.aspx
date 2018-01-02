<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="Userhome.aspx.cs" Inherits="Web.Userhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/userhome.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container">
        <div class ="um">
            <p style ="font-size:30px;color:rgb(215, 90, 60); ">个人中心</p>
        </div>
        <div class ="zx">
            <ul class="link-list">
			    <li><a href="#"><div class="user4">个人中心</div></a></li>
			    <li><a href="#"><div class="user4">好友</div></a></li>
			    <li><a href="#"><div class="user4">购物车</div></a></li>		
                <li><a href="#"><div class="user4">修改密码</div></a></li>					
		    </ul>
        </div>
        <div class ="userbody">
             <asp:DataList ID="DataList1" runat="server" DataKeyField="UserId">
                 <ItemTemplate>
                     &nbsp;<br />&nbsp;
                     <table class="nav-justified">
                         <tr>
                             <td>头像：</td>
                             <td>
                                 <asp:Label ID="UserTouxiangLabel" runat="server" Text='<%# Eval("UserTouxiang") %>'  NavigateUrl='<%#Eval("UserId") %>'/>
                             </td>
                         </tr>
                         <tr>
                             <td >用户名：</td>
                             <td >
                                 <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>'  NavigateUrl='<%#Eval("UserId") %>'/>
                             </td>
                         </tr>
                            <tr>
                             <td >用户ID：</td>
                             <td >
                                 <asp:Label ID="Label1" runat="server" Text='<%# Eval("UserId") %>'  NavigateUrl='<%#Eval("UserId") %>'/>
                             </td>
                         </tr>
                         <tr>
                             <td>性别：</td>
                             <td>
                                 <asp:Label ID="UserSexLabel" runat="server" Text='<%# Eval("UserSex") %>'  NavigateUrl='<%#Eval("UserId") %>'/>
                             </td>
                         </tr>
                         <tr>
                             <td>生日：</td>
                             <td>
                                 <asp:Label ID="UserBirthdayLabel" runat="server" Text='<%# Eval("UserBirthday") %>'  NavigateUrl='<%#Eval("UserId") %>'/>
                             </td>
                         </tr>
                         <tr>
                             <td>年龄：</td>
                             <td>
                                 <asp:Label ID="UserAgeLabel" runat="server" Text='<%# Eval("UserAge") %>'  NavigateUrl='<%#Eval("UserId") %>'/>
                             </td>
                         </tr>
                         <tr>
                             <td>电话：</td>
                             <td>
                                 <asp:Label ID="UserTplLabel" runat="server" Text='<%# Eval("UserTpl") %>'  NavigateUrl='<%#Eval("UserId") %>'/>
                             </td>
                         </tr>
                         <tr>
                             <td>地址：</td>
                             <td>
                                 <asp:Label ID="UserAdderLabel" runat="server" Text='<%# Eval("UserAdder") %>' NavigateUrl='<%#Eval("UserId") %>' />
                             </td>
                         </tr>
                         <tr>
                             <td>邮箱：</td>
                             <td>
                                 <asp:Label ID="UserEmailLabel" runat="server" Text='<%# Eval("UserEmail") %>' NavigateUrl='<%#Eval("UserId") %>' />
                             </td>
                         </tr>
                         <tr>
                             <td>身高：</td>
                             <td>
                                 <asp:Label ID="UserHeightLabel" runat="server" Text='<%# Eval("UserHeight") %>' NavigateUrl='<%#Eval("UserId") %>' />
                             </td>
                         </tr>
                         <tr>
                             <td>体重：</td>
                             <td>
                                 <asp:Label ID="UserWeightLabel" runat="server" Text='<%# Eval("UserWeight") %>' NavigateUrl='<%#Eval("UserId") %>' />
                             </td>
                         </tr>
                     </table>
                     <br />
                     <br />
                     <br />
                     <br />
                     <br />

                     <br />
           
                     <br />

                     <br />
                     <br />
                 </ItemTemplate>
             </asp:DataList>
             <asp:SqlDataSource ID="NBNB" runat="server" ConnectionString="<%$ ConnectionStrings:NBNBConnectionString %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
        </div>
    </div>
</asp:Content>
