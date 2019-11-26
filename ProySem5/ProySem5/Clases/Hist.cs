using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;//libreria

namespace ProySem5.Clases
{
    class Hist
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        public string coin1 { get; set; }
        public string change1 { get; set; }
        public string coin2 { get; set; }    
        public string change2 { get; set; }


        public override string ToString()
        {
            return $"{coin1} - {change1} - {coin2} - {change2}";

        }
    }
}
