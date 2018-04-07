using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeLoggerApp {
    class EmployeeLogger {

        private void LogNewEmployee(Employee employee){
            string path = @"C:\MyStuff\AppLogs\NewEmployee.txt";
            using (StreamWriter sr = new StreamWriter(path, true)){
                string log = $"{employee.Name} has been created at {DateTime.Now} with ID of {employee.EmployeeId}";
                sr.WriteLine(log);
            }
        }

        public void NewEmployeeAdded(object sender, EventArgs e){
            LogNewEmployee(e.Employee);
        }
    }
}
