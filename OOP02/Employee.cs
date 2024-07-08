using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP02
{
    internal class Employee
    {
        #region attributes
        private int id;
        private string name;
        private SecurityPrivilege securityLevel;
        private double salary;
        private Date hireDate;
        private Gender gender;
        #endregion
        #region constructors
        public Employee(int id,string name ,SecurityPrivilege sl ,double salary, Date hireDate, Gender gender)
        {
            this.id = id;
            this.name = name;
            securityLevel = sl;
            this.salary = salary;
            this.hireDate = hireDate;
            this.gender = gender;
        }
        #endregion
        #region methods
        public override string ToString()
        {
            return string.Format("{0} : {1}'s securityLevel is {2} , salary is {3} , hireDate is {4} and gender is {5}", id, name, securityLevel, salary, hireDate, gender);
        }
        #endregion
        #region getter
        public int GetId() { return id; }
        public string GetName() { return name; }
        public SecurityPrivilege GetSecurityLevel() {  return securityLevel; }
        public double GetSalary() { return salary; }
        public void GetHireDate(out int day , out int month ,out int year) 
        {
            day= hireDate.day;
            month= hireDate.month;
            year= hireDate.year;
        }
        public Gender GetGender() { return gender; }

        #endregion
        #region setter
        public void SetId(int id) {  this.id = id; }
        public void SetSecurityLevel(SecurityPrivilege sl) {  securityLevel = sl; }
        public void SetSalary(double sal) { salary = sal; }

        #endregion
        #region properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
        }
        public SecurityPrivilege SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Date HireDate
        {
            get { return hireDate; }
        }
        public Gender Gender
        {
            get { return gender; }
        }
        #endregion
    }
}
