using System;
using System.Collections.Generic;
using System.Text;

namespace Worker.Entities
{
    class Department
    {
        public string Name { get; private set; }

        public Department(string name)
        {
            Name = name;
        }
    }
}
