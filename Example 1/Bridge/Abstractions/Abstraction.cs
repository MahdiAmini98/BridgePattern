using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgePattern.Example_1.Bridge.Implementors;

namespace BridgePattern.Example_1.Bridge.Abstractions
{
    public abstract class Abstraction
    {
        private readonly Implementor _implementor;

        protected Abstraction()
        {
            _implementor = new ConcreteImplementor();
        }
        public virtual void Function()
        {
            _implementor.Implementation();
        }
    }
     
    public class RefinedAbstraction : Abstraction
    {
        public override void Function()
        {
            base.Function();
        }
    }
}
