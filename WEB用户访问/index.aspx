<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WEB用户访问.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>欢迎进入酒店预订管理系统!</title>
<!--
Neaty HTML Template
http://www.templatemo.com/tm-501-neaty
-->
    <!-- load stylesheets -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:300,400">  <!-- Google web font "Open Sans" -->
    <link rel="stylesheet" href="css/bootstrap.min.css">                                      <!-- Bootstrap style -->
    <link rel="stylesheet" href="css/magnific-popup.css">                                <!-- Magnific pop up style, http://dimsemenov.com/plugins/magnific-popup/ -->
    <link rel="stylesheet" href="css/templatemo-style.css">                                   <!-- Templatemo style -->

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
        <!--[if lt IE 9]>
          <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
          <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
          <![endif]-->
</head>
    <body>        
        <div class="container">
            <div class="row">
                <div class="tm-left-right-container">
                    <!-- Left column: logo and menu -->
                    <div class="tm-blue-bg tm-left-column">                        
                        <div class="tm-logo-div text-xs-center">
							<!-- 左上角的图标 -->
                            <img src="images/tm-neaty-logo.png" title="Logo">
                            <h1 class="tm-site-name">酒店预订系统</h1>
                            
                        </div>
                        <nav class="tm-main-nav">
                            <ul class="tm-main-nav-ul">
                                <li class="tm-nav-item">
                                    <a href="#welcome" class="tm-nav-item-link">客房预定</a>
                                </li>
                                
								<li class="tm-nav-item">
                                    <a href="#galleryone" class="tm-nav-item-link">已定房间</a>
                                </li>
                                <li class="tm-nav-item">
                                    <a href="#myroom" class="tm-nav-item-link">我的房间</a>
                                </li>
                                <li class="tm-nav-item">
                                    <a href="#contact" class="tm-nav-item-link">我的信息</a>
                                </li>
								
                            </ul>
                        </nav>                                         
                    </div> <!-- Left column: logo and menu -->
                    
                    <!-- Right column: content -->
                    <div class="tm-right-column">
                        <!-- 顶部用户信息 -->
                        <span style="float:right">欢迎用户<%Context.Response.Write(Request.Cookies["login_name"].Value); %>[<a href="login.aspx" onclick='delCookie("login_name")'>退出</a>]</span>
                        <div class="tm-content-div">
                            <!-- Welcome section -->
                            <section id="welcome" class="tm-section">
                                <header>
                                    <h2 class="tm-blue-text tm-welcome-title tm-margin-b-45">欢迎进入酒店客房预订系统！</h2>
                                </header>
                                <p>注：预定的房间请于明天入住并交予押金，否则将清空您的预订信息</p>
                            </section>
                            <!-- About section -->
                            <section id="about" class="tm-section">
                                <div class="row">                                                                
                                    <div class="col-lg-8 col-md-7 col-sm-12 col-xs-12 push-lg-4 push-md-5">
                                        <header>
                                            <h2 class="tm-blue-text tm-section-title tm-margin-b-45">预订您的房间</h2>
                                        </header>
                                       <!--
                                       这里插入房间的详细信息
                                       
                                       -->
                                       <form method="post" action="UserService.ashx">                                       
                                       <table width="100%" border="1px">
                                            <tr><th>房间号</th><th>房间类型</th><th>房间价格</th><th>房间状态</th><th>房间说明</th><th>是否预订</th></tr>
                                       <%
                                            System.Data.DataSet ds = 数据访问与类库.DBHelper.ExecuteQuery("select * from RoomInfo where RoomStatus='可供'");
                                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                            {
                                                Context.Response.Write("<tr>");

                                                for (int j = 0; j < 5; j++)
                                                {
                                                    Context.Response.Write("<td>");
                                                    Context.Response.Write(ds.Tables[0].Rows[i][j].ToString());
                                                    Context.Response.Write("</td>");
                                                }
                                                Context.Response.Write("<td>");
                                                Context.Response.Write("<input type='checkbox' name='" + ds.Tables[0].Rows[i][0].ToString() + "' />预定");
                                                Context.Response.Write("</td>");
                                                Context.Response.Write("</tr>");
                                            }
                                        %>
                                       </table>
                                        
                                        <center>
                                        <br />
                                        <input type="submit"class="tm-button tm-button-wide" name="reserve" value="提交预订" />
                                        </center>
                                        </form>
 
                                    </div>
									
                                </div>                            
                            </section>  

                            <!-- Gallery One section -->     
                            <section id="galleryone" class="tm-section">
                                <header><h2 class="tm-blue-text tm-section-title tm-margin-b-30">已预订房间</h2></header>
                                <div class="tm-gallery-container tm-gallery-1">
                                    <!--
                                    在此插入已预定房间代码块
                                    -->
                                    <form method="post" action="UserService.ashx">
                                    <table width="100%" border="1px">
                                            <tr><th>房间号</th><th>房间类型</th><th>房间价格</th><th>房间状态</th><th>房间说明</th><th>是否退订</th></tr>
                                    <%
                                        System.Data.DataSet ds2 = 数据访问与类库.DBHelper.ExecuteQuery("select * from RoomInfo where RoomStatus='预定' and RoomNumber in(select RoomNumber from BookInfo where CustomerName='"+Request.Cookies["login_name"].Value+"')");
                                        for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                                        {
                                            Context.Response.Write("<tr>");

                                            for (int j = 0; j < 5; j++)
                                            {
                                                Context.Response.Write("<td>");
                                                Context.Response.Write(ds2.Tables[0].Rows[i][j].ToString());
                                                Context.Response.Write("</td>");
                                            }
                                            Context.Response.Write("<td>");
                                            Context.Response.Write("<input type='checkbox' name='" + ds2.Tables[0].Rows[i][0].ToString() + "' />退订");
                                            Context.Response.Write("</td>");
                                            Context.Response.Write("</tr>");
                                        }
                                    %>
                                    </table>
                                    <center>
                                    <br />
                                    <input type="submit"class="tm-button tm-button-wide" name='cancel' value="取消预订" />
                                    </center>
                                    </form>
                                                                      
                                </div>
                            </section>
                      <!--     我的房间 -->    
                            <section id="myroom" class="tm-section">
                                <header><h2 class="tm-blue-text tm-section-title tm-margin-b-30">我的房间</h2></header>
                                <div class="row">
                                    <table width="100%" border="1px">
                                    <tr><th>宾客姓名</th><th>房间号</th><th>已交押金</th><th>入住时间</th><th>房间类型</th><th>房间价格</th><th>我的备注</th></tr>
                                    <%
                                        System.Data.DataSet myroomDataSet = 数据访问与类库.DBHelper.ExecuteQuery("select CustomerName,RoomNumber,Deposit,CheckInTime,RoomType,RoomPrice,Remarks from CustomerInfo where CustomerName='"
                                            + Request.Cookies["login_name"].Value + "'");
                                        for (int i = 0; i < myroomDataSet.Tables[0].Rows.Count; i++)
                                        {
                                            Context.Response.Write("<tr>");

                                            for (int j = 0; j < 7; j++)
                                            {
                                                Context.Response.Write("<td>");
                                                Context.Response.Write(myroomDataSet.Tables[0].Rows[i][j].ToString());
                                                Context.Response.Write("</td>");
                                            }
                                            Context.Response.Write("</tr>");
                                        }                                        
                                    %>
                                    </table>
                                </div>
                            </section>
                            
                            <!-- Contact Us section -->
                            <section id="contact" class="tm-section">
                                <header><h2 class="tm-blue-text tm-section-title tm-margin-b-30">我的信息</h2></header>

                                <div class="row">
                                    <div class="col-lg-6">
                                        <form action="#" method="post" class="contact-form">
                                            <div class="form-group">
                                                姓名：<%Context.Response.Write(Request.Cookies["login_name"].Value);%>
                                            </div>
                                            <div class="form-group">
                                                电话：<%System.Data.DataSet webUserDataSet = 数据访问与类库.DBHelper.ExecuteQuery("select * from WebUser where username='" + Request.Cookies["login_name"].Value + "'");
                                                     Response.Write(webUserDataSet.Tables[0].Rows[0][3].ToString());
                                                        %>
                                            </div>
                                            <div class="form-group">
                                                <textarea id="contact_message" name="contact_message" class="form-control" rows="9" placeholder="Suggest" required></textarea>
                                            </div>                                            
                                            <button type="submit" class="float-right tm-button">进行反馈</button>
                                        </form>    
                                    </div>
                                    
                                    <div class="col-lg-6 tm-contact-right">
                                        <p>
                                        您的个人信息有误异或是想要修改您的信息、密码等，请联系我们的工作人员协助您进行修改。联系方式：XXX    
                                        </p>
                                        <address>
                                            您若是有任何建议或意见，请在此处填写。
                                        </address>
                                    </div>
                                </div>
                                
                            </section>
                            <footer>
                                <p class="tm-copyright-p">Copyright &copy; <span class="tm-current-year">2017</span> Your Company 
                                
                                | Designed by <a href="#" target="_parent">cuttlin</a></p>
                            </footer>
                        </div>  
                        
                    </div> <!-- Right column: content -->
                </div>
            </div> <!-- row -->
        </div> <!-- container -->
                
        <!-- load JS files -->
        <script src="js/jquery-1.11.3.min.js"></script>             <!-- jQuery (https://jquery.com/download/) -->
        <script src="js/jquery.magnific-popup.min.js"></script>     <!-- Magnific pop-up (http://dimsemenov.com/plugins/magnific-popup/) -->
        <script src="js/jquery.singlePageNav.min.js"></script>      <!-- Single Page Nav (https://github.com/ChrisWojcik/single-page-nav) -->
        <script>     
                //获取cookie
                function getCookie(name){
                    var strcookie = document.cookie;//获取cookie字符串
                    var arrcookie = strcookie.split("; ");//分割
                    //遍历匹配
                    for ( var i = 0; i < arrcookie.length; i++) {
                        var arr = arrcookie[i].split("=");
                        if (arr[0] == name){
                            return arr[1];
                        }
                    }
                    return "";
                }
                
                

                //删除cookies
                function delCookie(name)
                {
                    var exp = new Date();
                    exp.setTime(exp.getTime() - 1);
                    var cval=getCookie(name);
                    if(cval!=null)
                        document.cookie= name + "="+cval+";expires="+exp.toGMTString();
                }

            $(document).ready(function(){
                //查看是否是强制登陆
                if(getCookie("login_name")==""||getCookie("login_name")==null){
                    alert("请先登录！"); 
                    top.location='login.aspx';
                }
                
                // Single page nav
                $('.tm-main-nav').singlePageNav({
                    'currentClass' : "active",
                    offset : 20
                });

                // Magnific pop up
                $('.tm-gallery-1').magnificPopup({
                  delegate: 'a', // child items selector, by clicking on it popup will open
                  type: 'image',
                  gallery: {enabled:true}
                  // other options
                }); 

                $('.tm-gallery-2').magnificPopup({
                  delegate: 'a', // child items selector, by clicking on it popup will open
                  type: 'image',
                  gallery: {enabled:true}
                  // other options
                }); 

                $('.tm-gallery-3').magnificPopup({
                  delegate: 'a', // child items selector, by clicking on it popup will open
                  type: 'image',
                  gallery: {enabled:true}
                  // other options
                }); 

                $('.tm-current-year').text(new Date().getFullYear());                
            });
        </script>             
</body>
</html>