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

        public override string ToString()
        {
            return $"Id: {id} Name: {name}";
        }
    }

}
