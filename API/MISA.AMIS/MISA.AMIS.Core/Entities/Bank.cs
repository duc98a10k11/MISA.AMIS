using MISA.AMIS.Core.AttributeCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Core.Entities
{
    /// <summary>
    /// Thông tin ngân hàng
    /// </summary>
    /// CreatedBy: LMDuc (07/05/2021)
    public class Bank
    {
        /// <summary>
        /// id ngân hàng
        /// </summary>
        public Guid? BankId { get; set; }

        /// <summary>
        /// Tên ngân hàng
        /// </summary>
        [MISARequired] // validate chuỗi rỗng
        public string BankName { get; set; }

        /// <summary>
        /// Số ngân hàng
        /// </summary>
        public string BankNumber { get; set; }

        /// <summary>
        /// Chi nhánh
        /// </summary>
        public string Branch { get; set; }

        /// <summary>
        /// Thành phố
        /// </summary>
        public string BankCity { get; set; }

        /// <summary>
        /// Trạng thái
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// id nhân viên
        /// </summary>
        [MISARequired] // validate chuỗi rỗng
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Tên trạng thái
        /// </summary>
        public string StatusName { get; set; }
    }
}
