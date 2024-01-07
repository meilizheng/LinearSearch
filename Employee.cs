using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class Employee
    {
        //filed
        string _name;
        string _department;
        string _position;


        //Construction
        public Employee(string name, string department, string position)
        {
            _name = name;
            _department = department;
            _position = position;
        }

        //Property
        public string Name { get => _name; set => _name = value; }
        public string Department { get => _department; set => _department = value; }
        public string Position { get => _position; set => _position = value; }

        public override string ToString()
        {
            return $"{_name} {_department} {_position}";
        }
    }
}
