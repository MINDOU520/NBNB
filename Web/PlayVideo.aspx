<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayVideo.aspx.cs" Inherits="Web.PlayVideo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title></title>

    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />   
    
    <style>
        /*用户头像*/
        .userphoto{
            display :block;
            width:50px;
            height:50px;
            border:1px solid rgb(215, 90, 60); 
            position:fixed;
            right:80px;
            top:25px;
            text-align:center;
            border-radius:25px;       
            z-index:9999;     
        }
        .upo{
            box-sizing:border-box;
            position:relative;
            top:7px;
            /*left:17px;*/
            width:16px;
            height:16px;
            background-color:rgb(215, 90, 60); 
            border-radius:8px;
            margin:0 auto;
        }
        .uph{
            content:"";
            position:absolute;
            top:24px;
            left:10px;
            width:28px;
            height:14px;
            background-color:rgb(215, 90, 60); 
            border-top-left-radius:14px;
            border-top-right-radius:14px;
        }
      /* 返回顶部 */
    .backtop {
        height: 50px;
        width: 50px;

        position: fixed;
        bottom: 55px;
        right: -80px;
        z-index: 9999;

        transition: all 1s ease;
        -moz-transition: all 1s ease;
        -webkit-transition: all 1s ease;
        -o-transition: all 1s ease;

        border: 1px solid #ddd;
        background-color: rgb(215, 90, 60);
        border-radius: 10px;
        box-shadow: 0px 0px 2px #ddd;

        /* 使子元素所有方向上居中 */
        display: flex;
        justify-content: center;
        align-items: center;
        cursor:pointer;
    }

    /* 图标 */
    .backtop .icon {
        height: 16px;
        width: 16px;
        border-top: 1px solid #278;
        border-left: 1px solid #279;
        margin-top: 8px; 
        transform: rotate(45deg);
    }

    /* 激活状态 */
    .shang {
        right: 80px;
        -moz-transform: scale(1) rotate(-360deg) translate(0px);
        -webkit-transform: scale(1) rotate(-360deg) translate(0px);
        -o-transform: scale(1) rotate(-360deg) translate(0px);
        transform: scale(1) rotate(-360deg) translate(0px);
    }
    </style>

    <script src="scripts/jquery-3.2.1.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="js/drop-down.js"></script>

    <script runat="server">
        void Page_LoadComplete(Object sender, EventArgs e)
        {
            ScriptManager1.RegisterPostBackControl(videoDLImgBtn);
        }
    </script>
    <style type="text/css">
        .ch {
            color: #2B2B2B;
        }

        .ch2 {
            color: gray;
        }

        .en {
            color: #555555;
        }

        .ch:hover {
            color: steelblue;
        }

        .ch2:hover {
            color: steelblue;
        }

        .en:hover {
            color: #3366cc;
        }
    </style>
    <script type="text/javascript">
        function setVideo() {
           <%-- var vdhf = document.getElementById('<%=VDHF.ClientID%>');--%>
            var vdhf = document.getElementById("VDHF");
            var vid = document.getElementById("vid");
            vid.src = vdhf.value;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <header>			
			<div class="navbar navbar-default navbar-static-top" style=" background-color:beige;">
				<div class="container">
					<div class="navbar-header">
						<button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
					    <a class="navbar-brand" href="Index.aspx"><img src="img/logo.png" alt="" width="199" height="52" /></a>
					</div>
					<div class="navbar-collapse collapse ">
						<ul class="nav navbar-nav">
                            <li role="presentation" class="dropdown">
                                <a class="dropdown-toggle" data-toggle="dropdown" href="#" aria-haspopup="true" aria-expanded="false">
                                    <span class="glyphicon glyphicon-glass" style="color: rgb(215, 90, 60);font-size: 18px;"> 参赛</span>
                                </a>                            
                                <ul class="dropdown-menu">  
                                    <li><a href="Saishi.aspx">赛事</a></li>
                                    <li><a href="Addsaishi.aspx">发布</a></li>
                                </ul>
                            </li>
                            <li role="presentation" class="dropdown">
                                <a href="Zhanbao.aspx" class="dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                    <span class="glyphicon glyphicon-th-list" style="color: rgb(215, 90, 60);font-size: 18px;"> 战报</span>
                                </a>
                                <%--<ul class="dropdown-menu">
                                    <li><a href="#">NBA战报</a></li>
                                    <li><a href="#">CBA战报</a></li>
                                    <li><a href="#">本站战报</a></li>
                                </ul>--%>
                            </li>
                            <li role="presentation" class="dropdown">
                                <a class="dropdown-toggle" data-toggle="dropdown" href="#" aria-haspopup="true" aria-expanded="false">
                                    <span class="glyphicon glyphicon-comment" style="color: rgb(215, 90, 60);font-size: 18px;"> 论坛</span>
                                </a>
                                <ul class="dropdown-menu">
                                       <li><a href="AddTiezi.aspx">我要发帖</a></li>
                                    <li><a href="Luntan.aspx">社区讨论</a></li>
                                    <li><a href="Video.aspx">视频集合</a></li>
                                   <%-- <li><a href="#">二手交易</a></li>--%>
                                </ul>
                            </li>													
							<li role="presentation" class="dropdown">
                                <a href="Shangcheng.aspx" class="dropdown-toggle" data-toggle="dropdown"  aria-haspopup="true" aria-expanded="false">
                                    <span class="glyphicon glyphicon-shopping-cart" style="color: rgb(215, 90, 60);font-size: 18px;"> 商城</span>

                                </a>
                                <%--<ul class="dropdown-menu">
                                    <li><a href="#">球服</a></li>
                                    <li><a href="#">球鞋</a></li>
                                    <li><a href="Lanqiu.aspx">篮球</a></li>
                                    <li><a href="#">护具</a></li>
                                    <li><a href="#">其他</a></li>
                                </ul>--%>
							</li>
                            <li><a href="Login.aspx"><span class="glyphicon glyphicon-user" style="color: rgb(215, 90, 60);font-size: 18px;"> 登录</span></a></li>
							<%--<li><a href="#"><span class="glyphicon glyphicon-search" style="color: rgb(215, 90, 60);font-size: 18px;"> 搜索</span></a></li>--%>
						</ul>
                        <script>
                            $().dropdown('toggle');                            
                        </script>
					</div>
				</div>
			</div>           
			<div class="container">
                <div class="navbar-form navbar-right" role="search">
                    <div class="form-group">
                        <input type="text" class="form-control" placeholder="搜索"/>
                    </div>
                    <button type="submit" class="btn btn-default glyphicon glyphicon-search" style="color: rgb(215, 90, 60);"></button>
                </div>
            </div>           
		</header>
        <div class="container">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div style="clear: both; margin-bottom: 30px; overflow: hidden;">
                        <div style="width: 1080px; margin-top: 15px; border-radius: 3px; padding-top: 10px; overflow: hidden;">
                            <div style="padding: 5px; float: left; width: 8%; border-bottom: 2px solid steelblue; overflow: hidden;" onclick="titleClick(1)">
                                <asp:HyperLink ID="kcLink" runat="server" CssClass="ch" Text="视频播放" NavigateUrl="index.aspx" Font-Names="微软雅黑" Font-Size="16" Font-Underline="false"></asp:HyperLink>
                            </div>               
                        </div>                
                        <div style="margin-top: 10px; font-family: 'Microsoft YaHei';">
                            <div id="left" style="width: 68%; border-right: 2px solid #e3e3e5; float: left; overflow: hidden; margin-right: 0px; margin-bottom:-3000px; padding-bottom:3000px;">
                                <div style="text-align: center; color: #2b2b2b; font-size: 18px;">
                                    <asp:Label ID="txtTitle" runat="server" Text='<%#Eval("v_name") %>' ForeColor="#2b2b2b" Font-Size="18"></asp:Label>
                                </div>
                                <div style="text-align: center; padding: 5px; font-size: 14px; font-family: 'Microsoft YaHei'; color: #555555;">
                                    <span style="padding-right: 10px;">
                                        上传时间：
                                        <asp:Label ID="txtCreateTime" runat="server" Text=""></asp:Label>
                                    </span>
                                    <span style="border-left: 2px solid #cccccc; padding-left: 10px; padding-right: 10px;">
                                        点击量：
                                        <asp:Label ID="txtClickNum" runat="server" Text="0"></asp:Label>
                                    </span>
                                    <span style="border-left: 2px solid #cccccc; padding-left: 10px; padding-right: 10px;">
                                        下载量：
                                        <asp:Label ID="txtDownLoadNum" runat="server" Text="0"></asp:Label>
                                    </span>
                                    <span style="border-left: 2px solid #cccccc; padding-left: 10px; position: relative;">
                                        <asp:ImageButton ID="videoDLImgBtn" OnClick="videoDLImgBtn_Click" runat="server" ToolTip="下载此作品" ImageUrl="~/img/download.png" Width="20" Height="20" />
                                        <span style="position: absolute; left: 35px; bottom: 0px;">
                                            <asp:Image ID="Image1" runat="server" ImageUrl="~/img/download_pronpt.png" />
                                        </span>
                                    </span>
                                </div>
                                <div style="text-align: center; margin-top: 15px;">
                                    <video id="vid"   autoplay="autoplay"  controls="controls"   preload="none"  height="350" width="600" ></video>                          
                                    <asp:HiddenField ID="VDHF" runat="server" />                        
                                </div>                                               
                            </div>
                            <div id="right" style="float: left; margin-left: 10px; width: 28%; overflow: hidden; color: #555555;">
                                <div style="border-left: 3px solid #3366cc; padding-left: 5px; font-family: 'Microsoft YaHei'; color: #2b2b2b;"></div>
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <script>
                setVideo();
            </script>
        </div>
        <footer>           
			<div class="container">
				<div class="row">
					<div class="col-sm-3 col-lg-3">
						<div class="widget">
							<h4>联系我们</h4>
							<strong>商软四巨头</strong>
                            <br/>
                            <p>强无敌！！！</p> 
                            <br />
                            <img src="img/erweima.png" width="80" height="80" />
						</div>
					</div>
					<div class="col-sm-3 col-lg-3">
						<div class="widget">
							<h4>团队成员</h4>
							<ul class="link-list">
								<li><a href="#">朱敏</a></li>
								<li><a href="#">刘万明</a></li>
								<li><a href="#">谭梓毅</a></li>		
                                <li><a href="#">李江辉</a></li>					
							</ul>
						</div>
					</div>
					<div class="col-sm-3 col-lg-3">
						<div class="widget">
							<h4>友情链接</h4>
							<ul class="link-list">
								<li><a href="https://www.zhibo8.cc/" target="_blank">直播吧</a></li>
								<li><a href="https://nba.hupu.com/" target="_blank">虎扑体育</a></li>
								<li><a href="http://sports.qq.com/nba/" target="_blank">腾讯NBA</a></li>
                                <li><a href="http://sports.sina.com.cn/" target="_blank">新浪NBA</a></li>
							</ul>
						</div>
					</div>
					<div class="col-sm-3 col-lg-3">
						<div class="widget">
							<h4>意见和反馈</h4>
							<p>写下你想对我们说的：</p>
							<div class="form-group multiple-form-group input-group">
								<input type="text" name="return" class="form-control"/>
								<span class="input-group-btn">
                                    <button type="button" class="btn btn-theme btn-add">发送</button>
                                </span>
							</div>
						</div>
					</div>
				</div>
			</div>
			<div id="sub-footer" style="text-align:center ; background-color:beige;">
				<div class="container" style="text-align:center">
					<div class="row" style="text-align:center">						
					    <div  style="text-align:center">
						 <p><strong>&copy; CopyRight  朱敏  刘万明  谭梓毅  2017<br />版权所有，仿冒必究！</strong></p>								
						</div>							
					</div>
				</div>
			</div>             
		</footer>
        <!--end footer-->

        <!--user-->
        <a href="userhome.aspx">
            <div class ="userphoto">
                <div class ="upo"></div>
                <div class ="uph"></div>
            </div>
        </a>

        <!--back to top-->
            <div class="backtop"><i class="icon"></i></div>
            <script src="js/backtop.js"></script>
    </form>
</body>
</html>

