using System;

namespace Interfaces
{
    public class FaceUnlock : IUnlocable, ICheckable
    {
        public void CheckHardware()
        {
            Console.WriteLine("Face sensor control");
        }

        public void Unlock()
        {
            Console.WriteLine("Face unlock check");
            CheckHardware();
            Console.WriteLine("Face unlock done");
        }
    }
}
