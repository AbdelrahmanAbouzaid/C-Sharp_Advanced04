using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        public int EmploueeID { get; set; }
        public DateTime BirthDate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public int VacationStock
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            throw new NotImplementedException();
        }
        public void EndOfYearOperation()
        {
            throw new NotImplementedException();
        }
    }

    enum LayOffCause
    { ///Implement it YourSelf 
    }
    class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}
