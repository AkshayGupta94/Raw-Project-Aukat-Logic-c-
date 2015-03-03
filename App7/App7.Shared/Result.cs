using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    public class S0
    {
        public string papername { get; set; }
        public string @internal { get; set; }
        public string external { get; set; }
        public string total { get; set; }
        public int totaltotal { get; set; }
        public string credit { get; set; }
        public string sem { get; set; }
        public string appearyear { get; set; }
    }

    //public class S1
    //{
    //    public string papername { get; set; }
    //    public string @internal { get; set; }
    //    public string external { get; set; }
    //    public string total { get; set; }
    //    public int totaltotal { get; set; }
    //    public string credit { get; set; }
    //    public string sem { get; set; }
    //    public string appearyear { get; set; }
    //}
    public class lol
    {
        public List<S0> s0{get; set;}

    }

    public class Paper
    {
        public List<List<S0>> s0 { get; set; }
        
    }

    public class Result
    {
        public string rollnumber { get; set; }
        public string studentname { get; set; }
        public string college { get; set; }
        public string program { get; set; }
        public int batchyear { get; set; }
       // public Paper paper { get; set; }
    }
}
