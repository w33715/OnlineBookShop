using System;

namespace ORMLesson1
{
    public class Note
    {
        // Constructor
        public Note
            ()
        { }
        public Note(string text, DateTime date)
        {
            //Id = id;
            Text = text;
            Date = date;
        }

        // Feilds
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool IsActual { get; set; }
        public string OwnerName { get; set; }

    }
}
