using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace DesignerPdfViewer
{
    public class NotesStore
    {
        private List <Note> notes = new  List< Note> ();
        public NotesStore() { }
        public void AddNote(String state, String name) {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty");
            }
            if (!state.Equals("completed") || !state.Equals("active") || !state.Equals("others"))
            {
                throw new Exception("Invalid state " + state);
            }
            notes.Add(new Note() { State = state, Name = name });
        }
        public List<String> GetNotes(String state) {
            if (!(state.Equals("completed") || state.Equals("active") || state.Equals("others")))
            {
                throw new Exception("Invalid state " + state );
            }
            if (notes.Count ==0)
            {
                return new List<string>();
            }
            else
            {
                return notes.Where(d=>d.State==state).Select(d=>d.Name).ToList();
            }
        }
    }

    public class Note
    {
        public string    State { get; set; }
        public string Name { get; set; }
    }
   

}
