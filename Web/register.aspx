<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="loginbg img-responsive">
            <div class="loginbd"> 
                <br />      
                <h2>用户注册</h2>     
                <table style="margin:auto;text-align:center;">                   
                    <tr>
                        <td style="text-align:right">
                            <strong>用&nbsp;&nbsp;户&nbsp;&nbsp;名：</strong>                                
                        </td>
                        <td>
                            <asp:TextBox ID="txtuserName" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtuserName" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp
                        </td>
                        <td>
                            &nbsp
                        </td>
                    </tr>         
                    <tr>
                        <td style="text-align:right">
                            <strong>密&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;码：</strong>
                        </td>
                        <td>
                            <asp:TextBox ID="txtuserPassword" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="txtuserPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp
                        </td>
                        <td>
                            &nbsp
                        </td>
                    </tr>     
                    <tr>
                        <td style="text-align:right">
                            <strong>确认密码：</strong>
                        </td>
                        <td>
                            <asp:TextBox ID="reuserPassword" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="reuserPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp
                        </td>
                        <td>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="不一致" ControlToCompare="txtuserPassword" ControlToValidate="reuserPassword" ForeColor="Red"></asp:CompareValidator>
                        </td>
                    </tr>     
                </table>
                <br />                
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="注册" />
               
               
               
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
               
               
               
            </div>
        </div>
    </div>
</asp:Content>
