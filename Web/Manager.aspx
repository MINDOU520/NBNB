<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="Manager.aspx.cs" Inherits="Web.Manager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
            <div style="text-align:center">
                <div style="margin-top:20px;margin-bottom:20px;">
                    <a href="AddZhanbao.aspx">                                            
                        <input name="发布战报" type="button" class="btn btn-primary btn-lg" value="发布战报" />
                    </a>
                </div>
                <div style="margin-top:20px;margin-bottom:20px;">
                    <a href="AddTiezi.aspx">                       
                        <input name="发布帖子" type="button" class="btn btn-primary btn-lg" value="发布帖子" />
                    </a>
                </div>
                <div style="margin-top:20px;margin-bottom:20px;">
                    <a href="AddSaishi.aspx">                    
                        <input name="发布赛事" type="button" class="btn btn-primary btn-lg" value="发布赛事" />
                </a>
            </div>
            <div style="margin-top:20px;margin-bottom:20px;">
                <a href="AddVideo.aspx">                    
                    <input name="发布视频" type="button" class="btn btn-primary btn-lg" value="发布视频" />
                </a>
            </div>
        </div>
    </div>
</asp:Content>
