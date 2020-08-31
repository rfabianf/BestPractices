using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceWithInterfaces
{
    public class Dragon : IBird,ILizard
    {
        private Bird bird = new Bird();
        private Lizard lizard = new Lizard();
        private int weight;

        public int Weight { get { return weight; }
            set {
                weight = value;
                bird.Weight = value;
                lizard.Weight = value;
            } }

        public void Craw()
        {
            lizard.Craw();
        }

        public void Fly()
        {
            bird.Fly();
        }
    }

}
