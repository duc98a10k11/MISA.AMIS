using MISA.AMIS.Core.AttributeCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Core.Entities
{
    /// <summary>
    /// Thông tin nhân viên
    /// </summary>
    /// CreatedBy: LMDuc (07/05/2021)
    public class Employee
    {
        /// <summary>
        /// id nhân viên
        /// </summary>
        public Guid? EmployeeId { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        [MISARequired] // validate chuỗi rỗng
        [MISAMaxLength(20, msg: "")] // validate độ dài tối đa nhập vào
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Họ và tên
        /// </summary>
        [MISARequired] // validate chuỗi rỗng
        public string FullName { get; set; }

        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Giới tính
        /// </summary>
        public int Gender { get; set; }

        /// <summary>
        /// Số chứng minh thư/căn cước công dân
        /// </summary>
        [MISARequired] // validate chuỗi rỗng
        public string IndentifyNumber { get; set; }

        /// <summary>
        /// Ngày cấp
        /// </summary>
        public DateTime DateOfIndentify { get; set; }

        /// <summary>
        /// Nơi cấp
        /// </summary>
        public string PlaceOfIdentify { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        [MISARequired] // validate chuỗi rỗng
        public string PhoneNumber { get; set; }

        /// <summary>
        /// số tài khoản ngân hàng
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Tên vị trí, chức vụ
        /// </summary>
        public string PositionName { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// id phòng ban
        /// </summary>
        public Guid? DepartmentId { get; set; }

        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Ngày chỉnh sửa
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Người chỉnh sửa
        /// </summary>
        public string ModifiedBy { get; set; }
    }
}
