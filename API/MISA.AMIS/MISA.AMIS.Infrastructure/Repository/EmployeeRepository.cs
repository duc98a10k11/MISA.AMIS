
using Dapper;
using MISA.AMIS.Core.Entities;
using MISA.AMIS.Core.Interfaces.Repositories;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMIS.Infrastructure.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository() 
        {

        }

        public bool CheckEmployeeCodeExist(string employeeCode)
        {
            using (dbConnection = new MySqlConnection(connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("EmployeeCode", employeeCode);
                // thực hiện query
                var result = dbConnection.QueryFirstOrDefault<bool>($"Proc_CheckEmployeeCodeExist",param:parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public string GetMaxEmployeeCode()
        {
            using (dbConnection = new MySqlConnection(connectionString))
            {
                // thực hiện query
                var result = dbConnection.QueryFirstOrDefault<string>($"Proc_GetMaxEmployeeCode", commandType: CommandType.StoredProcedure);
                return result;
            }
        }
    }
}
