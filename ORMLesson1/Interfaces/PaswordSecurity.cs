namespace Interfaces
{
    public class PaswordSecurity : IUnlocable, ICheckable
    {
        string Password { get; set; }

        public void CheckHardware()
        {
            throw new System.NotImplementedException();
        }

        public void Unlock()
        {
            CheckHardware();
        }
    }
}
