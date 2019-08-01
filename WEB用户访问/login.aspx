<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WEB用户访问.login1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>

	<title>酒店客房管理系统</title>

		<meta name="viewport" content="width=device-width, initial-scale=1">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8">

		<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
	
		<link rel="stylesheet" href="css/style.css" type="text/css" media="all">



</head>
<body>

	<h1>酒店客房宾客登录</h1>

	<div class="container w3layouts agileits">

		<div class="login w3layouts agileits">
			<h2>登 录丨<a href='regist.aspx'>注 册</a></h2>
			<!--
			
			重要代码块
			
			-->
			<form action="login.ashx" method="post">
				<input type="text" name="username" placeholder="Username" required="">
				<input type="password" name="password" placeholder="Password" required="">
				<ul class="tick w3layouts agileits">
					<li>
						<input type="checkbox" id="brand1" value="">
					</li>
				</ul>
			<div class="send-button w3layouts agileits">
				<input type="submit" value="登 录">
			</div>
			</form>
			
			
			
			
			<div class="clear"></div>
		</div>
		

		<div class="clear"></div><!--顶住下面的框-->

	</div>

	<div class="footer w3layouts agileits">
		<p>Copyright &copy;cuttlin</p>
	</div>

</body>
<script type="text/javascript">
    window.onload=function()//用window的onload事件，窗体加载完毕的时候
    {
       if(getQueryString("isRegist")=="ok"){
            alert("注册成功，请重新登录！"+getQueryString("isRegist").toString());
        }
        if(getQueryString("login_msg")=="false"){
            alert("登录失败！");
        }
    }
    function getQueryString(name) { 
        var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)", "i"); 
        var r = window.location.search.substr(1).match(reg); 
        if (r != null) return unescape(r[2]); return null; 
    }
</script>
</html>