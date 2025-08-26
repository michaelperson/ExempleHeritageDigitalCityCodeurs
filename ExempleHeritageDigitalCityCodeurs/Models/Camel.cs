using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleHeritageDigitalCityCodeurs.Models
{
    public class Camel : Animal
    {
        //Nombre de bosses
        private int nbHump;

        public int NbHump
        {
            get
            {
                return nbHump;
            }

            set
            {
                nbHump = value;
            }
        }

        public override bool IsAlive
        {
            get
            {
                return true;

            }
        }

        public override void Move()
        {
            Console.WriteLine("I move like a ship on a stormy sea whit the wind whispered my skin!");
        }

        public override string ToString()
        {
            return $"Je suis un chameau {base.ToString()}";
        }
    }
}
