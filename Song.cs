using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    class Song
    {
        public string title { get; set; }
        public string artist { get; set; }
        public int duration { get; set; }
        public static int songCount { get; set; } = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            this.title = aTitle;
            this.artist = aArtist;
            this.duration = aDuration;
            songCount++;
        }
        public int getSongCount()
        {
            return songCount;
        }
    }
}
