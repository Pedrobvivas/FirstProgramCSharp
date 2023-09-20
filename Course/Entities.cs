using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Globalization;

namespace Course
{
    public class Entities
    {
        public int id;
        public string name;
        public double salary;
        public Entities() { 
        }
    
        public Entities(int id, string name, double salary)
        {
            this.id = id;
            this.name = name; 
            this.salary = salary;
        }
        
        public double calculate( double value)
        {
            return salary += value / 100;
        }
        public override String ToString()
        {
            return id +
                ", "
                + name + ", "
                + salary;
        }
    }
}

