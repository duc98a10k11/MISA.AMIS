<template>
    <div class="navbar">
        <div class="logo-box">
            <div class="toggle"></div>
            <div class="logo-page"><img src="https://actappg1.misacdn.net/img/Logo_Module_TiengViet_White.66947422.svg" height="32px" alt=""></div>
        </div>
        <div class="navbar-items-box">
            <div class="navbar-item">
                <a href="#" class="menu-item">
                    <div class="mi item-dashboard"></div>
                </a>
                <div class="text-item">Tổng quan</div>
            </div>
            <div class="navbar-item">
                <a href="#" class="menu-item">
                    <div class="mi item-cash"></div>
                </a>
                <div class="text-item">Tiền mặt</div>
            </div>
            <div class="navbar-item">
                <a href="#" class="menu-item">
                    <div class="mi item-bank"></div>
                </a>
                <div class="text-item">Tiền gửi</div>
            </div>
            <div class="navbar-item">
                <a href="#" class="menu-item">
                    <div class="mi item-pu"></div>
                </a>
                <div class="text-item">Mua hàng</div>
            </div>
            <div class="navbar-item">
                <a href="#" class="menu-item">
                    <div class="mi item-sale"></div>
                </a>
                <div class="text-item">Bán hàng</div>
            </div>
            <div class="navbar-item">
                <a href="#" class="menu-item">
                    <div class="mi item-invoice"></div>
                </a>
                <div class="text-item">Quản lý hóa đơn</div>
            </div>
            <div class="navbar-item">
                <a href="#" class="menu-item">
                    <div class="mi item-stock"></div>
                </a>
                <div class="text-item">Kho</div>
            </div>
            
        </div>
    </div>
</template>

<style scoped>
.navbar{
    background-color: #38393d;
    height: 100vh;
    width: 15vw;
    box-sizing: border-box;
}
.navbar .logo-box{
    padding: 12px 0px 12px 16px;
    box-sizing: border-box;
    display: flex;
    align-items: center;
    text-align: center;
}
.navbar .toggle{
    width: 24px;
    height: 24px;
    margin-right: 10px;
    background:  url(../assets/img/Sprites.64af8f61.svg) no-repeat -424px -86px;
}
.navbar .logo-box .logo-page{
    margin: 0;
    height: 32px;
} 

.navbar-items-box .navbar-item{
    height: 42px;
    box-sizing: border-box;
    display: flex;
    align-items: center;
    cursor: pointer;
}

.navbar-items-box .navbar-item .menu-item{
    padding-left: 8px;
    line-height: 42px;
    height: 42px;
    align-items: center;
    box-sizing: border-box;
    color: #fff;
    display: flex;
    cursor: pointer;
}
.navbar-items-box .navbar-item .item-dashboard{
    /* background-position: -30px -1628px; */
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -30px -1628px;
}
.navbar-item .menu-item .mi{
    cursor: pointer;
    height: 24px;
    width: 24px;
}
 @font-face {
        font-family: 'notosans-regular.2cb88a13';
        src: url('../assets/fonts/notosans-regular.2cb88a13.woff2') format('woff2');
    }
    .navbar-item .text-item {
        color: #fff;
        font-family: "notosans-regular.2cb88a13";
        margin-left: 8px;
        font-size: 13px;
    }

.navbar-item .item-cash{
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -73px -1628px;
}
.navbar-item .item-bank{
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -117px -1628px;
}

.navbar-item .item-pu{
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -161px -1628px;
}

.navbar-item .item-sale{
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -204px -1628px;
}
.navbar-item .item-invoice{
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -249px -1628px;
}
.navbar-item .item-stock{
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -291px -1628px;
}
</style>