<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="AddVideo.aspx.cs" Inherits="Web.AddVideo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table>
            <tr>
                <td>视频名称：</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control;" placeholder="请输入视频名称"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>视频封面：</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>视频文件：</td>
                <td>
                    <asp:FileUpload ID="FileUpload2" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="发布" CssClass="btn btn-primary btn-lg" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
