using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleHeritageDigitalCityCodeurs.Models
{
    public class Animal
    {
        private bool _isAlive;
        private int _nbPaws;
        private string _name;
        private string _species;

        public virtual bool IsAlive
        {
            get
            {
                return _isAlive;
            }

             set
            {
                _isAlive = value;
            }
        }

        public int NbPaws
        {
            get
            {
                return _nbPaws;
            }

            protected set
            {
                _nbPaws = value;
            }
        }

        protected string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Species
        {
            get
            {
                return _species;
            }

            set
            {
                _species = value;
            }
        }

        public virtual void Move()
        {
            Console.WriteLine("The animal is moving");
        }
        public void Stop()
        {
            Console.WriteLine("The animal is stopping");
        }

        public void Eat()
        {
            Console.WriteLine("The animal is eating");
        }

        public void Dead()
        {
            Console.WriteLine("The animal is dead");
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine("The animal ???");
        }

        public override string ToString()
        {
            string type = this.GetType().Name;
            return $"({type})je m'appelle {Name}";
        }
    }
}
