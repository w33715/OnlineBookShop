namespace Interfaces
{
    public class Phone<T> where T : Identity
    {

        public Phone(IUnlocable type)
        {
            Security = type;
        }

        public T Owner { get; set; }
        public IUnlocable Security { get; set; }
        public void UnlockPhone()
        {
            Security.Unlock();
        }
    }
}
