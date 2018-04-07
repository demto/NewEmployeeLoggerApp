using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeLoggerApp {
    public class EmployeeLogger {

        private static void LogNewEmployee(Employee employee){
            string path = @"C:\MyStuff\AppLogs\NewEmployee.txt";
            using (StreamWriter sr = new StreamWriter(path, true)){
                string log = $"{employee.Name} has been created at {DateTime.Now} with ID of {employee.EmployeeId}";
                sr.WriteLine(log);
            }
        }

        public static void NewEmployeeAdded(object sender, NewEmployeeEventArg e){
            LogNewEmployee(e.Employee);
        }
    }
}
