<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="AddTiezi.aspx.cs" Inherits="Web.AddTiezi" %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div style="text-align:center">
            <h2>发布帖子</h2>       
            <div style="margin:0 auto;">
                 <CKEditor:CKEditorControl ID="txtContent" runat="server" BasePath="ckeditor/" DefaultLanguage="zh-cn"  style="width:100%;height:660px;"></CKEditor:CKEditorControl>
            </div>
            <div style="margin:0 auto;">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="发布" />
            </div>
        </div>
    </div>
</asp:Content>
