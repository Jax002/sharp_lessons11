using winamp;

var songs = new List<Song>
        {
            new Song("Dracula - JENNIE Remix", 185),
            new Song("DAISIES - Justin Bieber", 210),
            new Song("drop dead - Olivia Rodrigo", 195),
            new Song("Stateside - PinkPantheress", 160),
            new Song("Risk It All - Bruno Mars", 225),
            new Song("Babydoll - Dominic Fike", 140),
            new Song("Man Need - Olivia Dean", 180),
            new Song("WHERE IS MY HUSBAND! - RAYE", 205),
            new Song("Opalite - Taylor Swift", 230),
            new Song("Golden - KATSEYE", 175),
            new Song("Self Aware - HUNTR/X", 190),
            new Song("Temper - City Girls", 165),
            new Song("Earrings - Malcolm Todd", 155),
            new Song("I Can't Love You Anymore", 240),
            new Song("Manchild - Sabrina Carpenter", 200),
            new Song("NOBLE - F3miii", 170),
            new Song("Mr. Know It All - Teddy Swims", 215),
            new Song("Potential - sombr", 150),
            new Song("The Visitor - SIENNA SPIRO", 185),
            new Song("White Keys - Dominic Fike", 145)
        };

var player = new WinampPlayer(songs);
await player.StartSync();
