<?php
session_start();
$sesiData = !empty($_SESSION['sesiData'])?$_SESSION['sesiData']:'';
if(!empty($sesiData['status']['msg'])){
    $statusPsn = $sesiData['status']['msg'];
    $jenisStatusPsn = $sesiData['status']['type'];
    unset($_SESSION['sesiData']['status']);
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>HWD INVITATION</title>
    <link rel="stylesheet" type="text/css" href="style.css">
    <link rel="stylesheet" type="png" href="img/icon.png">
</head>
<body>
	<header>
	<div id="wrapper">
    <div id="header">
		<p><marquee>Welcome To HWD Invitation</marquee></p><br>
    <nav id="menu">
  		<br><ul>
   			<li><a href="index.html">Beranda</a></li>
   			<li><a href="#about">Tentang</a></li>
   			<li><a href="#paket">Paket Undangan</a></li>
   			<li><a href="#kontak">Kontak</a></li>
            <li><a href="#regisForm">Masuk</a></li>
            <li><a href="daftar.php">Daftar</a></li>
  		</ul>
 	</nav>
    </div>
    <div id="content">
    	<div id="home">
    		<img src="img/home-banner.jpg" style="margin-top: 75px;">
    	</div>
    	<div id="logo">
    		<img src="img/logo.png">
    	</div>

        <div class="container" style="text-align: center; width: 100%; position:relative; background:#FF69B4; margin-top: 20px; padding-top: 10px;padding-bottom: 10px; color: white; font-size: 20px;">
        <?php
            if(!empty($sesiData['userLoggedIn']) && !empty($sesiData['userID'])){
                include 'user.php';
                $user = new User();
                $kondisi['where'] = array(
                    'id' => $sesiData['userID'],
                );
                $kondisi['return_type'] = 'single';
                $userData = $user->getRows($kondisi);
        ?>
        <h2>Selamat Datang <?php echo $userData['nama_awal']; ?>!</h2>
        <a href="akunuser.php?logoutSubmit=1" class="logout">Logout</a>
        <div id="regisForm">
            <p><b>Nama: </b><?php echo $userData['nama_awal'].' '.$userData['nama_akhir']; ?></p>
            <p><b>Email: </b><?php echo $userData['email']; ?></p>
            <p><b>Telp: </b><?php echo $userData['telp']; ?></p>
        </div>
        <?php }else{ ?>
        <h1>Silakan Login</h1><br>
        <?php echo !empty($statusPsn)?'<p class="'.$jenisStatusPsn.'">'.$statusPsn.'</p>':''; ?>
        <div id="regisForm">
            <form action="akunuser.php" method="post">
                <input type="email" name="email" placeholder="Email" required=""> <br><br>
                <input type="password" name="password" placeholder="Pssword" required="">
                <div class="tbl-kirim" style="margin-left: 125px;">
                    <br><input type="submit" name="loginSubmit" value="Login">
                </div>
            </form>
        </div>
        
    </div>
    <?php } ?>
    	<div id="about">
    		<p>
    			<h1>About</h1><br>
    			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;HWD Invitation adalah website yang melayani pelanggan untuk memesan undangan pernikahan digital, kenapa anda harus pesan disini karena kami menyediakan sesuai kebutuhan custemer, dan untuk harganya sangat terjangkau. jika dibangingkan undangan cetak harganya dihitung perlembarnya, sedangkan untuk undangan digital tidak terbatas dikirim kesiapapun, dan durasi online untuk mengisi buku tamu tergantung keinginan custemer.
    		</p>
    	</div>

    	<div id="paket">
    		<p>
    			<h1 align="center">Paket Undangan Pernikahan</h1>
    			<h1 align="center">Silver</h1>
    			<p style="margin-left: 65px; font-size: 20px; font-style: bold;">
    				Fitur	:<br>
    				1.	Tamplate Undangan Format JPG (kualitas Full HD)<br>
    				2.	Buku Tamu Digital<br>
    				3.	Promote Insta Story 3 Days<br>
    				4.	Video durasition max 30 sec<br>
    				5.	Share Story WA<br>
    				<a href="silver.html"> Read More</a><br><br><br><br>
    			</p>
    			
    		</p>

    		<p>
    			<h1 align="center">Platinum</h1>
    			<p style="margin-left: 65px; font-size: 20px; font-style: bold;">
    				Fitur	:<br>
    				1.	Tamplate Undangan Format JPG (kualitas Full HD)<br>
    				2.	Buku Tamu Digital<br>
    				3.	Promote Insta Story 3 Days<br>
    				4.	Video durasition max 60 sec<br>
    				5.	Share Story WA<br>
    				<a href="platinum.html"> Read More</a><br><br><br><br>
    			</p>
    		</p>

    		<p>
    			<h1 align="center">Gold</h1>
    			<p style="margin-left: 65px; font-size: 20px; font-style: bold;">
    				Fitur	:<br>
    				1.	Tamplate Undangan Format JPG (kualitas Full HD)<br>
    				2.	Buku Tamu Digital<br>
    				3.	Promote Insta Story 7 Days<br>
    				4.	Video durasition max 60 sec<br>
    				5.	Share Story WA<br>
    				<a href="gold.html"> Read More</a><br><br><br><br>
    			</p>
    		</p>

    	</div>
<div id="kontak" style="background:#FF69B4; width: 100%; margin-bottom: 20px; height: 80px;">
            <img src="img/WA.png" style="height: 80px; width: 80px;"><img src="img/IG.png" style="height: 80px; width: 80px; margin-left: 180px;"><img src="img/FB.png"style="height: 80px; width: 80px; margin-left: 100px;">
            <img src="img/GMAIL.png"style="height: 80px; width: 80px;">
        <p style="margin-top: -50px;"><a href="https://api.whatsapp.com/send?phone=6285694873565&text=Saya%20tertarik%20untuk%20membuat%20undangan digital" style="margin-left:100px;"> Order Lewat Whatsapp</a></p><br>
            <p style="margin-top: -50px;"><a href="mailto:hwdinvitation@gmail.com?subject=Pesan%20Undangan%20Digital atau judul disini&body=Saya%20pesan%20undangan%20digital%20paket%20silver tulisan yang di tubuh disini" style="margin-left: 360px;">Order Lewat Email</a></p>
        </div>
 
    </div>
    <div id="footer"><br>
    <a href="">Copyright @2019</a>
    </div>
    </div>
</header>
</body>
</html>