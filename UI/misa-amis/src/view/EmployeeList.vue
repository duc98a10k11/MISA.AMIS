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
            <div class="container-item fix-item">
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
                            <th class="check-box-table"><input type="checkbox" name="" id=""></th>
                            <th>Mã nhân viên</th>
                            <th>Tên nhân viên</th>
                            <th>Giới tính</th>
                            <th>Ngày sinh</th>
                            <th>Số CMND</th>
                            <th>Ngày cấp</th>
                            <th>Nơi cấp</th>
                            <th>Chức danh</th>
                            <!-- <th>Mã đơn vị</th> -->
                            <!-- <th>Tên đơn vị</th> -->
                            <!-- <th>Nhóm KH, NCC</th>
                            <th>TK công nợ phải thu</th>
                            <th>TK công nợ phải trả</th> -->
                            <th>Số tài khoản</th>
                            <th>Tên ngân hàng</th>
                            <th>Chi nhánh TK ngân hàng</th>
                            <th>Tỉnh/TP ngân hàng</th>
                            <th>Địa chỉ</th>
                            <th>ĐT di động</th>
                            <th>ĐT cố định</th>
                            <th>Email</th>
                            <!-- <th>Là khách hàng</th>
                            <th>Là nhà cung cấp</th> -->
                            <th class="th-view-right">Chức năng</th>
                        </tr>
                    </thead>
                    <tbody v-for="employee of employees" :key="employee.EmployeeId">
                        <tr>
                            <td scope="row" class="check-box-table"><input type="checkbox" name="" id=""></td>
                            <td>{{employee.employeeCode}}</td>
                            <td>{{employee.employeeName}}</td>
                            <td>{{employee.gender}}</td>
                            <td>{{employee.dateOfBirth || formatDateDDMMYYYY}}</td>
                            <td>{{employee.indentifyNumber}}</td>
                            <td>{{employee.dateOfIndentify ||formatDateDDMMYYYY}}</td>
                            <td>{{employee.placeOfIdentify}}</td>
                            <td>{{employee.employeePosition}}</td>
                            <td>{{employee.bankAccountNumber}}</td>
                            <td>{{employee.bankName}}</td>
                            <td>{{employee.bankBranchName}}</td>
                            <td>{{employee.bankProvinceName}}</td>
                            <td>{{employee.address}}</td>
                            <td>{{employee.phoneNumber}}</td>
                            <td>{{employee.telephoneNumber}}</td>
                            <td>{{employee.email}}</td>
                            
                            <td class="th-view-right"></td>
                        </tr>
                         
                    </tbody>
                </table>
                 
            </div>
           <div class="fix-item">
                    <div class="total-record">Tổng số: <b class="number-record">11</b> bản ghi</div>
                    <div class="fix-item-right">
                        <div class="select-paging">
                            <select class="paging-selected" name="paging" id="">
                                <option value="10">10 bản ghi trên 1 trang</option>
                                <option value="20">20 bản ghi trên 1 trang</option>
                                <option value="30">30 bản ghi trên 1 trang</option>
                                <option value="50">50 bản ghi trên 1 trang</option>
                                <option value="100">100 bản ghi trên 1 trang</option>
                            </select>   
                        </div>
                        <button class="btn-pre btn-paging">Trước</button>
                        <button class="btn-paging btn-page">1</button>
                        <button class="btn-next btn-paging">Sau</button>
                    </div>
                    
            </div>
        </div>
    </div>
</template>

<script>
    import axios from 'axios'
// import Popup from './Popup.vue'
export default {
  components: {
    // Popup
  },
  created () {
    this.getEmployee()
  },
  data: function () {
    return {
      isShow: false,
      employees: []
    }
  },
  filters:{
      formatDateDDMMYYYY(date) {
            if (!date) {
                return "";
            }
            var newDate = new Date(date);
            var dateString = newDate.getDate();
            var monthString = newDate.getMonth() + 1;
            var year = newDate.getFullYear();
            if (dateString < 10) {
                dateString = "0" + dateString;
            }
            if (monthString < 10) {
                monthString = "0" + monthString;
            }
            return `${dateString}/${monthString}/${year}`;
        }
  },
  methods: {
    getEmployee () {
      axios.get('https://localhost:44320/api/v1/Employees').then(res => {
        this.employees = res.data
        console.log(res.data)
      })
    }
  }
}
</script>

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
    width: calc(100vw - 18vw);
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
    cursor: pointer;
}
.content-employee .title .title-right .btn-box{
    height: 36px;
    box-sizing: border-box;
    border: none;
    outline: none;
    background: none;
    padding-right: 10px;
    border-right: 1px solid #bbb;
    cursor: pointer;
}
.content-employee .title .title-right .btn-add-excel{
    height: 14px;
    width: 14px;
    margin-left: 10px;
    padding:  0 8px 0px 10px ;
    cursor: pointer;
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
    cursor: pointer;
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
    overflow: scroll;
    padding: 0px 10px 0px 10px;
    height: calc(100% - 100px);
    width: 100%;
    box-sizing: border-box;
 
}
.container .fix-item{
    position: sticky;
    left: 0;
    background-color: #ffffff;
    background-position: 0 0;
    
    display: flex;
    justify-content: space-between;
}
.container .fix-item .fix-item-right{
    display: flex;
}
.container .fix-item .paging-selected{
    height: 30px;
    margin: 0 10px;
    padding: 0px 10px 0px 10px;
    box-sizing: border-box;
    border: 1px solid #9e9e9e;
    outline: none;
    cursor: pointer;
}
.container .fix-item .paging-selected:hover{
    border: 1px solid #9e9e9e;
}
.container .fix-item-right .btn-paging{
    padding: 0 8px;
    margin: 0 8px;
    cursor: pointer;
}
.container .fix-item-right .btn-page{
    border: 1px dotted #35BF22;
    height: 30px;
    width: 32px;
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
table{
    font-size: 13px;
    border-collapse: separate;
}
.container .grid {
    /* overflow: scroll; */
    width: 100%;
    height:calc(100% - 96px) ;
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}
.container .grid .table tr,td {
    height: 40px;
    padding: 5px 10px 5px 10px;
    box-sizing: border-box;
    border-right: 1px dotted #C7C7C7;
    border-bottom: 1px solid #C7C7C7;
    text-align: left;
    cursor: pointer;
}
.container .grid .table th {
    height: 34px;
     border-right: 1px solid #C7C7C7;
    border-bottom: 1px solid #C7C7C7;
    color: #111111;
    box-sizing: border-box;
    position: sticky;
    display: table-cell;
    z-index: 2;
    top: 0px;
    min-width: 150px;
    min-height: 34px;
    padding: 5px 10px 3px 10px;
    background-color:#ECEEF1;
}
.container .grid .table .check-box-table{
    z-index: 3;
    position: sticky;
    left: 0;
    top: 0;
    min-width: 40px;
    width: 40px;
    max-width: 40px;

}
.container .grid .table .th-view-right{
    border-right: none;
    position: sticky;
    right: 0;
    z-index: 4;
    border-left: 1px solid #c7c7c7;
}

</style>