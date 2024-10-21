using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People;
public class Person
{
    private int _age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age
    {
        get => _age; set
        {
            if (value > 0)
            {
                _age = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
    }
    public override string ToString()
    {
        return $"Name: {this.Name}, Age: {this.Age}";
    }
}
