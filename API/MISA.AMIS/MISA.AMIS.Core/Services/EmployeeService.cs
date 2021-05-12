using MISA.AMIS.Core.Entities;
using MISA.AMIS.Core.Exceptions;
using MISA.AMIS.Core.Interfaces.Repositories;
using MISA.AMIS.Core.Interfaces.Services;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Core.Services
{
    /// <summary>
    /// dịch vụ khách hàng
    /// </summary>
    public class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository) : base(employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        /// <summary>
        /// Kiểm tra trùng mã nhân viên
        /// </summary>
        /// <param name="employeeCode">mã nhân viên</param>
        /// <returns>
        /// true - mã nhân viên đã có trong cơ sở dữ liệu
        /// false - không bi trùng
        /// </returns>
        /// CreatedBy: LMDuc (11/05/2021)
        public bool CheckEmployeeCodeExist(string employeeCode)
        {
            return _employeeRepository.CheckEmployeeCodeExist(employeeCode);
        }
        /// <summary>
        /// Kiểm tra trùng số chứng minh thư
        /// </summary>
        /// <param name="identifyNumber">số chứng minh thư</param>
        /// <returns>
        /// true - số chứng minh thư bị trùng
        /// false - không bị trùng
        /// </returns>
        /// CreatedBy : LMDuc (12/05/2021)
        public bool CheckIdentifyNumberExist(string identifyNumber)
        {
            return _employeeRepository.CheckIdentifyNumberExist(identifyNumber);
        }

        /// <summary>
        /// Kiểm tra trùng số điện thoại
        /// </summary>
        /// <param name="phoneNumber">số điện thoại</param>
        /// <returns>
        /// - true : số điện thoại bị trùng
        /// - false: không bị trùng
        /// </returns>
        /// CreatedBy: LMDuc (12/05/2021)
        public bool CheckPhoneNumberExist(string phoneNumber)
        {
            return _employeeRepository.CheckPhoneNumberExist(phoneNumber);
        }

        /// <summary>
        /// Phân trang
        /// </summary>
        /// <param name="pageSize">số bản ghi có trong trang</param>
        /// <param name="pageIndex">vị trí của trang</param>
        /// <param name="filter">lọc theo tên</param>
        /// <returns>Danh sách các bản ghi</returns>
        /// CreatedBy: LMDuc (12/05/2021)
        public Pagging<Employee> GetEmployees(int pageSize, int pageIndex, string filter)
        {
            if (pageIndex <= 0 || pageSize <= 0)
            {
                throw new EmployeeException(Properties.Resources.Msg_Param_Error);
            }
            return _employeeRepository.GetEmployees(pageSize, pageIndex, filter);
        }

        /// <summary>
        /// Lấy giá trị mã nhân viên lớn nhất
        /// </summary>
        /// <returns>Giá trị mã nhân viên lớn nhất</returns>
        /// CreatedBy: LMDuc (11/05/2021)
        public string GetMaxEmployeeCode()
        {
            return _employeeRepository.GetMaxEmployeeCode();
        }
        /// <summary>
        /// validate dữ liệu: mã nhân viên, số chứng minh thư, số điện thoại
        /// </summary>
        /// <param name="employee">object nhân viên</param>
        /// CreatedBy: LMDuc (12/05/2021)
        protected virtual void CustomValidate(Employee employee)
        {
            // Check trùng mã code
            if (CheckEmployeeCodeExist(employee.EmployeeCode))
            {
                throw new EmployeeException(Properties.Resources.Msg_Code_Exist);
            }
            // kiểm tra trùng số chứng minh thư
            if (CheckIdentifyNumberExist(employee.IdentityNumber))
            {
                throw new EmployeeException(Properties.Resources.Msg_IdentifyNumber);
            }
            //kiểm tra trùng số điện thoại
            if (CheckPhoneNumberExist(employee.PhoneNumber))
            {
                throw new EmployeeException(Properties.Resources.Msg_PhoneNumber);
            }
        }
    }
}
