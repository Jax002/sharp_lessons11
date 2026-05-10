using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winamp
{
    public class Song
    {
        public string Title { get; set; }
        public int DurationSeconds { get; set; }

        public Song(string title, int durationSeconds)
        {
            Title = title;
            DurationSeconds = durationSeconds;
        }
    }
}
