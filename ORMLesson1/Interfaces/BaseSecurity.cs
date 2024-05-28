using System;

namespace Interfaces
{
    public class BaseSecurity : IUnlocable
    {
        public void Unlock()
        {
            Console.WriteLine("Einfache Unlocking");
        }
    }
}
