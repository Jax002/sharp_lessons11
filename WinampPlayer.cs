using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winamp
{
    public class WinampPlayer
    {
        private readonly List<Song> _playlist;
        private readonly Queue<Song> _historyQueue = new Queue<Song>();
        private readonly HashSet<string> _historySet = new HashSet<string>();
        private const int HistoryLimit = 5;
        private readonly Random _random = new Random();
        public WinampPlayer(List<Song> songs)
        {
            if (songs.Count <= HistoryLimit)
            {
                throw new Exception("Count songs must be more " + HistoryLimit);
            }
            _playlist = songs;
        }
        public async Task StartSync()
        {
            while (true)
            {
                Song nextSong;

                do
                {
                    nextSong = _playlist[_random.Next(_playlist.Count)];
                } while (_historySet.Contains(nextSong.Title));

                Console.Clear();
                Console.WriteLine("Winamp");
                Console.WriteLine($"Now play: {nextSong.Title} {nextSong.DurationSeconds}  сек.");

                await Task.Delay(2000);

                Console.WriteLine("last 5");
                foreach (var s in _historyQueue.Reverse())
                    Console.WriteLine(s.Title);
                await Task.Delay(6000);

                _historyQueue.Enqueue(nextSong);
                _historySet.Add(nextSong.Title);

                if (_historyQueue.Count > HistoryLimit)
                {
                    var oldSong = _historyQueue.Dequeue();
                    _historySet.Remove(oldSong.Title);
                }
            }
        }
    }
}
