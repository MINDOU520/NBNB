<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="Luntan.aspx.cs" Inherits="Web.Luntan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 82px;
        }
        .auto-style2 {
            height: 25px;
        }
        .auto-style3 {
            width: 25px
        }
        .auto-style4 {
            height: 25px;
            width: 100px;
        }
        .auto-style5 {
            width: 100px;
            height: 27px;
        }
        .auto-style6 {
            height: 27px;
        }
        .auto-style7 {
            margin-left: 2px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div></div>
     <div class="container">
        <h3 >
              <span>帖子
              </span>   <asp:HyperLink    runat="server"  Text="更多..." NavigateUrl="#" ></asp:HyperLink>
              <asp:Button ID="Button1" runat="server" Text="刷新" />
          </h3> 
       
   </div>
    <div>
            <asp:ListView ID="TieziListView" runat="server"  GroupItemCount="4">
              <LayoutTemplate>
                    <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                        <tr id="groupPlaceholder" runat="server">
                        </tr>
                    </table>                          
              </LayoutTemplate>
              <GroupTemplate>
                  <tr id="itemPlaceholderContainer" runat="server">
                      <td id="itemPlaceholder" runat="server"></td>
                  </tr>
              </GroupTemplate>              
              <ItemTemplate>
                  <table class="auto-style1">
                        <tr>
                            <td class="auto-style3" rowspan="2">
                                <asp:ImageButton ID="ImageButton1" runat="server" Height="57px" Width="58px" ImageUrl='<%#"Userhome?id="+ Eval("UserId") %>'/>
                            </td>
                            <td class="auto-style4" colspan="2">
                                <asp:HyperLink ID="HyperLink4" runat="server" Text='<%#"Userhome?id="+Eval("UserId") %>'></asp:HyperLink>
                            </td>
                            <td class="auto-style2" colspan="2"></td>
                            <td class="auto-style2" style="text-align: right">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5" colspan="2">
                                <asp:Label ID="Label1" runat="server" Text='<%# string.Format("{0:yyyy-MM-dd hh:mm}",Eval("t_time")) %>'></asp:Label>
                            </td>
                            <td class="auto-style6" colspan="2"></td>
                            <td class="auto-style6"></td>
                        </tr>
                        <tr>
                            <td colspan="6" >
                                <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("t_content") %>'></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">&nbsp;</td>
                            <td colspan="2">
                                <asp:ImageButton ID="ImageButton2" runat="server" />
                            </td>
                            <td colspan="2">
                                <asp:ImageButton ID="ImageButton3" runat="server" />
                            </td>
                        </tr>
              </ItemTemplate>
            </asp:ListView>       
</div>
</asp:Content>
