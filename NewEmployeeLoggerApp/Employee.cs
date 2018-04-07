using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeLoggerApp {
    public class Employee {

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        private static int employeeCounter = 0;

        public static event EventHandler<NewEmployeeEventArg> EmployeeCreated;

        private Employee(string name, string email, string address) {
            EmployeeId = employeeCounter++;
            Name = name;
            Email = email;
            Address = address;

            OnEmployeeCreated(this);
        }

        public static Employee CreateEmployee(string name, string email, string address){
            var employee = new Employee(name, email, address);
            return employee;
        }

        protected virtual void OnEmployeeCreated(Employee employee){
            EmployeeCreated?.Invoke(this, new NewEmployeeEventArg(employee));
        }
    }
}
