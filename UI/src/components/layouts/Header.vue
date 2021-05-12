<template>
    <div class="header">
        <div class="header-icon three-stripes"></div>
        <div class="flex header-branch">
            <div class="header-branch-name">CÔNG TY CỔ PHẦN MISA</div>
            <div class="header-icon chevron-right"></div>
        </div>
        <div class="flex db-content">
            <div class="db-icon"></div>
            <div class="db-name">DC-01</div>
        </div>
        <div class="space-beetween"></div>
        <div class="header-input margin">
            <input type="text" placeholder="Nhập từ khóa tìm kiếm" class="input-search">
        </div>
        <button class="button">
            <div class="flex button-text">
                <div class="header-icon category"></div>
            </div>
        </button>
        <button class="button">
            <div class="flex button-text">
                <div class="header-icon setting__nav"></div>
            </div>
        </button>
        <button class="button">
            <div class="flex button-text">
                <div class="header-icon chat__nav"></div>
            </div>
        </button>
        <button class="button">
            <div class="flex button-text">
                <div class="header-icon help__nav"></div>
            </div>
        </button>
        <button class="button">
            <div class="flex button-text">
                <div class="header-icon bell__nav"></div>
            </div>
        </button>
        <div class="flex header-branch">
            <div class="header-icon user-avatar"></div>
            <div class="header-branch-name">Lê Minh Đức</div>
            <div class="header-icon chevron-right"></div>
        </div>
    </div>
</template>
<script>
export default {
    
}
</script>
<style scoped>
.header{
    position: absolute;
    top: 0;
    left: 178px;
    width: calc(100% - 178px);
    height: 48px;
    display: flex !important;
    align-items: center;
    justify-content: space-between;
}
.header-icon{
    background: url("../../assets/Sprites.5f05e81f.svg") no-repeat;
    cursor: pointer;
    min-width: 24px;
    min-height: 24px;
    height: 24px;
    width: 24px;
    margin-left: 8px;
    margin-right: 8px;
}
.header .header-branch{
    display: flex;
    align-items: center ;
    cursor: pointer;
}
.header .db-content{
    border: 1px solid #ebedf0;
    padding: 0 12px;
    border-radius: 40px;
    margin-left: 15px;
    font-size: 13px;
    cursor: pointer;
    height: 30px;
    margin-right: 10px;
}
.db-content .db-icon{
    width: 8px;
    height: 8px;
    background-color: #4ea344;
    border-radius: 50%;
    border: 1px solid #fff;
}
.db-content .db-name{
    max-width: 80px;
    padding-left: 7px;
    max-width: 200px;
    overflow: hidden;
    text-overflow: ellipsis;
    white-space: nowrap;
    transition: all .2s ease;
    color: #111;
}
.three-stripes {
    background-position: -843px -30px;
}
.chevron-right {
    background-position: -76px -357px;
    transform: rotate(90deg); 
}
.flex{
    display: flex !important;
    align-items: center !important;
}
.header .space-beetween{
    width: 20%;
}
.header .header-input{
    height: 32px;
    display: flex;
    align-items: center;
}
.margin{
    margin-right: 10px;
}
.button{
    height: 100%;
    position: relative;
    transition: all .2s ease;
    border: 0;
    width: 44px;
    cursor: pointer;
    position: relative;
    overflow: hidden;
    color: #fff;
    box-sizing: border-box;
    background: 0 0;
    overflow: visible;
}
.button-text{
    font-weight: 600;
    position: relative;
    color: inherit;
    display: inline-block;
    transition: all .25s ease;
    white-space: nowrap;
    font-size: 13px;
    line-height: 13px;
    justify-content: center;
    align-items: center;
}
.category {
    background-position: -568px -30px;
}
.setting__nav {
    background-position: -675px -30px;
}
.chat__nav {
    background-position: -899px -30px;
}
.help__nav {
    background-position: -731px -30px;
}
.bell__nav {
    background-position: -788px -30px;
}
.user-avatar {
    background-position: -352px -894px;
    width: 32px;
    height: 32px;
    border-radius: 50%;
}
</style>