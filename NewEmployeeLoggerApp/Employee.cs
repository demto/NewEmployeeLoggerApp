using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeLoggerApp {
    class Employee {

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        private static int employeeCounter = 0;

        public event EventHandler<EventArgs> employeeCreated;

        private Employee(string name, string email, string address) {
            EmployeeId = employeeCounter++;
            Name = name;
            Email = email;
            Address = address;
            OnEmployeeCreated(Name, EmployeeId);
        }

        public static Employee CreateEmployee(string name, string email, string address){
            var employee = new Employee(name, email, address);
            return employee;
        }

        protected virtual void OnEmployeeCreated(string name, int id){
            employeeCreated?.Invoke(this, new EventArgs());
        }
    }
}
