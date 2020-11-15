  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08het.Entities
{
    public class BallFactory
    {
        public Toy CreateNew() {
            return new Toy();    
        }  

    }
}
