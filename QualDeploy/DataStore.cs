using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace QualDeploy
{
    public class DataStore
    {
        private static readonly Lazy<DataStore> lazy = new Lazy<DataStore>(() => new DataStore());
        public static DataStore Instance
        {
            get { return lazy.Value; }
        }
        public List<Area> Methods { get; set; }
        public List<Area> Techniques { get; set; }
        public List<Method> Accreds { get; set; }

        public DataStore()
        {
            Methods = new List<Area>();
            Techniques = new List<Area>();
            Accreds = new List<Method>();
            try
            {
                var starring = new Method();
                starring.MethodName = "Starring/ rating";
                starring.Description = "Giving a score out of 10 or star rating out of 5";
                starring.Reason = "Helping produce a hierarchy of the stimulus";
                starring.Example =
                    " To understand an overall hierarchy of cola prototypes, we initially made everyone give a score out of 10, in order to understand drivers of being loved or hated";
                starring.MethodImagePath = "starrating.jpg";
                starring.Filters = new List<string> {"rate", "conscious", "easy"};
                starring.Area = "Area 1";

                var pretask = new Method();
                pretask.MethodName = "Online pre-task";
                pretask.Description =
                    "Couple of questions are posted online 4 days before a face-to-face group, using free software like Ning.com";
                pretask.Reason = "Helping produce a hierarchy of the stimulus";
                pretask.Example = "Intro question: Lets all introduce ourselves and share a little about what's going on in our lives. Q1: Share your thoughts about your smile. (if topic of group is toothcare)";
                pretask.MethodImagePath = "onlinepretask.jpg";
                pretask.Filters = new List<string> {"rapport", "pre-task", "conscious","easy"};
                pretask.Area = "Area 1";

                var pairedintro = new Method();
                pairedintro.MethodName = "Paired intros";
                pairedintro.Description = "Pair up consumers, get them to find out about their partner and introduce them back to the group";
                pairedintro.Reason = "Great ice-breaker, and the background noise helps them relax into the group environment";
                pairedintro.Example = "In a personal care group, we needed to ensure the group became comfortable with each other quickly and gave people confidence in talking in a group environment";
                pairedintro.MethodImagePath = "pairedintros.jpg";
                pairedintro.Filters = new List<string> {"rapport", "conscious", "group", "easy"};
                pairedintro.Area = "Area 1";

                var area1 = new Area();
                area1.AreaName = "Area 1";
                area1.Description = "First area";
                area1.AreaImagePath = "defaultpicture.png";
                area1.Methods.Add(starring);
                area1.Methods.Add(pretask);
                area1.Methods.Add(pairedintro);
                Techniques.Add(area1);
                //var assembly = IntrospectionExtensions.GetTypeInfo(typeof(DataStore)).Assembly;
                //Stream stream = assembly.GetManifestResourceStream("QualDeploy.data.txt");

                //string text = "";
                //using (var reader = new System.IO.StreamReader(stream))
                //{
                //    text = reader.ReadToEnd();
                //    var lines = Regex.Split(text, "\r\n");
                //    var techs = new List<Method>();
                //    var meths = new List<Method>();
                //    var accreds = new List<Method>();
                //    foreach (var l in lines)
                //    {
                //        var elements = l.Split(';');
                //        if (elements[0].ToLower() == "method")
                //        {
                //            var m = new Method(elements[7]);
                //            m.Area = elements[1];
                //            m.MethodName = elements[2];
                //            m.Description = elements[3];
                //            m.Example = elements[4];
                //            m.Reason = elements[5];
                //            m.Filters = elements[6].Split(',').ToList();
                //            meths.Add(m);
                //        }

                //        if (elements[0].ToLower() == "technique")
                //        {
                //            var t = new Method(elements[7]);
                //            t.Area = elements[1];
                //            t.MethodName = elements[2];
                //            t.Description = elements[3];
                //            t.Example = elements[4];
                //            t.Reason = elements[5];
                //            t.Filters = elements[6].Split(',').ToList();
                //            techs.Add(t);
                //        }

                //        if (elements[0].ToLower() == "accreditation")
                //        {
                //            var a = new Method(elements[7]);
                //            a.Area = elements[1];
                //            a.MethodName = elements[2];
                //            a.Description = elements[3];
                //            a.Example = elements[4];
                //            a.Reason = elements[5];
                //            a.Filters = elements[6].Split(',').ToList();
                //            accreds.Add(a);
                //        }
                //    }

                //    Accreds = accreds.OrderBy(x => x.Area).ToList();
                //    var methareas = meths.Select(x => x.Area).Distinct().ToList();
                //    foreach (var area in methareas)
                //    {
                //        var aDetails = area.Split('_');
                //        var ara = new Area(aDetails[2]);
                //        ara.AreaName = aDetails[0];
                //        ara.Description = aDetails[1];
                //        ara.Methods.AddRange(meths.Where(x => x.Area == area));
                //        Methods.Add(ara);
                //    }
                //    var techareas = techs.Select(x => x.Area).Distinct().ToList();
                //    foreach (var area in techareas)
                //    {
                //        var aDetails = area.Split('_');
                //        var ara = new Area(aDetails[2]);
                //        ara.AreaName = aDetails[0];
                //        ara.Description = aDetails[1];
                //        ara.Methods.AddRange(techs.Where(x => x.Area == area));
                //        Techniques.Add(ara);
                //    }

                //}

            }
            catch (Exception ex)
            {
                throw new Exception("dataload", ex);
            }

        }
    }
}
