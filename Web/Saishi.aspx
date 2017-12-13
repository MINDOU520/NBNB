<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="Saishi.aspx.cs" Inherits="Web.Saishi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container">
        
            
 <div >
        <asp:DataList ID="DataList1" runat="server" DataKeyField="S_Id" RepeatColumns="4" style="text-align:center;" Width="1156px" >
            <ItemTemplate >
               <table>
                    <tr>
                        <td rowspan="2">
                            <asp:ImageButton ID="ImageButton1" runat="server" Height="45px" Width="45px" ImageUrl='<%#Eval("usertouxiang") %>' postbackUrl='<%#"~/#.aspx?id="+Eval("userid") %>' />
                        </td>
                        <td >
                          <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="微软雅黑" ToolTip='<%#"点击查看："+ Eval("s_name") %>' Font-Size="12" NavigateUrl='<%#"~/#.aspx?id="+Eval("s_id") %>' ForeColor="#2b2b2b" Font-Underline="false" Text='<%#Eval("s_name") %>'></asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="S_FabutimeLabel" runat="server" Text='<%# Eval("S_Fabutime") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>比赛形式：</td>
                        <td>
                            <asp:Label ID="S_NameLabel" runat="server" Text='<%# Eval("S_Name") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td >比赛时间：</td>
                        <td>
                            <asp:Label ID="S_TimeLabel" runat="server" Text='<%# Eval("S_Time") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>比赛地点： </td>
                        <td>
                            <asp:Label ID="S_AdderLabel" runat="server" Text='<%# Eval("S_Adder") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>已参加人数：</td>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                      </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:Button ID="Button1" runat="server" Text="参加" OnClick="Button1_Click" OnClientClick="return confirm('参加成功!')" />
                        </td>
                    </tr>
                </table>
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
        
     </div>
        <div class="container">
        <table>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label5" runat="server" Font-Size="9pt" Text="当前页为 [ ">
                </asp:Label><asp:Label ID="Label7" runat="server" Text="1" Font-Size="9pt"></asp:Label>
                <asp:Label ID="Label3" runat="server" Font-Size="9pt" Text=" ]"></asp:Label></td>
            <td style="width: 40px">
                <asp:LinkButton ID="LinkButton2" runat="server" Font-Size="9pt" Font-Underline="False"
                    ForeColor="Red" OnClick="LinkButton2_Click">首页</asp:LinkButton></td>
            <td style="width: 30px">
                <asp:LinkButton ID="LinkButton3" runat="server" Font-Size="9pt" Font-Underline="False"
                    ForeColor="Red" OnClick="LinkButton3_Click" Width="42px">上一页</asp:LinkButton></td>
            <td style="width: 48px">
                <asp:LinkButton ID="LinkButton4" runat="server" Font-Size="9pt" Font-Underline="False"
                    ForeColor="Red" OnClick="LinkButton4_Click" Width="48px">下一页</asp:LinkButton></td>
            <td style="width: 49px">
                <asp:LinkButton ID="LinkButton5" runat="server" Font-Size="9pt" Font-Underline="False"
                    ForeColor="Red" OnClick="LinkButton5_Click" Width="29px">尾页</asp:LinkButton></td>
            <td style="text-align:center;width: 118px">
                <asp:Label ID="Label10" runat="server" Text="总页为 [ " Font-Size="9pt" Width="52px"></asp:Label>
                <asp:Label ID="Label2" runat="server" Font-Size="9pt"></asp:Label>
                <asp:Label ID="Label4" runat="server" Font-Size="9pt" Text=" ]"></asp:Label></td>
        </tr>
    </table>
    </div>

    </div>
</asp:Content>
