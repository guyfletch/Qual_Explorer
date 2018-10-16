using System;
using System.Collections.Generic;
using System.Text;

namespace Qual_Explorer
{
    public sealed class DataStore
    {
        private static readonly Lazy<DataStore> lazy = new Lazy<DataStore>(() => new DataStore());
        public static DataStore Instance
        {
            get { return lazy.Value; }
        }
        public List<Area> Methods { get; set; }
        public List<Area> Techniques { get; set; }
        public List<Method> Accreds { get; set; }
        private DataStore()
        {
            var area1Methods = new List<Method>
            {
                new Method { MethodName = "Test1", Description="First description", Example="Like this", Reason="Blah blah", Filters=new List<string>{"a","b"} },
                new Method { MethodName = "Test2", Description="Second description", Example="Like this", Reason="Blah blah", Filters=new List<string>{"b","c"} },
                new Method { MethodName = "Test3", Description="Third description", Example="Like this", Reason="Blah blah", Filters=new List<string>{"c","d"} },
            };
            var area1 = new Area() { Description = "First area", AreaName = "Area1", Methods = area1Methods };

            var area2Methods = new List<Method>
            {
                new Method { MethodName = "Test4", Description="First description", Example="Like this", Reason="Blah blah", Filters=new List<string>{"d","e"} },
                new Method { MethodName = "Test5", Description="Second description", Example="Like this", Reason="Blah blah", Filters=new List<string>{"e","f"} },
                new Method { MethodName = "Test6", Description="Third description", Example="Like this", Reason="Blah blah", Filters=new List<string>{"f","g"} },
            };
            var area2 = new Area() { Description = "Second area", AreaName = "Area2", Methods = area2Methods };

            var area3Methods = new List<Method>
            {
                new Method { MethodName = "Test7", Description="First description", Example="Like this", Reason="Blah blah", Filters=new List<string>{"g","h"} },
                new Method { MethodName = "Test8", Description="Second description", Example="Like this", Reason="Blah blah", Filters=new List<string>{"h","i"} },
                new Method { MethodName = "Test9", Description="Third description", Example="Like this", Reason="Blah blah", Filters=new List<string>{"i","a"} },
            };
            var area3 = new Area() { Description = "Third area", AreaName = "Area3", Methods = area3Methods };

            var search = new Area { Description = "Search", AreaName = "Search", Methods = new List<Method>() };

            Methods = new List<Area>
            {
                area1,
                area2,
                area3,
                search
            };

            Techniques = new List<Area>
            {
                area1,
                area2,
                area3,
                search
            };
            Accreds = new List<Method>
            {
                new Method { MethodName = "Level 1", Description="First description", Example="Like this", Reason="Blah blah" },
                new Method { MethodName = "Level 2", Description="Second description", Example="Like this", Reason="Blah blah" },
                new Method { MethodName = "Level 3", Description="Third description", Example="Like this", Reason="Blah blah" },
            };
        }
    }
}