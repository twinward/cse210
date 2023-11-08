using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
    public class Prompt
        {
            // Attributes
            public List<Prompt> _prompts = new List<Prompt>();

            //Behaviors
            public void Display() //Find *random* prompt
            {
                foreach (Prompt prompt in _prompts)
                {
                    prompt.Display();
                }
            }
        }

    public class Entry
        {
            // Attributes
            public string _date;
            public string _prompt;
            public string _entry;

            /* Behaviors
                1, GET prompt (from Prompt class)
                2, GET user input / store
                3, GET date
            */
        }

    public class Journal
    {
        // Attributes
        public string _fileName;
        public List<Entry> _jobs = new List<Entry>();
        
        /* Behaviors
            PUT journal (iterate through entries)
            LOAD journal
        */

    }

    }
}

