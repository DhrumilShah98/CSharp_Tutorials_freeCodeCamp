namespace P20_ClassesAndObjects
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;
        public Song(string title, string artist, int duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            songCount++;
        }
    }
}
