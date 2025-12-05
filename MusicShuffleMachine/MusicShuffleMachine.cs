namespace MusicShuffleMachine
{
    internal class MusicShuffleMachine
    {
        static void Main(string[] args)
        {

            List<(string songName, string songRunTime)> songs = new List<(string, string)>();
            songs.Add(("Rooster", "6:14"));
            songs.Add(("Nutshell", "4:19"));
            songs.Add(("Missing", "4:56"));
            songs.Add(("Sultans of Swing", "5:48"));
            songs.Add(("Workin Man Blues", "5:15"));
            songs.Add(("Aerials", "3:55"));
            songs.Add(("Layla", "7:03"));
            songs.Add(("El Paso", "4:19"));
            songs.Add(("God the Animal", "6:03"));
            songs.Add(("Major Crimes", "3:33"));

            List<(string, int)> customPlaylist = CreatePlaylist(songs, 15);



            foreach (var song in customPlaylist)
            {
                Console.WriteLine($"{song.Item1} with a runtime of {song.Item2} seconds.");
            }
        }


        static List<(string, string)> ShuffleMusic(List<(string, string)> songs)
        {
            Random rand = new Random();
            for (int i = songs.Count - 1; i > 0; --i)
            {
                int k = rand.Next(i + 1); //this is the random song we take to shuffle

                var temp = songs[i];
                songs[i] = songs[k];
                songs[k] = temp;
            }
            return songs;
        }

        static List<(string, int)> ShuffleMusic(List<(string, int)> songs)
        {
            Random rand = new Random();
            for (int i = songs.Count - 1; i > 0; --i)
            {
                int k = rand.Next(i + 1); //this is the random song we take to shuffle

                var temp = songs[i];
                songs[i] = songs[k];
                songs[k] = temp;
            }
            return songs;
        }


        static List<(string, int)> CreatePlaylist(List<(string, string)> songs, int desiredLengthInMinutes)
        {
            int desiredLengthInSeconds = desiredLengthInMinutes * 60;
          

            List<(string, int)> songsInSeconds = new List<(string, int)> ();
            foreach (var song in songs)
            {
                string[] parts = song.Item2.Split(':');
                int totalSeconds = int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
                songsInSeconds.Add((song.Item1, totalSeconds));
            }

            ShuffleMusic(songsInSeconds);

            List<(string, int)> playlist = new List<(string, int)> ();
            int currentSeconds = 0;

            foreach (var song in songsInSeconds)
            {
                if(currentSeconds + song.Item2 <= desiredLengthInSeconds)
                {
                    playlist.Add(song);
                    currentSeconds += song.Item2;
                }
            }
            return playlist;

        }
    }
}
