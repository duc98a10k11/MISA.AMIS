<template>
    <div class="content-employee">
        <div class="title-box">
            <div class="title">
                <div class="tilte-left"><h1>Nhân viên</h1></div>
                <div class="title-right">
                    <div class="btn-extention-box">
                        <button class="btn-extention">Tiện ích</button>
                        <div class="icon-extention"></div>
                    </div>
                    
                    <div class="btn-add">
                        <button class="btn-box">Thêm</button>
                        <button class="btn-add-excel icon"></button>
                    </div>
                </div>
            
            </div>
            <div class="item-title">
                <div class="icon-dropdown"></div>
                <a href="#" class="text-a">Tất cả danh mục</a>
            </div>
        </div>
        <div class="container">
            <div class="container-item">
                <div class="btn-extention-box">
                    <button class="btn-extention btn-container">Thực hiện hàng loạt</button>
                    <div class="icon-extention"></div>
                </div>
                <div class="container-item-right">
                    <div class="item-input">
                        <input type="text" name="" value="" placeholder="Tìm theo mã, tên nhân viên" class="input-search">
                        <div class="btn-search"></div>
                    </div>
                    <div class="conatainer-icon">
                        <button class="icon-reload"></button>
                    </div>
                     <div class="conatainer-icon">
                        <button class="icon-import-excel"></button>
                    </div>
                     <div class="conatainer-icon">
                        <button class="icon-setting"></button>
                    </div>
                </div>
            </div>
            <div class="grid">
                <table class="table">
                    <thead>
                        <tr>
                            <th><input type="checkbox" name="" id=""></th>
                            <th>Mã nhân viên</th>
                            <th>Tên nhân viên</th>
                            <th>Giới tính</th>
                            <th>Ngày sinh</th>
                            <th>Số CMND</th>
                            <th>Ngày cấp</th>
                            <th>Nơi cấp</th>
                            <th>Chức danh</th>
                            <th>Mã đơn vị</th>
                            <th>Tên đơn vị</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td scope="row"></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td scope="row"></td>
                            <td></td>
                            <td></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</template>

<style>
 @font-face {
        font-family: 'notosans-regular.2cb88a13';
        src: url('../assets/fonts/notosans-regular.2cb88a13.woff2') format('woff2');
    }
@font-face {
    font-family: 'notosans-italic.1c1aaac9';
    src: url('../assets/fonts/notosans-italic.1c1aaac9.woff2') format('woff2');
}
.title-box .item-title{
    display: flex;
    cursor: pointer;
}
.text-a{
    text-decoration: none;
    color: #0075C0;
    
}
.icon-dropdown{
    width: 14px;
    height: 14spx;
    color: #0075C0;
    
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -224px -360px;
}
button{
    outline: none;
    border: none;
    background-color: #ffffff;
}
.content-employee{
    margin: 0px 30px 0px 20px;
    font-family:'notosans-regular.2cb88a13' ;
    font-size: 13px;
    box-sizing: border-box;
    height: calc(100vh - 48px);
    
}
.content-employee .title-box{
    padding: 22px 0px 16px 0px ;
}
.content-employee .title{
    display: flex;
    justify-content: space-between;
}

.content-employee .title .title-right{
    display: flex;
    
}
.content-employee .title-right .btn-add{
    height: 36px;
    border-radius: 30px;
    box-sizing: border-box;
    padding: 0 16px;
     background-color: #2CA01C;
    border: 1px solid #bbbbbb;

}
.content-employee .title .title-right .btn-box{
    height: 36px;
    box-sizing: border-box;
    border: none;
    outline: none;
    background: none;
    padding-right: 10px;
    border-right: 1px solid #bbb;
}
.content-employee .title .title-right .btn-add-excel{
    height: 14px;
    width: 14px;
    margin-left: 10px;
    padding:  0 8px 0px 10px ;

    color: black;
    box-sizing: border-box;
    border: none;
    outline: none;
    background: none;
    /* padding-left: 10px; */
    align-items: center;
    
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -848px -359px;
}
.content-employee  .btn-extention-box{
     height: 36px;
    border-radius: 30px;
    padding: 0 16px;
    border: 1px solid #bbbbbb;
    padding: 0 16px;
    align-items: center;
    box-sizing: border-box;
    line-height: 36px;
    margin-right: 16px;
    display: flex;
}
.content-employee .btn-extention{
    border: none;
    outline: none;
    background-color: #F4F5F6;
}
.content-employee  .icon-extention{
    height: 14px;
    width: 14px;
    margin-left: 8px;
    /* background-color: blueviolet; */
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -560px -359px;
}
.content-employee .container{
    background-color:#ffffff;
    /* margin: 0 30px 0 20px; */
    
    height: calc(100% - 96px);
    width: 100%;
    box-sizing: border-box;
 
}
.content-employee .container .container-item{
    display: flex;
    padding: 16px 16px 10px;
    justify-content: space-between;
}
.container .container-item .btn-container{
    background-color: #fff;
}

.container .container-item .item-input{
    display: flex;
    align-items: center;
    line-height: 32px;
    width: 100%;
    text-align: center;
    border:  1px solid #ebedf0;
    /* border-radius: 8px; */
    padding-right: 8px;
}
.container .container-item-right{
    display: flex;
}
.container .container-item .input-search{
    height: 32px;
    font-family: "notosans-italic.1c1aaac9";
    padding: 6px 22px 6px 8px;
    width: 100%;
    /* border-radius: 4px; */
    box-sizing: border-box;
    outline: none;
    border: none;
}
.container .container-item-right .btn-search{
    width: 16px;
    height: 16px;
    cursor: pointer;
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -992px -360px;
}
.container .container-item-right .conatainer-icon{
    height: 32px;
    width: 32px;
    box-sizing: border-box;
    align-items: flex-end;
    line-height: 32px;
    margin: 0 8px;
    padding: 7px 0 0 ;
}

.container .container-item-right .icon-reload{
    width: 24px;
    height: 24px;
    box-sizing: border-box;
    cursor: pointer;
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -423px -201px;
}

.container .container-item-right .icon-import-excel{
    width: 24px;
    height: 24px;
    box-sizing: border-box;
    cursor: pointer;
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -704px -200px;
}
.container .container-item-right .icon-setting{
    width: 24px;
    height: 24px;
    box-sizing: border-box;
    cursor: pointer;
    background: url(../assets/img/Sprites.64af8f61.svg) no-repeat -88px -200px;
}
</style>