using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleHeritageDigitalCityCodeurs.Models
{
    internal class Chiwawa : Dog
    {
        public override string ToString()
        {
            string info = base.ToString();
            return $"{info} - c'est Faux!!";
        }
    }
}
