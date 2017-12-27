<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="AddTiezi.aspx.cs" Inherits="Web.AddTiezi" %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>发布帖子
         <CKEditor:CKEditorControl ID="txtContent" runat="server" BasePath="ckeditor/" DefaultLanguage="zh-cn" Width="880" Height="600">
                </CKEditor:CKEditorControl>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="发布" />
    </div>
</asp:Content>
