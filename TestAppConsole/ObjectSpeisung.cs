using System;

namespace TestAppConsole
{
    [Serializable]
    // [XmlInclude(typeof(ObjectSpeisung))]
    public class ObjectSpeisung
    {
        public string Name1 { get; set; }
        public string Email1 { get; set; }
        public int Age1 { get; set; }
        public DateTime Birthdate1 { get; set; }
        public bool IsPlatinumMember1 { get; set; }
    }
}
