using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library

{
    public class RedheadDuck : Duck, IFlyable, IQuackable
    {
        public override string display()
        {
            return "display " + this.GetType();
        }
        public string Quack()
        {
            return "Quack" + " " + this.GetType();
        }
        public string Fly()
        {
            return "Fly" + " " + this.GetType();
        }
    }
}
