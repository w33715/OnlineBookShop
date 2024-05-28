using System;

namespace Interfaces
{
    public class FingerPrintUnlock : IUnlocable, ICheckable
    {
        public void CheckHardware()
        {
            Console.WriteLine("FingerPrint sensor control");
        }

        public void Unlock()
        {
            Console.WriteLine("FingerPrint unlock check");
            CheckHardware();
            Console.WriteLine("FingerPrint unlock done");
        }
    }
}
