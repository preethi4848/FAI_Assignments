using System;
using System.IO;

namespace Week1_Assignments
{
    interface IDataComponent
    {
        void Employee();
    }
    [Serializable]
    class Employee
    {
        static int empNo = 1000;
        public Employee()
        {
            EmpID = ++empNo;
        }

        public Employee(int id)
        {
            EmpID = id;
        }
        public int EmpID { get; private set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public int EmpSalary { get; set; }
        public override string ToString()
        {
            return $"{EmpID}, {EmpName}, {EmpAddress}, {EmpSalary}";
        }
    }
    class Assignment14
    {
        public static void Main(string[] args)
        {

        }
    }
}