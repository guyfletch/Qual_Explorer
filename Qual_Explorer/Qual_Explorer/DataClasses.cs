using System;
using System.Collections.Generic;
using System.Text;

namespace Qual_Explorer
{
    public class Area
    {
        public string AreaName { get; set; }
        public string Description { get; set; }
        public List<Method> Methods { get; set; }

        public override string ToString()
        {
            return AreaName;
        }
    }
    public class Method
    {
        public string MethodName { get; set; }
        public string Description { get; set; }
        public string Example { get; set; }
        public string Reason { get; set; }
        public List<string> Filters { get; set; }

        public override string ToString()
        {
            return MethodName;
        }
    }
}
