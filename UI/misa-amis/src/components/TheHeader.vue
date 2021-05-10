<template>
    <div class="header">
        <div class="header-items-box-left">
            <div class="btn-three-stripe"></div>
            <div class="header-branch-name">CÔNG TY CỔ PHẦN MISA</div>
            <a href="#" class="btn-dropdown"></a>
            <div class="tool-tip">
                <div class="icon-header-current"></div>
                <div>DC-01</div>
            </div>
        </div>
        <div class="header-item-box-right">
            <div class="item-input">
                <input type="text" name="" value="" placeholder="Nhập từ khóa tìm kiếm" class="input-search">
                <div class="btn-search"></div>
            </div>
            <div class="header-icon-box">
                <div class="header-icon icon-category"></div>
            </div>
            <div class="header-icon-box">
                <div class="header-icon icon-setting"></div>
            </div>
            <div class="header-icon-box">
                <div class="header-icon icon-chat"></div>
            </div>
            <div class="header-icon-box">
                <div class="header-icon icon-simple"></div>
            </div>
            <div class="header-icon-box">
                <div class="header-icon icon-bell"></div>
            </div>
            <div class="header-user">
                <div class="img-user"></div>
                <div class="text-user">Lê Minh Đức</div>
                <div href="#" class="btn-dropdown"></div>
            </div>
        </div>
    </div>
</template>

<style scoped>
 @font-face {
        font-family: 'notosans-regular.2cb88a13';
        src: url('../assets/fonts/notosans-regular.2cb88a13.woff2') format('woff2');
    }
@font-face {
    font-family: 'notosans-italic.1c1aaac9';
    src: url('../assets/fonts/notosans-italic.1c1aaac9.woff2') format('woff2');
}

.header{
    font-family: "notosans-regular.2cb88a13";
    height: 48px ;
    font-size: 13px;
    box-sizing: border-box;
    width: calc(100vw - 15vw);
    display: flex;
    justify-content: space-between;
}
.header .header-items-box-left{
    display: flex;
    align-items: center;
    line-height: 48px;
}
.header .header-items-box-left .btn-three-stripe{
    width: 24px;
    height: 24px;
    margin-left: 10px;
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -843px -30px;
}
.header .header-items-box-left .header-branch-name{
    padding-left: 10px;
}
.header .header-items-box-left .btn-dropdown{
    width: 14px;
    height: 14px;
    margin: 0 10px;
    transform: rotate(90deg);
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -80px -360px;
    background-size: 14px 14px;
}
.header .header-items-box-left .tool-tip{
        display: flex;
    align-items: center;
    border: 1px solid #ebedf0;
    padding: 0 12px;
    border-radius: 40px;
    margin-left: 15px;
    font-size: 13px;
    cursor: pointer;
    height: 30px;
    margin-right: 10px;
}
.header .header-items-box-left .tool-tip .icon-header-current{
    width: 8px;
    height: 8px;
    background-color: #4ea344;
    border-radius: 50%;
    border: 1px solid #fff;
}
.header .header-item-box-right{
    display: flex;
    align-items: center;
    line-height: 48px;
    box-sizing: border-box;
}
.header .header-item-box-right .item-input{
    display: flex;
    align-items: center;
    line-height: 32px;
    text-align: center;
    border:  1px solid #ebedf0;
    border-radius: 8px;
    padding-right: 8px;
}

.header .header-item-box-right .input-search{
    height: 32px;
    font-family: "notosans-italic.1c1aaac9";
    padding-left: 8px;
    border-radius: 4px;
    box-sizing: border-box;
    outline: none;
    border: none;
    
}
/* .header .header-item-box-right .input-search:focus{
    border:  1px solid #ebedf0;
} */
.header .header-item-box-right .btn-search{
    width: 16px;
    height: 16px;
    cursor: pointer;
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -992px -360px;
}
.header .header-item-box-right .header-icon-box{
    width: 48px;
    height: 100%;
    box-sizing: border-box;
    align-items: center;
    text-align: center;
    line-height: 48px;
    padding-top: 12px;
}
.header .header-item-box-right .header-icon-box:hover{
    background-color: #35BF22;
}
.header .header-item-box-right .header-icon{
    height: 24px;
    width: 24px;
    margin: 0 10px;
    cursor: pointer;
}
.header .header-item-box-right .header-icon:hover{
    background-color: #35BF22;
}
.header .header-item-box-right .icon-category{
    
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -568px -30px;
}
.header .header-item-box-right .icon-setting{
    
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -675px -30px;
}
.header .header-item-box-right .header-icon-box .icon-chat{
    color: #ffffff;
    background-color: #fff;
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -899px -30px;
}
.header .header-item-box-right .icon-simple{
    
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -731px -30px;
}
.header .header-item-box-right .icon-bell{
    
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -788px -30px;
}

.header .header-item-box-right .header-user{
    display: flex;
    height: 48px;
    box-sizing: border-box;
    align-items: center;
    line-height: 48px;
    padding: 0 20px;
}
.header .header-item-box-right .header-user .img-user{
    width: 32px;
    height: 32px;
    margin: 0 10px;
    cursor: pointer;
    border-radius: 50%;
    box-sizing: border-box;
    border: rgb(255, 0, 0) dashed 1px;
}
.header .header-item-box-right .text-user{
    padding-right: 16px;
}

@media only screen and (min-width: 1024px) {
    input{
        display: flex;
        align-items: center;
        line-height: 32px;
        text-align: center;
        width: 50px;
        
        border: 1px solid #bbbbbb;
        border-radius: 8px;
        padding-right: 8px;
    }
}
</style>