using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Core.Exceptions
{
    class EmployeeException:Exception
    {
        public  EmployeeException(string msg) : base(msg)
        {

        }

        /// <summary>
        /// bắt lỗi mã khách hàng để trống
        /// </summary>
        /// <param name="employeeCode">mã nhân viên</param>
        /// CreatedBY: LMDuc (07/05/2021)
        public static void CheckEmployeeCodeEmpty(string employeeCode)
        {
            if (string.IsNullOrEmpty(employeeCode))
            {
                var response = new
                {
                    devMsg = "Mã nhân viên không được phép để trống",
                    MISACode = "001"
                };
                throw new EmployeeException("Mã nhân viên không được phép để trống.");
            }
        }
    }
}
