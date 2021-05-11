using MISA.AMIS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Core.Interfaces.Services
{
    /// <summary>
    /// interface Employee repository
    /// </summary>
    /// CreatedBy: LMDuc (11/05/2021)
    public interface IEmployeeService:IBaseService<Employee>
    {
        /// <summary>
        /// Lấy giá trị mã nhân viên lớn nhất
        /// </summary>
        /// <returns>Giá trị mã nhân viên lớn nhất</returns>
        /// CreatedBy: LMDuc (11/05/2021)
        public string GetMaxEmployeeCode();
        /// <summary>
        /// Kiểm tra trùng mã nhân viên
        /// </summary>
        /// <param name="employeeCode">mã nhân viên</param>
        /// <returns>
        /// true - mã nhân viên đã có trong cơ sở dữ liệu
        /// false - không bi trùng
        /// </returns>
        /// CreatedBy: LMDuc (11/05/2021)
        public bool CheckEmployeeCodeExist(string employeeCode);
        /// <summary>
        /// Phân trang
        /// </summary>
        /// <param name="pageSize">số bản ghi</param>
        /// <param name="pageIndex">vị trí trang</param>
        /// <param name="filter"></param>
        /// <returns>Danh sách bản ghi</returns>
        public Pagging<Employee> GetEmployees(int pageSize, int pageIndex, string filter);
    }
}
