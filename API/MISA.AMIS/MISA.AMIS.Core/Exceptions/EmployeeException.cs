using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Core.Exceptions
{
    public class EmployeeException:Exception
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
                    devMsg = Properties.Resources.devMsg,
                    MISACode = Properties.Resources.MISACode
                };
                throw new EmployeeException(Properties.Resources.devMsg);
            }
        }
    }
}
