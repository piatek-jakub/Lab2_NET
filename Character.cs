using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace Lab2_NET
{

    internal class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<string> images { get; set; }

        public List<string> uniqueTraits { get; set; }

        public List<string> jutsu { get; set; }

        public override string ToString()
        {
            string s = string.Empty;
            s += $"Id: {id}" + Environment.NewLine;
            s += $"Name: {name}" + Environment.NewLine;
            if(uniqueTraits!= null)
            {
                s += "Traits:" + Environment.NewLine;
                foreach (var trait in uniqueTraits)
                {
                    s += $"\t {trait}" + Environment.NewLine;
                }
            }
            return s;
        }
    }

}
