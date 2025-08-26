using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleHeritageDigitalCityCodeurs.Models
{
    public  class Cat: Animal
    {
        

        private int _papates;
         public new int NbPaws { 
            
            get { return _papates; } 
            
            set { _papates = value; } }


        public void SetMyName(string newName)
        {
            this.Name = newName;
        }

        public void SetNumberOfPaws()
        {
            Console.WriteLine("I HAVE 4 LEGSSSSSSSSS!!! ");
            NbPaws = 4;
        }


        public override void MakeNoise()
        {
            Console.WriteLine("The cat says : I'm a god!");
        }

        public override string ToString()
        {
            string VientDuParent = base.ToString();
            return $"Je suis un chat et {VientDuParent}";
        }
    }
}
