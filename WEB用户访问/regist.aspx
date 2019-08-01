<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regist.aspx.cs" Inherits="WEB用户访问.regist1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>

<!-- Head -->
<head>

	<title>酒店客房管理系统</title>


		<meta name="viewport" content="width=device-width, initial-scale=1">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8">

		<script type="application/x-javascript"> 
		addEventListener("load", 
		function(){ 
			setTimeout(hideURLbar, 0); 
		}, false); 
			function hideURLbar(){
				window.scrollTo(0,1); 
			} 
		</script>
	 
		<link rel="stylesheet" href="css/style.css" type="text/css" media="all">



</head>

<body>

	<h1>酒店客房宾客注册</h1>

	<div class="container w3layouts agileits">
		<div class="login w3layouts agileits"><!--将register换成了login-->
			<h2><a href='login.aspx'>登 录</a>丨注 册</h2>
			
			<!--
			
			重要代码块
			
			-->
			<form action="regist.ashx" method="post"><font id='fnum' color='red'></font>
				<input type="text" id='num' name="telephone" placeholder="手机号码" required="" onblur='arriveNum()'>
	            <input type="text" name="username" placeholder="账户名" required="">
				<input type="password" id='pwd' name="password" placeholder="密码" required=""><font id='err' color="red"></font>
				<input type="password" id='rpwd' name="repassword" placeholder="重复密码" onblur='repeated()' required="">		
				<div class="send-button w3layouts agileits">				
					<input type="submit" value="注册">				
				</div>
			</form>
			<div class="clear"></div>
		</div>

		<div class="clear"></div>

	</div>

	<div class="footer w3layouts agileits">
		<p>Copyright &copy;cuttlin</p>
	</div>

</body>
<script type="application/x-javascript">
    //重复密码的离焦事件
    function repeated(){
        var pwd = document.getElementById("pwd");
        var repwd = document.getElementById("rpwd");
        var err = document.getElementById("err");
        if(pwd.value!=repwd.value){
            err.innerHTML = "重复密码错误！";
        }else{
            err.innerHTML = "";
        }     
    }
    //电话号码的验证
    function arriveNum(){
        var num = document.getElementById("num");
        var fnum = document.getElementById("fnum");
        if(!(/^[0-9]+$/.test(num.value))){
            fnum.innerText = "电话号码有误！";
        }else{
            fnum.innerText = "";
        }
    }
    
</script>

</html>