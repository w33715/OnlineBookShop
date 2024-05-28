using System;
using System.Linq;

namespace ORMLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // database connection
            Console.WriteLine("Meine To-Do Liste");
            using (

                var context = new DataContext())
            {
                ////---------- Data added
                //Note note = new Note("Hausaufgabe", DateTime.Now);
                //context.Notes.Add(note);
                //context.SaveChanges();
                ////-------------------


                ////------------ Data readed
                var notes = context.Notes.ToList();
                foreach (var item in notes)
                {
                    Console.WriteLine(item.Text);
                }
                ////-----------------------

                ////---Data edited
                //var notes = context.Notes.FirstOrDefault(x => x.Id == 2);
                //notes.Text = "ZuHause";
                //context.SaveChanges();
                ////--------------

                //-----Data deleted
                //var notes = context.Notes.FirstOrDefault(x => x.Id == 2);
                //context.Notes.Remove(notes);
                //context.SaveChanges();
                //-----------------


            }

            //Console.WriteLine(note.Text);
            Console.ReadKey();
        }
    }
}
