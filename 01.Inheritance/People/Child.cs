using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person;
public class Child : Person
{
    private int _age;
    public int Age { get => _age; set
        {
            if (value > 15)
            {
                throw new ArgumentOutOfRangeException(nameof(Age));
            }
            _age = value;
        }
    }

    public Child(string name, int age) : base(name, age)
    {}
}
