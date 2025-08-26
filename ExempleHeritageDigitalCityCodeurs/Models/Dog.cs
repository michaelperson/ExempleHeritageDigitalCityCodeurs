using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleHeritageDigitalCityCodeurs.Models
{
    public class Dog : Animal
    {
        public void ChangeNameWhenIPlay(string newName)
        {
            this.Name = newName; 
        }

        public void SetNumberOfPaws(int nb)
        {
            if(nb<2) Console.WriteLine("Buy wheels!");
            else
                NbPaws = nb;
        }
        public override void MakeNoise()
        {
            Console.WriteLine("The dog says : Wouf Wif argggggh");
        }


        public override string ToString()
        {
            return $"Je suis un chien et {base.ToString()} ";
        }
    }
}
