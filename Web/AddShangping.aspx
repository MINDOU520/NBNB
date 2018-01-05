<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="AddShangping.aspx.cs" Inherits="Web.AddShangping" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <span>商品名字：</span>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <span>价格：</span>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <span>颜色：</span>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <span>库存：</span>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <span>尺寸：</span>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <span>标识：</span>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <span>图片：</span>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <span>请输入商品详情：</span>
        <ckeditor:ckeditorcontrol id="txtContent" runat="server" basepath="ckeditor/" defaultlanguage="zh-cn" style="width: 100%; height: 660px;"></ckeditor:ckeditorcontrol>
        <asp:Button ID="Button1" runat="server" Text="发布" OnClick="Button1_Click" />
    </div>
</asp:Content>
