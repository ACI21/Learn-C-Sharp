using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Solution
{
    public class NotesStore
    {
        private List<String> notes;

        public NotesStore() {}
        public void AddNote(String state, String name) 
        {
            string patron = @"\b(active|completed|others)\b";
            Regex regex = new Regex(patron);
            MatchCollection matches = regex.Matches(state);

            if (matches.Count > 0)
            {
            }
            else
            {
                Console.WriteLine("No se encontraron estados.");
            }
        }
        public List<String> GetNotes(String state) {
            throw new ArgumentException();
        }
    } 
    public class BlocNotas
    {
        public static void main() 
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++) {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    } else {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}