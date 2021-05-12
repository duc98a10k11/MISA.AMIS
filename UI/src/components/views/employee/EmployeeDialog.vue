<template>
<!-- :class="{'dialog-hide': !state}" -->
  <div class="dialog" v-if="state">  
    <div class="model"></div>
    <div class="dialog-box">
      <div class="dialog-header">
        <div class="title flex">
          <div class="title-dialog">Thông tin nhân viên</div>
          <div class="component">
            <input type="checkbox" style="width: 18px; height: 16px" />
            <div style="padding-left: 10px">Là khách hàng</div>
          </div>
          <div class="component">
            <input type="checkbox" style="width: 18px; height: 16px" />
            <div style="padding-left: 10px">Là nhà cung cấp</div>
          </div>
        </div>
      </div>
      <div class="item-close">
        <div class="dialog-icon help" style="margin-right: 6px"></div>
        <div class="dialog-icon close" @click="btnCloseClick"></div>
      </div>
      <div class="dialog-content">
          <div class="employee-inf">
              <div class="inf-left">
                  <div class="row-1">
                      <div class="code">
                        <span class="text">Mã<p style="color: red; display: inline;"> *</p></span>
                        <ValidationProvider name="Mã nhân viên" rules="required" v-slot="{ errors }">
                          <input type="text" :title="errors[0]" style="width: 151px; margin-top: 4px;" v-model="employee.employeeCode" :class="errors[0] == null ? '' : 'input-error'">
                        </ValidationProvider>
                      </div>
                      <div class="name">
                        <span class="text">Tên<p style="color: red; display: inline;"> *</p></span>
                        <ValidationProvider name="Tên nhân viên" rules="required" v-slot="{ errors }">
                          <input type="text" :title="errors[0]" style="width: 235px; margin-top: 4px;" v-model="employee.employeeName" :class="errors[0] == null ? '' : 'input-error'">
                        </ValidationProvider>
                      </div>
                  </div>
                  <div class="row-1">                   
                      <div class="position">
                        <span class="text">Đơn vị<p style="color: red; display: inline;"> *</p></span>
                        <select style="width: 392px; margin-top: 4px;" v-model="employee.departmentId">
                          <option v-for="(department, index) in departments" :key="index" :value="department.departmentId">{{department.departmentName}}</option>
                        </select>
                      </div>
                  </div>
                  <div class="row-1">                   
                      <div class="position">
                        <span class="text">Chức danh</span>
                        <input type="text" style="width: 392px; margin-top: 4px;" v-model="employee.employeePosition">
                      </div>
                  </div>
              </div>
              <div class="inf-left">
                  <div class="row-1">
                      <div class="dateofbirth">
                        <span class="text">Ngày sinh</span>
                        <input type="date" style="width: 167px; margin-top: 4px;" v-model="employee.dateOfBirth">
                      </div>
                      <div class="gender">
                        <span class="text">Giới tính</span>
                        <div class="radio" style="width: 251px; margin-top: 4px;">
                          <input type="radio" name="gender" class="input-radio" value="1" v-model="employee.gender">
                          <label for="" style="margin-right: 20px;">Nam</label>
                          <input type="radio" name="gender" class="input-radio" value="0" v-model="employee.gender">
                          <label for="" style="margin-right: 20px;">Nữ</label>
                          <input type="radio" name="gender" class="input-radio" value="2" v-model="employee.gender">
                          <label for="">Khác</label>
                        </div>
                      </div>
                  </div>
                  <div class="row-1">
                      <div class="id">
                        <span class="text">Số CMND</span>
                        <input type="text" style="width: 245px; margin-top: 4px;" v-model="employee.identityNumber">
                      </div>
                      <div class="dateofbirth" style="padding-left: 5px;">
                        <span class="text">Ngày cấp</span>
                        <input type="date" style="width: 167px; margin-top: 4px;" v-model="employee.identityDate">
                      </div>
                  </div>
                  <div class="row-1">                   
                      <div class="place">
                        <span class="text">Nơi cấp</span>
                        <input type="text" style="width: 418px; margin-top: 4px;" v-model="employee.identityPlace">
                      </div>
                  </div>
              </div>
          </div>
          <div class="select-tab">
            <div class="tab">
              <button class="inf" @click="btnInforClick">Liên hệ</button>
              <button class="bank" @click="btnBankClick">Tài khoản ngân hàng</button>
            </div>
            <div class="tab-inf" :class="{'dialog-hide': !infor}">
              <div class="row-1">                   
                  <div class="position" style="margin-top: 17px; margin-left: 10px;">
                    <span class="text">Địa chỉ</span>
                    <input type="text" style="width: 812px; margin-top: 4px;" v-model="employee.address">
                  </div>
              </div>
              <div class="row-1">                   
                <div class="phone" style="margin-top: 17px; margin-left: 10px;">
                  <span class="text">ĐT di động</span>
                  <ValidationProvider name="Số điện thoại" rules="required" v-slot="{ errors }">
                    <input type="text" :title="errors[0]" style="width: 197px; margin-top: 4px;" v-model="employee.phoneNumber" :class="errors[0] == null ? '' : 'input-error'">
                  </ValidationProvider>
                </div>
                <div class="phone" style="margin-top: 17px; margin-left: 5px;">
                  <span class="text">ĐT cố định</span>
                  <input type="text" style="width: 197px; margin-top: 4px;" v-model="employee.telephoneNumber">
                </div>
                <div class="name" style="margin-top: 17px; margin-left: 5px;">
                  <span class="text">Email</span><br>
                  <input type="text" style="width: 203px; margin-top: 4px;" v-model="employee.email" @blur="handleBlurEmail($event.target.value)"><br>
                  <span style="color: red">{{ messageEmail }}</span>
                </div>
              </div>
            </div>
            <div class="tab-inf" :class="{'dialog-hide': infor}">
              <div class="content-tblEmployee">                   
                <table class="tblListEmployee" border="0" width="96%">
                    <thead>
                        <tr>                           
                            <th>SỐ TÀI KHOẢN</th>
                            <th>TÊN NGÂN HÀNG</th>
                            <th>CHI NHÁNH</th>
                            <th>TỈNH/TP CỦA NGÂN HÀNG</th> 
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                              <input type="text" style="width: 130px;" v-model="employee.bankAccountNumber">
                            </td>
                            <td>
                              <input type="text" style="width: 130px;" v-model="employee.bankName">
                            </td>
                            <td>
                              <input type="text" style="width: 130px;" v-model="employee.bankBranchName">
                            </td>
                            <td>
                              <input type="text" style="width: 130px;" v-model="employee.bankProvinceName">                         
                            <td>
                                <div class="dialog-icon-16 delete" title="Ctrl + Delete"></div>
                            </td>
                        </tr>
                    </tbody>  
                </table>                             
              </div>
              <div class="flex">
                <button class="add-line" title="Ctrl +Insert">Thêm dòng</button>
                <button class="add-line">Xóa hết dòng</button>
              </div>  
            </div>
          </div>
          <div class="footer">
            <div class="divide"></div>
            <div class="footer-btn">
              <button class="add-line" style="width: 67px; height: 36px; boder-radius: 4px;" @click="btnCloseClick">Hủy</button>
              <div class="btn-right">
                <button class="add-line" style="width: 67px; height: 36px; boder-radius: 4px;" @click="btnSaveClick">Cất</button>
                <button class="add-line color">Cất và Thêm</button>
              </div>
            </div>
          </div>
      </div>
      <Popup v-if="valuePopup" @hidePopupNotLoad="valuePopup = false" :message="message"/>
    </div>
    
  </div>
</template>
<script>
import axios from 'axios'
import Popup from './Popup.vue'
export default {
  components:{
    Popup
  },

  props:{
    state:{ type: Boolean, selector: false},          // Trạng thái hiển thị Dialog
    employee:{ type: Object, selector: null},         // Đối tượng nhân viên được truyền từ EmployeeList sang
    flag:{ type: String, selector: null},             // Cờ để check giá trị nút Thêm mới hay Sửa
  },
  data() {
    return {
      infor: true,                // Giá trị hiển thị tab Liên hệ hay tài khoản ngân hàng              
      messageEmail: null,         // Message lỗi
      departments: [],          // Mảng phòng ban
      message: null,
      valuePopup: false,
    }
  },
  methods: {

    /* 
    Click đóng Dialog
    CreatedBy: LMDuc (11/05/2021)
    */
    btnCloseClick(){
      this.messageEmail = null;     
      // this.employee = null
      this.$emit('hideDialogNotLoad');
    },

    /* 
    Click để hiển thị Tab Liên hệ hay tab tài khoản ngân hàng
    CreatedBy: LMDuc (11/05/2021)
    */
    btnInforClick(){
      this.infor = true;
    },

    /* 
    Click để hiển thị Tab Liên hệ hay tab tài khoản ngân hàng
    CreatedBy: LMDuc (11/05/2021)
    */
    btnBankClick(){
      this.infor = false;
    },

    /* 
    Click Save nhân viên
    CreatedBy: LMDuc (11/05/2021)
    */
    btnSaveClick(){
      // Kiểm tra nút Thêm hay Sửa
      //let employeeCode = this.employee.employeeCode;
      //let fullName = this.employee.fullName;
      // let departmentName = this.
      // if(){

      // }
      if(this.flag == "add"){       
        axios.post('https://localhost:44320/api/v1/Employees', this.employee).then(res =>{
          console.log(res.data);
          console.log(this.message);
          this.$emit('hideDialog');
        }).catch(res =>{
          // Lấy ra message lỗi
          console.log(res.response.data.devMsg);
          this.message = res.response.data.devMsg;
          // show popup
          this.valuePopup = true;

          console.log(this.message);
          console.log(this.employee);
          // this.$emit('hideDialog');
        })
      }
      // Kiểm tra nút Thêm hay Sửa
      else if(this.flag == "edit"){
        axios.put('https://localhost:44320/api/v1/Employees/' + this.employee.employeeId, this.employee).then(res =>{
          console.log(res.data);         
          this.$emit('hideDialog');
        }).catch(res =>{
          console.log(res.data);
          console.log(this.employee)
          this.$emit('hideDialog');
        })
      }
    },

    /* 
    Xử lý blur khỏi Input Email
    CreatedBy: LMDuc (11/05/2021)
    */
    handleBlurEmail(ev) {
      if (/^(([^<>()\\.,;:\s@"]+(\.[^<>()\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,24}))$/.test(ev)) {        
        this.messageEmail = "";
      } else if (ev == "") {
        this.messageEmail = "Bắt buộc nhập trường này!";
      } else {
        this.messageEmail = "Email Không đúng định dạng!";
      }     
    },    
  },
  mounted: function(){
    axios.get("https://localhost:44320/api/v1/Departments").then(res =>{
      this.departments = res.data;
    }).catch(res =>{
      console.log(res);
    })
  }
};
</script>
<style scoped>
.flex {
  display: flex !important;
}
.dialog-hide {
  display: none;
}
.dialog {
  border: 1px solid #bbb;
}

.dialog .model {
  width: 100%;
  background: rgba(0, 0, 0, 0.4);
  position: fixed;
  left: 0;
  top: 0;
  height: 100%;
  z-index: 98;
  transition: all 0.25s ease;
  opacity: 1;
}

.dialog .dialog-box {
  z-index: 100;
  border-radius: 4px;
  width: 900px;
  height: 625px;
  position: absolute;
  top: 50%;
  left: 43%;
  transform: translate(-50%, -50%);
  background-color: white;
  box-shadow: 0 5px 20px 0 rgb(0 0 0 / 10%);
}

.dialog-box .dialog-header {
  padding: 20px 12px 20px 32px;
  display: flex;
  align-items: center;
  justify-content: space-between;
  width: 90%;
}
.dialog-header .title {
}
.title-dialog {
  font-size: 24px;
  color: #111111;
}
.component {
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 0 20px;
}
.item-close {
  position: absolute;
  top: 0;
  right: 0;
  height: 70.4px;
  width: 78px;
  display: flex;
  padding: 12px;
}
.dialog-icon {
  background: url("../../../assets/Sprites.5f05e81f.svg") no-repeat;
  cursor: pointer;
  min-width: 24px;
  min-height: 24px;
  height: 24px;
  width: 24px;
}
.dialog-icon-16 {
  background: url("../../../assets/Sprites.5f05e81f.svg") no-repeat;
  cursor: pointer;
  min-width: 16px;
  min-height: 16px;
  height: 16px;
  width: 16px;
}
.help {
  background-position: -89px -144px;
}
.close {
  background-position: -144px -144px;
}

.dialog-content{
    transition: all .23s ease .1s;
    flex-direction: column;
    display: flex;
    overflow: auto;
    overflow-y: visible;
    padding: 0 32px 20px;
}
.employee-inf{
    width: 100%;
    height: 213px;
    display: flex;
    align-items: center;
}
.inf-left{
    padding-bottom: 12px;
    width: 50%;
    height: 100%;
    padding: 0 26px 0 0;
}
.row-1{
    width: 100%;
    height: 70px;
    display: flex;
}
.code{
    width: 160px;
    height: 70px;
}
.name{
    width: 235px;
    height: 70px;
}
.phone{
    width: 197px;
    height: 70px;
}
.position{
    width: 392px;
    height: 70px;
}
.place{
    width: 418px;
    height: 70px;
}
.text{
    font-weight: 700;
    color: #111111;
}
.dateofbirth{
  width: 170px;
  height: 70px;
}
.gender{
  padding-left: 10px;
  width: 251px;
  height: 70px;
}
.radio{
  display: flex;
  align-items: center;
}
.input-radio{  
  width: 20px;
  margin-right: 10px;
}
/* input[type='radio']:after {
        width: 10px;
        height: 10px;
        border-radius: 10px;
        top: 9px;
        left: 3px;
        position: relative;
        background-color: #2ca01c;
        content: '';
        display: inline-block;
        visibility: visible;
        border: 2px solid #2ca01c;
    }

input[type='radio']:checked:after {
        width: 10px;
        height: 10px;
        border-radius: 10px;
        top: 9px;
        left: 3px;
        position: relative;
        background-color: #2ca01c;
        content: '';
        display: inline-block;
        visibility: visible;
        border: 2px solid #2ca01c;
}  */
.select-tab{
  height: 226px;
  width: 100%;
}
.tab{
  height: 32px;
  width: 100%;
  display: flex;
}
.tab-inf{
  height: 192px;
  width: 834px;
  border: 1px solid #c9ccd2;
}
.inf{
  width: 64px;
  height: 100%;
  padding: 0 8px;
  font-size: 13px;
  color: #111111;
  border: none;
  border-top: 1px solid #c9ccd2;
  border-right: 1px solid #c9ccd2;
  border-left: 1px solid #c9ccd2;
  outline: none;
  background-color: white;
}
.inf:hover{
  color: #019160;
}
.bank{
  padding: 0 8px;
  height: 100%;
  width: 148px;
  margin-left: 2px;
  border: none;
  border-top: 1px solid #c9ccd2;
  border-left: 1px solid #c9ccd2;
  border-right: 1px solid #c9ccd2;
  outline: none;
  background-color: white;
}
.bank:hover{
  color: #019160;
}
.content-tblEmployee{
  height: 145px;
  overflow-y: auto; 
}
.delete {
    background-position: -464px -312px;
}
.add-line{
  border: 1px solid #c9ccd2;
  width: 109px;
  height: 24px;
  background-color: white;
  font-weight: 700;
  margin-left: 20px;
  cursor: pointer;
}

.footer{
  height: 89px;
  width: 836px;
}
.divide{
  width: 100%;
    border-top: 1px solid #e0e0e0;
    margin: 32px 0 20px;
    position: relative;
}
.footer-btn{
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.color{
  height: 36px;
  color: white;
  background-color: #35bf22;
  border-radius: 4px;
  border: none;
  outline: none;
}
.color:hover{
  background-color: #3ff128;
}
.input-error{
  border: 1px solid red;
}
</style>