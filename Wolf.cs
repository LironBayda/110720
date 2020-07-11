using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080720
{
    class Wolf:Dog
    {
        string _nameOfPack;
        public Wolf(string name, string nameOfPack, string favoriteFood) : base(name, favoriteFood)
        {
            _nameOfPack = nameOfPack;
        }

        public override string ToString()
        {
            return base.ToString() + $" nameOfPack: {_nameOfPack}"; ;
        }
    }
}
