using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QualDeploy
{
    public class Area
    {
        public Area()
        {
            Methods = new List<Method>();
            AreaImagePath = "defaultpicture.png";
        }
        public Area(string imagePath)
        {
            Methods = new List<Method>();
            if (File.Exists(imagePath))
            {
                AreaImagePath = imagePath;
            }
            else
            {
                AreaImagePath = "defaultpicture.png";
            }
        }
        public string AreaName { get; set; }
        public string Description { get; set; }
        public List<Method> Methods { get; set; }
        public string AreaImagePath { get; set; }
        public override string ToString()
        {
            return AreaName;
        }
    }
    public class Method
    {
        public Method()
        {
            Filters = new List<string>();
            MethodImagePath = "defaultpicture.png";
        }
        public Method(string imagePath)
        {
            Filters = new List<string>();
            if (File.Exists(imagePath))
            {
                MethodImagePath = imagePath;
            }
            else
            {
                MethodImagePath = "defaultpicture"; //TODO add a default picture
            }
        }
        public string Area { get; set; }
        public string MethodName { get; set; }
        public string Description { get; set; }
        public string Example { get; set; }
        public string Reason { get; set; }
        public List<string> Filters { get; set; }
        public string MethodImagePath { get; set; }
        public override string ToString()
        {
            return MethodName;
        }
    }
}
