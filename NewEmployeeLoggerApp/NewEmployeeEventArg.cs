using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeLoggerApp {
    public class NewEmployeeEventArg {

        public Employee Employee { get; set; }

        public NewEmployeeEventArg(Employee employee){
            this.Employee = employee;
        }
    }
}
