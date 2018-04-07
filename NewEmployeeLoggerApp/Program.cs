using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeLoggerApp {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("This app is going to log new employees being created into a log file.");

            Employee.EmployeeCreated += EmployeeLogger.NewEmployeeAdded;

            var employee1 = Employee.CreateEmployee("Harry", "emmail@email.com", "Home address");
            var employee2 = Employee.CreateEmployee("Jane", "emmail2@email.com", "Home address2");

            using(StreamReader sr = new StreamReader(@"C:\MyStuff\AppLogs\NewEmployee.txt")){
                var readFile = sr.ReadToEnd();
                Console.WriteLine(readFile);
                Console.ReadLine();
            }
        }
    }
}
