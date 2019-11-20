using System;
using System.Collections.Generic;

namespace tccxamarin.Models
{
    public class BenchmarkTest
    {
        public string name { get; set; }
        public fields fields { get; set; }
        public BenchmarkTest(string name, fields fields)
        {
            this.name = name;
            this.fields = fields;
        }
    }

    public class fields
    {
        public names names { get; set; }

        public fields(names names)
        {
            this.names = names;
        }
    }

    public class names
    {
        public arrayValue arrayValue { get; set; }

        public names(arrayValue arrayValue)
        {
            this.arrayValue = arrayValue;
        }
    }

    public class arrayValue
    {
        public List<UserBenchmark> values { get; set; }

        public arrayValue(List<UserBenchmark> values) => this.values = values;
    }

    public class UserBenchmark
    {
        public string stringValue { get; set; }

        public UserBenchmark(string stringValue)
        {
            this.stringValue = stringValue;
        }
    }
}
