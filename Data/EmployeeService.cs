using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoServerGridTestrApp9.Data
{
    public class EmployeeService
    {
        public Task<Employee[]> GetEmployees()
        {
            return Task.FromResult(new Employee[] { 
                new Employee() 
                { 
                    ID = "10001",
                    ChtName = "吳俊毅",
                    Title = "工程師"
                },
                new Employee()
                {
                    ID = "10002",
                    ChtName = "瑪莉",
                    Title = "PM"
                },
                new Employee()
                {
                    ID = "10003",
                    ChtName = "大衛艾倫",
                    Title = "經理"
                }
            });
        }
    }
}
