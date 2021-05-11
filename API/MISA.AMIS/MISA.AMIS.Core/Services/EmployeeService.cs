using MISA.AMIS.Core.Entities;
using MISA.AMIS.Core.Exceptions;
using MISA.AMIS.Core.Interfaces.Repositories;
using MISA.AMIS.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
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
        public EmployeeService(IEmployeeRepository employeeRepository) :base(employeeRepository)
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

        public Pagging<Employee> GetEmployees(int pageSize, int pageIndex, string filter)
        {
            throw new NotImplementedException();
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
        protected virtual void CustomValidate(Employee employee)
        {
            // Check trùng mã code
            // Khởi tạo giá trị
            var employeeCode = employee.EmployeeCode;
            //var employeeId = employee.EmployeeId;
            var checkCodeExist = CheckEmployeeCodeExist(employeeCode);
            // Kiểm tra trùng hay không
            if (checkCodeExist)
            {
                throw new EmployeeException(Properties.Resources.Msg_Code_Exist);
            }

        }
    }
}
