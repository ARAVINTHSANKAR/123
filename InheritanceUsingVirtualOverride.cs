using System;

namespace day_3
{
    class InheritanceUsingVirtualOverride
    {
        public virtual void show()
        {
            Console.WriteLine("Lenovo");
        }
    }

    class Derivedclass : InheritanceUsingVirtualOverride
    {
        public override void show()
        {
            Console.WriteLine("Dell");

        }
    }

}
