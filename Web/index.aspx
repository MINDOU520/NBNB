<%@ Page Title="" Language="C#" MasterPageFile="~/NBNB.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <!--首页轮播开始-->
        <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
            <!-- 轮播指标 -->
            <ol class="carousel-indicators">
                <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                <li data-target="#carousel-example-generic" data-slide-to="3"></li>
            </ol>
            <!-- 轮播项目 -->
            <div class="carousel-inner" role="listbox">
                <div class="item active">
                    <img src="img/1.jpg" alt="First slide"/>
                    <div class="carousel-caption">
                        <h3>韦德</h3>
                        <p>闪电侠</p>
                    </div>
                </div>
                <div class="item">
                    <img src="img/2.jpg" alt="Second slide"/>
                    <div class="carousel-caption">
                        <h3>詹姆斯</h3>
                        <p>小皇帝</p>
                    </div>
                </div>
                <div class="item">
                    <img src="img/3.jpg" alt="Third slide"/>
                    <div class="carousel-caption">
                        <h3>科比</h3>
                        <p>小飞侠</p>
                    </div>
                </div>
                <div class="item">
                    <img src="img/4.jpg" alt="fourth slide"/>
                    <div class="carousel-caption">
                        <h3>加内特</h3>
                        <p>狼王</p>
                    </div>
                </div>
            </div>
            <!-- 轮播导航 -->
            <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev"><span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span><span class="sr-only">Previous</span></a>
            <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next"><span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span><span class="sr-only">Next</span></a>
        </div>
        <!--首页轮播结束-->
    </div>

    <!--首页实时战报开始-->
    <div id="">
        zhanbao 
    </div>
    <!--首页实时战报结束-->

    <!--jiaoxue-->
    jiaoxue
    <!--jiaoxue-->
</asp:Content>
