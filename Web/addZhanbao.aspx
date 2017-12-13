<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddZhanbao.aspx.cs" Inherits="Web.AddZhanbao" %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
            <h2><p style="margin-left:400px">发布战报</p></h2>
            <h4>
                <p class="text-left">
                请输入战报标题：<asp:TextBox ID="txtTitle" runat="server" Height="30px" Width="400px"></asp:TextBox>
                </p>
            </h4>
            <h4><p>请输入详细的战报内容：</p></h4>
                <CKEditor:CKEditorControl ID="txtContent" runat="server" BasePath="ckeditor/" DefaultLanguage="zh-cn" Width="880" Height="600">
                </CKEditor:CKEditorControl>
           
             <h4>
               <p class="text-center">
                  <asp:Button ID="btnNoticeUp" CssClass="btn btn-primary" runat="server" Text="发  布"  OnClick="btnNoticeUp_Click" />
               </p>
            </h4>
        </div>
    </form>
</body>
</html>
