<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="AddSaishi.aspx.cs" Inherits="Web.AddSaishi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div style="text-align:center;">
            <h2>赛事发布</h2>
            <br /> 
            <br /> 
            <table style="margin:0 auto;">
                <tr>
                    <td style="text-align: right">比赛类型：</td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server" CssClass="form-control;" placeholder="请输入比赛类型"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" Display="Dynamic" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: right">比赛时间：</td>
                    <td>
                        <asp:TextBox ID="txttime" runat="server" CssClass="form-control;" placeholder="请输入比赛时间"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txttime" Display="Dynamic" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: right">比赛地点：</td>
                    <td>
                        <asp:TextBox ID="txtadder" runat="server" CssClass="form-control;" placeholder="请输入比赛地点"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtadder" Display="Dynamic" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: right"></td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>          
            </table>                                            
            <span><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="发布" CssClass="btn btn-primary btn-lg" /></span>
            <span><asp:Label ID="Label2" runat="server" Text=""></asp:Label></span>
        </div>
    </div>
</asp:Content>
